using System;

namespace Rockstar.Language {
    public sealed partial class Type {
        /// <summary>
        /// 
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Type[] GenericArguments { get; set; }
    }
}
