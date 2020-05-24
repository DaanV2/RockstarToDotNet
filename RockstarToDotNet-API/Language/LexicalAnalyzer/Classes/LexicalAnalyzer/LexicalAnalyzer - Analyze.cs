using System;
using System.IO;
using System.Text;

namespace Rockstar.Language.LexicalAnalyzer {
    public partial class LexicalAnalyzer {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        public Output Analyze(String Filepath) {
            Stream stream = new FileStream(Filepath, FileMode.Open);
            Output Out = this.Analyze(stream, Path.GetFileNameWithoutExtension(Filepath));

            stream.Close();

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public Output Analyze(Stream stream, String Filename) {
            StreamReader Reader = new StreamReader(stream, Encoding.UTF8);
            Output Out = new Output();
            LAContext Context = new LAContext(String.Empty, Filename, Reader, Out);

            while (!Reader.EndOfStream) {
                Context.Line = Reader.ReadLine();

                this.AnalyzeLine(Context);
            }

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Context"></param>
        private void AnalyzeLine(LAContext Context) {
            String Line = Context.Line;
            String[] Parts = Line.Split(' ');

            Int32 Length = Parts.Length;

            if (Length == 0) {
                return;
            }

            if (Parts[1] == "takes") {

            }

            
        }
    }
}
