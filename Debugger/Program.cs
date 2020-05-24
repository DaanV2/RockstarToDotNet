using System;
using System.IO;
using Rockstar.Language.LexicalAnalyzer;

namespace Debugger {
    internal class Program {
        private static void Main(String[] args) {
            String ExecutingFolder = AppDomain.CurrentDomain.BaseDirectory;
            String SolutionFolder = FindSolutionDirectory(ExecutingFolder);
            String[] RockstarCodeFiles = Directory.GetFiles(SolutionFolder, "*.rock", SearchOption.AllDirectories);

            LexicalAnalyzer Analyzer = new LexicalAnalyzer();

            for (Int32 I = 0; I < RockstarCodeFiles.Length; I++) {
                Output Output = Analyzer.Analyze(RockstarCodeFiles[I]);
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }


        private static String FindSolutionDirectory(String StartDirectory) {
            String[] Files = Directory.GetFiles(StartDirectory, "*.sln");

            while (Files == null || Files.Length == 0) {
                Files = Directory.GetFiles(StartDirectory, "*.sln");
                StartDirectory = Path.GetDirectoryName(StartDirectory);
            }

            return StartDirectory;
        }
    }
}
