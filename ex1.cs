#region Read me please
// Application Name: MyApp
// Created by DotNET Nuclear C# Compiler
// Date Created: Walking Armageddon	// Author: RIT
#endregion
#region Using directives
using System;
using System.Reflection;
using System.IO;
#endregion
#region Assembly attributes
[assembly: AssemblyTitle("MyApp")]
[assembly: AssemblyProduct("MyApp")]
[assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyDescription("Created by DotNET Nuclear C# Compiler")]
[assembly: AssemblyCompany("DotNET Nuclear C# Compiler")]
[assembly: AssemblyCopyright("Copyright © 2018")]
 #endregion


namespace FileHandlingArticleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(File.Exists("abc.txt"))
            {
                string content = File.ReadAllText("abc.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            Console.WriteLine("Please enter new content for the file:");
            string newContent = Console.ReadLine();
            File.WriteAllText("ab.txt", newContent);
        }
    }
}

