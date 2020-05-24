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
            Output Out = this.Analyze(stream);

            stream.Close();

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public Output Analyze(Stream stream) {
            StreamReader Reader = new StreamReader(stream, Encoding.UTF8);
            Output Out = new Output();
            LAContext Context = new LAContext(String.Empty, Reader, Out);

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

        }
    }
}
