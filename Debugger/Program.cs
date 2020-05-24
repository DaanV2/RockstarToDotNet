using System;
using System.IO;

namespace Debugger {
    internal class Program {
        private static void Main(String[] args) {
            String ExecutingFolder = AppDomain.CurrentDomain.BaseDirectory;
            String SolutionFolder = FindSolutionDirectory(ExecutingFolder);
            String[] RockstarCodeFiles = Directory.GetFiles(SolutionFolder, "*.rock")
        }


        private static String FindSolutionDirectory(String StartDirectory) {
            String[] Files = Directory.GetFiles(StartDirectory, "*.sln");

            while (Files == null || Files.Length == 0) {
                StartDirectory = Path.GetDirectoryName(StartDirectory);
            }

            return StartDirectory;
        }
    }
}
