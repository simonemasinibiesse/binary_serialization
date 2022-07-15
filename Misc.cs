using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializationProblem
{
    internal class Misc
    {
        public static byte[] SerializeToByteArray(object obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(ms, obj);
                return ms.GetBuffer();
            }
        }

        public static T DeserializeFromByteArray<T>(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
