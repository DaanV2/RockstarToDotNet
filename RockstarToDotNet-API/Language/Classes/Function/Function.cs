using System;

namespace Rockstar.Language {
    public sealed partial class Function : INamedObject, ICommentCarrier {
        /// <summary>
        /// 
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Variable[] Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Comment Comment { get; set; }
    }
}
