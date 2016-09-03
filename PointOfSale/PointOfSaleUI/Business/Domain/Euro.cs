using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Domain
{
    /// <summary>
    ///     Represents a quantity in Euro money
    /// </summary>
    [Serializable]
    public class Euro : IMoney<Euro> , ISerializable
    {
        private static readonly string SYMBOL = "€";

        /// <summary>
        ///     Varies from 0 to 2^32 or 2^64
        /// </summary>
        private int integerPart;
        public int IntegerPart
        {
            get { return integerPart; }
            set
            {
                if(value < 0)
                {
                    throw new InvalidParameterMoneyException();
                }
                integerPart = value;
            }
        }

        /// <summary>
        ///     Varies from 0 - 99
        /// </summary>
        private int decimalPart;
        public int DecimalPart
        {
            get { return decimalPart; }
            set
            {
                if(value  < 0 || value > 99)
                {
                    throw new InvalidParameterMoneyException();
                }
                decimalPart = value;
            }
        }


        public Euro(int integerPart,int decimalPart)
        {
            IntegerPart = integerPart;
            DecimalPart = decimalPart;
        }

        public Euro()
        {
            IntegerPart = 0;
            DecimalPart = 0;
        }

        /// <summary>
        ///     Deserialization Constructor
        /// </summary>
        /// <param name="info">Serialization information</param>
        /// <param name="context">Serialization context information</param>
        public Euro(SerializationInfo info, StreamingContext context)
        {
            IntegerPart = info.GetInt32("integerPart");
            DecimalPart = info.GetInt32("decimalPart");
        }


        public void Add(Euro euro)
        {
            int decimalSum = euro.DecimalPart + DecimalPart;
            IntegerPart += euro.IntegerPart;
            if (decimalSum >= 100)
            {
                IntegerPart++;
                DecimalPart = decimalSum % 100;
            }
            else
            {
                DecimalPart = decimalSum;
            }
        }

        public void Subtract(Euro euro)
        {
            int integerPartSub = IntegerPart - euro.IntegerPart;
            int decimalPartSub = DecimalPart - euro.decimalPart;
            if (integerPartSub < 0 || (integerPartSub == 0 && decimalPartSub < 0))
            {
                throw new NegativeEuroResultException();
            }
            IntegerPart = integerPartSub;
            if(decimalPartSub < 0)
            {
                IntegerPart--;
                DecimalPart = 100 - (-decimalPartSub);
            }
            else
            {
                DecimalPart = decimalPartSub;
            }
        }

        public void Multiply(int times)
        {
            if (times < 0)
            {
                throw new ArgumentException("Can't be negative multiplier");
            }
            else if (times == 0)
            {
                IntegerPart = 0;
                DecimalPart = 0;
            }
            else if (times == 1){
                return;
            }
            else
            {
                times--;
                Euro initial = new Euro(IntegerPart, DecimalPart);
                for (int i = 0; i < times; i++)
                {
                    Add(initial);
                }
            }
        }
         
        public static string GetSymbol()
        {
            return SYMBOL;
        }

        public override string ToString()
        {
            if(DecimalPart < 10)
            {
                return IntegerPart + ",0" + DecimalPart;
            }
            else
            {
                return IntegerPart + "," + DecimalPart;
            }
        }

        /* ======================= Serialization Items ======================= */

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("integerPart", IntegerPart);
            info.AddValue("decimalPart", DecimalPart);
        }
    }
}
