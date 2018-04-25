/*
Display some information about the system: Windows version, dot net 
version, current user name, documents folder and free space and total 
space in all the disk partitions
*/

// Brandon Blasco Del Cid,improved by Nacho

using System;
using System.IO;

class SystemInfo
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("OS: " + Environment.OSVersion);
        Console.WriteLine(".NET Version: " + Environment.Version);
        Console.WriteLine("User Name: " + Environment.UserName);
        Console.WriteLine("Documents Folder: " + 
            Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments));

        String[] disks = Environment.GetLogicalDrives();
        Console.WriteLine("Logic drives: {0}", 
            String.Join(", ", disks));
            
        Console.WriteLine("Free Space in each logic drive: ");
        DriveInfo[] partitions = DriveInfo.GetDrives();
        for(int i = 0; i < disks.Length; i++)
        {
            if (partitions[i].IsReady)
                Console.WriteLine(partitions[i].Name + "  " +
                    partitions[i].TotalFreeSpace / 1024 / 1024 / 1024 + " GB"+
                    " free out of " + 
                    partitions[i].TotalSize / 1024 / 1024 / 1024 + " GB");
        }
    }
}
