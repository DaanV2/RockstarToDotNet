using System;
using System.Collections.Generic;

namespace Rockstar.Language {
    public sealed partial class Type : IEquatable<Type> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(Type other) {
            return other != null &&
                   this.Name == other.Name &&
                   EqualityComparer<Type[]>.Default.Equals(this.GenericArguments, other.GenericArguments);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            Int32 hashCode = 1658089832;
            hashCode = hashCode * -1521134295 + EqualityComparer<String>.Default.GetHashCode(this.Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<Type[]>.Default.GetHashCode(this.GenericArguments);
            return hashCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(Type left, Type right) {
            return EqualityComparer<Type>.Default.Equals(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(Type left, Type right) {
            return !(left == right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override String ToString() {
            if (this.GenericArguments == null || this.GenericArguments.Length == 0) {
                return $"{this.Name}<{String.Join<Type>(", ", this.GenericArguments)}> ";
            }

            return this.Name;
        }
    }
}
