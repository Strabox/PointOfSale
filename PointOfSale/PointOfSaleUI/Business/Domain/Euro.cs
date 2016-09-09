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


        public Euro()
        {
            IntegerPart = 0;
            DecimalPart = 0;
        }

        public Euro(int integerPart,int decimalPart)
        {
            IntegerPart = integerPart;
            DecimalPart = decimalPart;
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

        public static Euro operator +(Euro e1,Euro e2)
        {
            Euro res = new Euro();
            int decimalAux = e1.DecimalPart + e2.DecimalPart;
            res.IntegerPart = e1.IntegerPart + e2.IntegerPart;
            if(decimalAux >= 100)
            {
                res.IntegerPart++;
                res.DecimalPart = decimalAux % 100;
            }
            else
            {
                res.DecimalPart = decimalAux;
            }
            return res;
        }

        public static Euro operator -(Euro e1, Euro e2)
        {
            Euro res = new Euro();
            int integerPartSub = e1.IntegerPart - e2.IntegerPart;
            int centsPartSub = e1.DecimalPart - e2.DecimalPart;
            if(integerPartSub < 0 || (integerPartSub == 0 && centsPartSub < 0))
            {
                throw new NegativeEuroResultException();
            }
            res.IntegerPart = integerPartSub;
            if(centsPartSub < 0)
            {
                res.IntegerPart--;
                res.DecimalPart = 100 - (-centsPartSub);
            }
            else
            {
                res.DecimalPart = centsPartSub;
            }
            return res;
        }

        public static Euro operator *(Euro e1, int times)
        {
            Euro res = new Euro();
            if(times < 0)
            {
                throw new ArgumentException("Can't be negative multiplier");
            }
            else if(times == 0)
            {
                res.IntegerPart = 0;
                res.DecimalPart = 0;
            }
            else if(times == 1)
            {
                res.IntegerPart = e1.IntegerPart;
                res.DecimalPart = e1.DecimalPart;
            }
            else
            {
                Euro initial = new Euro(e1.IntegerPart, e1.DecimalPart);
                for(int i = 0; i < times; i++)
                {
                    res += initial;
                }
            }
            return res;
        }

        public static Euro operator*(int times,Euro e1)
        {
            return e1 * times;
        }

        public void Add(Euro euro)
        {
            Euro aux = this + euro;
            IntegerPart = aux.IntegerPart;
            DecimalPart = aux.DecimalPart;
        }

        public void Subtract(Euro euro)
        {
            Euro aux = this - euro;
            IntegerPart = aux.IntegerPart;
            DecimalPart = aux.DecimalPart;
        }

        public void Multiply(int times)
        {
            Euro aux = times * this;
            IntegerPart = aux.IntegerPart;
            DecimalPart = aux.DecimalPart;
        }
         
        public static string GetSymbol()
        {
            return SYMBOL;
        }

        public override bool Equals(object obj)
        {
            Euro euro = obj as Euro;
            return euro.IntegerPart == IntegerPart && euro.DecimalPart == DecimalPart;
        }

        public override string ToString()
        {
            if(DecimalPart < 10 && DecimalPart > 0)
            {
                return IntegerPart + ",0" + DecimalPart;
            }
            else
            {
                return IntegerPart + "," + DecimalPart;
            }
        }

        public override int GetHashCode()
        {
            return IntegerPart + DecimalPart;
        }

        /* ======================= Serialization Items ======================= */

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("integerPart", IntegerPart);
            info.AddValue("decimalPart", DecimalPart);
        }
    }
}
