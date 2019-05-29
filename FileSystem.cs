using System;
using System.IO;
using System.Linq;


namespace FileExplorer
{
    public static class FileSystem
    {
        //TODO копирование в отдельном потоке
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
                fileSizeStr = Math.Round(fileSize * 1.0 / (1024 * 1024 * 1024), 2, MidpointRounding.AwayFromZero) + " GB";

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
