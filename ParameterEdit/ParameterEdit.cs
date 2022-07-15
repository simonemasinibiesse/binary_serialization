using System;
using System.Collections.Generic;

namespace BinarySerializationProblem.ParameterEdit
{
    [Serializable]
    public abstract class ParameterEdit 
    {
        public ParameterEdit() { }


        public ParameterEdit(ParameterEdit src)
            : this()
        {
            CanRaiseModified = src.CanRaiseModified;
            IsCustomized = src.IsCustomized;
        }

        public static readonly string ArgsSeparator = "  ";
        public static readonly string ArgsDBSeparator = "\r\n";
        public static readonly string ListSeparator = ";";
        private static readonly string ClassNameSuffix = "ParameterEdit";

        /// <summary>
        /// Definisce le corrispondenze tra gli acronimi utilizzati dai file stb e le proprietà dei vari oggetti ParameterEdit in modo da disaccoppiare i due nomi.
        /// La Key è l'acronimo, mentre Value è il nome della proprietà dell'oggetto ParameterEdit.
        /// </summary>
        protected virtual Dictionary<string, string> TokenToProperty
        {
            get
            {
                return new Dictionary<string, string>(StringComparer.Ordinal);
            }
        }

        public bool CanRaiseModified { get; set; }

        public bool IsCustomized { get; set; }

        protected bool IsReadOnly
        {
            get { return false; }
        }

        protected abstract bool IsTypeAdmissible();

        public virtual string Args { get { return string.Empty; } }

        public abstract ParameterTypes ParameterType { get; }

        public abstract object Clone();
    }
}
