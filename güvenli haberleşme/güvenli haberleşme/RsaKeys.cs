using System;
using System.Numerics;
namespace güvenli_haberleşme
{
    public static class RSAKeys
    {
        public static (BigInteger PublicKey, BigInteger PrivateKey, BigInteger n) GenerateKeyPair(bool GenerateOwnKey, string pValue, string qValue)
        {
            BigInteger p, q;
            if (GenerateOwnKey == true)
            {
                p = Convert.ToInt32(pValue);
                q = Convert.ToInt32(qValue);
                if (IsPrime(p) && IsPrime(q))
                {
                    var n = p * q;
                    var phi = (p - 1) * (q - 1);
                    var e = 3;
                    while (GCD(e, phi) != 1)
                    {
                        e += 2;
                    }
                    var d = ModInverse(e, phi);
                    return (e, d, n);
                }
                else
                {
                    return (1, 1, 1);
                }
            }
            else
            {
                p = GenerateRandomPrime();
                q = GenerateRandomPrime();
                var n = p * q;
                var phi = (p - 1) * (q - 1);
                var e = 3;
                while (GCD(e, phi) != 1)
                {
                    e += 2;
                }
                var d = ModInverse(e, phi);
                return (e, d, n);
            }
        }
        static BigInteger ModInverse(BigInteger a, BigInteger n)
        {
            BigInteger i = n, v = 0, d = 1;
            while (a > 0)
            {
                BigInteger t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) v = (v + n) % n;
            return v;
        }
        private static BigInteger GCD(BigInteger x, BigInteger y)
        {
            BigInteger Remainder;
            while (y != 0)
            {
                Remainder = x % y;
                x = y;
                y = Remainder;
            }
            return x;
        }
        static BigInteger GenerateRandomPrime()
        {
            var rnd = new Random();
            var num = rnd.Next(1000, 10000);
            if (IsPrime(num))
            {
                return num;
            }
            else
            {
                return GenerateRandomPrime();
            }
        }
        static bool IsPrime(BigInteger num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }
            if (num % 2 == 0)
            {
                return false;
            }
            for (BigInteger i = 3; i <= Sqrt(num); i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static BigInteger Sqrt(this BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);
                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }
                return root;
            }
            throw new ArithmeticException("NaN");
        }
        private static Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);
            return (n >= lowerBound && n < upperBound);
        }
    }
}