using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Persistence
{
    public static class PersistenceManager
    {

        public static readonly string PERSISTENT_DATA_FILE = "PointOfSaleStatistic.pos";

        public static readonly string PERSISTENT_ITEMS_FILE = "PointOfSaleItems.pos";


        public static void PersistObjectToBinaryFile(string filePath, Object o)
        {
            Stream stream = File.Open(filePath, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, o);
            stream.Close();
        }

        public static Object GetObjectFromBinaryFile(string filePath)
        {
            try
            {
                Stream stream = File.Open(filePath, FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Object res = binaryFormatter.Deserialize(stream);
                stream.Close();
                return res;
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }

    }
}
