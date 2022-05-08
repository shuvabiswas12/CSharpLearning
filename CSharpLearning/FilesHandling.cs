using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    class FilesHandling
    {

        /**
             * 
             * System.IO namespace
             * -------------------------
             * 
             * File, FileInfo => provding methods for creating creating, copying, 
             *                   moving, opening and deleteing of files. There are a simple difference between File and FileInfo.
             *                   File provides static methods whereas FileInfo provides instance methods.
             *                   
             *                   methods are :=>
             *                   ---------------
             *                   
             *                    Create()
             *                    Copy()
             *                    Delete()
             *                    Exists()
             *                    GetAttributes()
             *                    Move()
             *                    ReadAllText()
             *                    
             * --------------------------------------------------------------
             * --------------------------------------------------------------
             *                   
             *                   
             * Directory, DirectoryInfo =>  Directory provides static methods whereas DirectoryInfo provides instance methods.
             *                              
             *                              methods are :=>
             *                              ---------------
             *                   
             *                                  CreateDirectory()
             *                                  GetCurrentDirectory()
             *                                  Delete()
             *                                  Exists()
             *                                  GetFiles()
             *                                  Move()
             *                                  GetLogicalDrives()
             * 
             * --------------------------------------------------------------
             * --------------------------------------------------------------
             * 
             * Path =>  
             *          methods are :=>
             *          ----------------
             *            GetDirectoryName()
             *            GetFileName()
             *            GetExtension()
             *            GetTempPath()
             * 
             * */

        private static string PcUsername;

        public FilesHandling()
        {
            PcUsername = GetPcUsername();
            GetCurrentDirectory();
            CreateDirectory();
            DeleteDirectory();
            CopyDirectory();
            MoveDirectory();

            CreateFile();
            MoveFile();
            CopyFile();
        }


        static string GetPcUsername()
        {
            var username = Environment.UserName;
            Console.WriteLine("Username : " + username);
            return username;
        }

        static string GetCurrentDirectory()
        {
            // This will give the current WORKING directory (i.e. \bin\Debug)
            var debugDirectory = Environment.CurrentDirectory;

            // or
            Directory.GetCurrentDirectory(); // return same result (i.e. \bin\Debug)

            // This will get the current PROJECT bin directory (ie ../bin/)
            string binDirctory = Directory.GetParent(debugDirectory).Parent.FullName;

            // This will give the actual working directory
            var rootDir = Directory.GetParent(debugDirectory).Parent.Parent.FullName;

            Console.WriteLine("Current Directory is : " + rootDir);
            return rootDir;
        }

        static string CreateDirectory(string dirName = "New Folder")
        {
            var path = String.Format(@"C:\Users\{0}\Desktop\{1}", PcUsername, dirName);

            Directory.CreateDirectory(path);
            Console.WriteLine("Directory created.");

            return path;
        }

        static void DeleteDirectory()
        {
            var path = String.Format(@"C:\Users\{0}\Desktop\New Folder", PcUsername);
            Directory.Delete(path);
            Console.WriteLine("Directory is deleted.");
        }

        static void MoveDirectory()
        {

        }

        static void CopyDirectory()
        {
            var path_1 = CreateDirectory("Dir_1");
            var path_2 = CreateDirectory("Dir_2");

            // copy directory code here...

            Console.WriteLine("Copy Completed.");
        }

        static string CreateFile(string fileName = "MyFile.txt")
        {
            var filePath = String.Format(@"C:\Users\{0}\Desktop\{1}", PcUsername, fileName);

            // File.Create(filePath);

            /*
             * Use using block if you do not want to get any error during copy or delete any files.
             * Using block close the file statement operation automatically when the using block scope 
             * is finished.
             */

            using (File.Create(filePath)) 
            { }
            
            Console.WriteLine("File is created.");

            return filePath;
        }

        static void MoveFile()
        {
            var sourcePath = String.Format(@"C:\Users\{0}\Desktop\MyFile.txt", PcUsername);
            var destinationPath = String.Format(@"C:\Users\{0}\Desktop\Dir_2\MyFile.txt", PcUsername);

            if (File.Exists(sourcePath))
            {
                File.Move(sourcePath, destinationPath, true);
                Console.WriteLine("Moving done.");
            } else
            {
                Console.WriteLine("Moving failed.");
            }

        }

        static void CopyFile()
        {
            var path = CreateFile("dummyFile.txt");
            var destinationPath = String.Format(@"C:\Users\{0}\Desktop\Dir_1\dummyFile.txt", PcUsername);
            if (File.Exists(path))
            {
                File.Copy(path, destinationPath);
                Console.WriteLine("Copying done.");
            } else
            {
                Console.WriteLine("Copying failed.");
            }
            

        }

        static void DeleteFile()
        {

        }

        static void GetFilePath()
        {

        }

        static void RenameFile()
        {

        }

        static void GetFileExtenstion()
        {

        }

        static void ResizeAnImage()
        {

        }

        static void GetImagesOrFilesMetaData()
        {

        }


    }
}
