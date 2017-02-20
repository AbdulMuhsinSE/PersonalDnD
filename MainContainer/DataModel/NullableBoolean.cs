using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * This class was written while referencing 
 * https://msdn.microsoft.com/en-us/library/aa664483(v=vs.71).aspx
 */

namespace MainContainer.DataModel
{
    public class NullableBoolean
    {
        public static readonly NullableBoolean Null = new NullableBoolean(0);
        public static readonly NullableBoolean Negative = new NullableBoolean(-1);
        public static readonly NullableBoolean Positive = new NullableBoolean(1);

        private sbyte value;
        // -1 will indicate: false, negative or bad outcome
        // 1 will indicate: true, positive, or good outcome
        // 0 will indicate: maybe, unkown, null, or routine outcome

        private NullableBoolean(int val)
        {
            this.value = (sbyte)val;
        }

        public bool IsNull { get { return value == 0; } }
        public bool IsNeg { get { return value == -1; } }
        public bool isPos { get { return value == 1; } }

        //Allow implicit conversion from bool to NullableBool. True maps to 1, False maps to -1
        public static implicit operator NullableBoolean(bool x)
        {
            return x ? Positive: Negative;
        }

        //Explicit conversion to prim type bool. If Null then throws exception
        public static explicit operator bool(NullableBoolean nb)
        {
            if (nb.value == 0)
            {
                throw new InvalidOperationException();
            }
            return nb.value > 0;
        }

        //Some might argue that nulls are not equal, as we do not truly know their value
        //for our purpose within this product we do not need that level of abstraction
        //we will be satisfied with Null NullableBooleans being considered equal
        public static bool operator ==(NullableBoolean x, NullableBoolean y)
        {
            return x.value == y.value ? true : false;
        }

        public static bool operator ==(NullableBoolean x, bool y)
        {
            return (bool)x == y;
        }

        public static bool operator ==(bool y, NullableBoolean x)
        {
            return (bool)x == y;
        }

        public static bool operator !=(NullableBoolean x, NullableBoolean y)
        {
            return x.value != y.value ? true : false;
        }

        public static bool operator !=(NullableBoolean x, bool y)
        {
            return (bool)x == y;
        }

        public static bool operator !=(bool y, NullableBoolean x)
        {
            return (bool)x == y;
        }

        public static NullableBoolean operator !(NullableBoolean x)
        {
            return new NullableBoolean(-x.value);
        }

        //Definition of how the AND operator works. REMEMBER False<Null<True
        public static NullableBoolean operator &(NullableBoolean x, NullableBoolean y)
        {
            return new NullableBoolean(x.value < y.value ? x.value : y.value);
        }

        //Def of OR operator
        public static NullableBoolean operator |(NullableBoolean x, NullableBoolean y)
        {
            return new NullableBoolean(x.value > y.value ? x.value : y.value);
        }

        //Def of true operator. Returns true if true
        public static bool operator true(NullableBoolean x)
        {
            return x.value > 0;
        }

        public static bool operator false(NullableBoolean x)
        {
            return x.value < 0;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is NullableBoolean)) return false;
            return value == ((NullableBoolean)obj).value;
        }

        public override int GetHashCode()
        {
            return value;
        }

        public override string ToString()
        {
            if (value > 0) return "True";
            if (value < 0) return "False";
            return "Null";
        }
    }
}
