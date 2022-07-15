using System;

namespace BinarySerializationProblem.Exceptions
{
    public class ReadOnlyElementException : Exception
    {
        public ReadOnlyElementException()
            : base("Non è possibile modificare il valore di un elemento in sola lettura.")
        {

        }
    }
}
