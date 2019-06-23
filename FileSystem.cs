using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace FileExplorer
{
    public static class FileSystem
    {
        //https://stackoverflow.com/questions/5188527/how-to-deal-with-files-with-a-name-longer-than-259-characters
        public const string LONG_PATH_PREFIX = @"\\?\";


        public static string AddLongPathPrefix(this string path)
        {
            return LONG_PATH_PREFIX + path;
        }


        public static string WithoutLongPathPrefix(this string path)
        {
            return path.Replace(LONG_PATH_PREFIX, "");
        }


        //Загрузка в дерево для поиска.
        public static void LoadFileTreeAsync(object _node)
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
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadFileTreeAsync), childNode);
                }
                else
                {
                    childNode = new TreeItem(entry, node);
                    node.AddChild(childNode);
                }
            }
        }


        //path с префиксом
        public static TreeItem GetFileTreeNodeByPath(string path, TreeItem fileTree)
        {
            if (path == fileTree.ItemData)
                return fileTree;

            string[] tokens = path
                .WithoutLongPathPrefix()
                .Split(new char[] {'\\'}, StringSplitOptions.RemoveEmptyEntries);

            TreeItem currentNode = null;

            void nextNode(TreeItem node, int step)
            {
                if (step >= tokens.Length) return;

                foreach (TreeItem childNode in node.Childs)
                {
                    string name = childNode.ItemData.WithoutLongPathPrefix()
                        .Split(new char[] {'\\'}, StringSplitOptions.RemoveEmptyEntries)
                        .Last();
                    if (name == tokens[step])
                    {
                        currentNode = childNode;
                        nextNode(childNode, step + 1);
                    }
                }
            }

            nextNode(fileTree, 0);
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
        public static long GetDirectorySize(string dirPath)
        {
            if (!Directory.Exists(dirPath))
                throw new ArgumentException("This is not a directory");

            long getSize(string dir)
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
                foreach (DirectoryInfo dirInfo in directoryInfos)
                {
                    size += getSize(dirInfo.FullName);
                }

                return size;
            }

            return getSize(dirPath);
        }


        public static bool IsValidFileName(string fileName)
        {
            const string errChar = "\\/:*?\"<>|";

            foreach (char ch in errChar)
            {
                if (fileName.Contains(ch.ToString()))
                    return false;
            }
            return true;
        }
    }
}