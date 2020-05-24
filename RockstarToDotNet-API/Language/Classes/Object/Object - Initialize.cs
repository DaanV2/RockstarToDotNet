using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Rockstar.Language {
    ///DOLATER <summary>add description for class: Object</summary>
    public sealed partial class Object {
        /// <summary>Creates a new instance of <see cref="Object"/></summary>
        public Object() {
            this.Name = String.Empty;
            this.Fields = null;
            this.Functions = null;
        }
    }
}
