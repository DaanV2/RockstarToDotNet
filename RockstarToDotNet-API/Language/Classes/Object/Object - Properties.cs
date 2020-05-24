using System;

namespace Rockstar.Language {
    public sealed partial class Object {
        /// <summary>
        /// 
        /// </summary>
        public Variable[] Fields { get; set; }

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
        public Function[] Functions { get; set; }
    }
}
