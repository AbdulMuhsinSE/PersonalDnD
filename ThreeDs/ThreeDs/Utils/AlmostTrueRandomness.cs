using System;
using System.Security.Cryptography;

namespace ThreeDs.Utils
{
    class AlmostTrueRandomness : Random
    {
		//changed to .Net Core implementation
		RandomNumberGenerator random = RandomNumberGenerator.Create();
        private byte[] _uint32Buffer = new byte[4];

        public override Int32 Next(Int32 minValue, Int32 maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(minValue));
            }

            if (minValue == maxValue) { return minValue; }

            Int64 diff = maxValue - minValue;
            while (true)
            {
                random.GetBytes(_uint32Buffer);
                UInt32 rand = BitConverter.ToUInt32(_uint32Buffer, 0);

                Int64 max = (1 + (Int64)UInt32.MaxValue);
                Int64 remainder = max % diff;
                if (rand < max - remainder)
                {
                    return (Int32)(minValue + (rand % diff));
                }
            }
        }
    }
}
