using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;


namespace FileExplorer
{
    public static class FileSystem
    {
        //Загрузка в дерево для поиска.
        public static void LoadFileTree(object _node)
        {
            TreeItem node = (TreeItem) _node;

            foreach (string entry in Directory.EnumerateFileSystemEntries(node.ItemData))
            {
                FileAttributes attr = File.GetAttributes(entry);
                if (attr.HasFlag(FileAttributes.System))
                    continue;

                try
                {
                    Directory.GetAccessControl(entry);
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }


                TreeItem childNode;

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    childNode = new TreeItem(entry, node);
                    node.AddChild(childNode);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadFileTree), childNode);
                }
                else
                {
                    childNode = new TreeItem(entry, node);
                    node.AddChild(childNode);
                }
            }
        }


        //path без спец. символов. //TODO нужно сделать без этого метода
        public static TreeItem GetFileTreeNodeByPath(string path, TreeItem fileTree)
        {
            string[] parts = path.Split('\\');

            TreeItem currentNode = null;

            void NextNode(TreeItem node, int step)
            {
                if (step >= parts.Length) return;

                foreach (TreeItem childNode in node.Childs)
                {
                    if (step == 0)
                    {
                        string name = childNode.ItemData.Split('\\')[0];
                        if (name == parts[step])
                        {
                            currentNode = childNode;
                            NextNode(childNode, step + 1);
                        }
                    }
                    else
                    {
                        string name = childNode.ItemData.Split('\\').Last();
                        if (name == parts[step])
                        {
                            currentNode = childNode;
                            NextNode(childNode, step + 1);
                        }
                    }
                }
            }

            NextNode(fileTree, 0);
            return currentNode;
        }



        public static void CopyAndPasteDirectory(DirectoryInfo sourceDir, DirectoryInfo destDir)
        {
            //Является ли целевая папка подкаталогом исходной папки.
            for (DirectoryInfo dirInfo = destDir.Parent; dirInfo != null; dirInfo = dirInfo.Parent)
            {
                if (dirInfo.FullName == sourceDir.FullName)
                    throw new Exception("Target folder is a subdirectory of the source folder.");
            }

            //Создать папку назначения.
            if (!Directory.Exists(destDir.FullName))
                Directory.CreateDirectory(destDir.FullName);

            //Копирование файлов.
            foreach (FileInfo fileInfo in sourceDir.GetFiles())
            {
                fileInfo.CopyTo(Path.Combine(destDir.FullName, fileInfo.Name));
            }

            //Рекурсивное копирование подпапок.
            foreach (DirectoryInfo sourceSubDir in sourceDir.GetDirectories())
            {
                DirectoryInfo destSubDir = destDir.CreateSubdirectory(sourceSubDir.Name);
                CopyAndPasteDirectory(sourceSubDir, destSubDir);
            }
        }


        public static string FileSizeStr(long fileSize)
        {
            string fileSizeStr = string.Empty;

            //MidpointRounding.AwayFromZero - если с одной стороны ноль, то округляется до другого числа

            if (fileSize < 1024 * 1024)
                fileSizeStr = Math.Round(fileSize * 1.0 / 1024, 2, MidpointRounding.AwayFromZero) + " KB";
            else if (fileSize >= 1024 * 1024 && fileSize < 1024 * 1024 * 1024)
                fileSizeStr = Math.Round(fileSize * 1.0 / (1024 * 1024), 2, MidpointRounding.AwayFromZero) + " MB";
            else if (fileSize >= 1024 * 1024 * 1024)
                fileSizeStr = Math.Round(fileSize * 1.0 / (1024 * 1024 * 1024), 2, MidpointRounding.AwayFromZero) +
                              " GB";

            return fileSizeStr;
        }


        //в байтах
        public static long GetDirectorySize(string dir)
        {
            long size = 0;
            DirectoryInfo directoryInfo = new DirectoryInfo(dir);

            //Добавить размеры всех файлов в текущей директории.
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            if (fileInfos.Length > 0)
            {
                size += fileInfos.Sum(fileInfo => fileInfo.Length);
            }

            //Рекурсивно добавить размеры поддиректорий.
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            if (directoryInfos.Length > 0)
            {
                size += directoryInfos.Sum(dirInfo => GetDirectorySize(dirInfo.FullName));
            }

            return size;
        }


        public static bool IsValidFileName(string fileName)
        {
            bool isValid = true;
            const string errChar = "\\/:*?\"<>|";

            foreach (var ch in errChar)
            {
                if (fileName.Contains(ch.ToString()))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }
    }
}