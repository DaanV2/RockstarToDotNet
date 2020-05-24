using System;
using System.IO;

namespace Rockstar.Language.LexicalAnalyzer {
    ///DOLATER <summary>Add description for struct: LAContext</summary>
    internal partial struct LAContext {
        /// <summary>Creates a new instance of <see cref="LAContext"/></summary>
        /// <param name="line"></param>
        /// <param name="reader"></param>
        /// <param name="out"></param>
        public LAContext(String line, StreamReader reader, Output @out) {
            this.Line = line;
            this.Reader = reader;
            this.Out = @out;
        }

        internal String Line;
        internal StreamReader Reader;
        internal Output Out;
    }
}
