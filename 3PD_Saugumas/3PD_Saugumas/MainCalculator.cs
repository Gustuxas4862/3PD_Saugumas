namespace _3PD_Saugumas
{
    internal class MainCalculator
    {
        public int CalculateModulusN(int prime1, int prime2)
        {
            prime1 = findNearestPrime(prime1);
            prime2 = findNearestPrime(prime2);

            return prime1 * prime2;
        }

        public int CalculatePhiTotientExponent(int prime1, int prime2)
        {
            return (prime1 - 1) * (prime2 - 1);
        }

        public int CalculateEncryptionExponent(int phiExponent)
        {
            int encryptionExponent = 0;

            while (encryptionExponent < phiExponent)
            {
                if (findGreatestCommonDivisor(encryptionExponent, phiExponent) == 1 && encryptionExponent > 1)
                {
                    break;
                }
                else
                {
                    encryptionExponent++;
                }
            }

            return encryptionExponent;
        }

        private bool isPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            double sqrtOfNumber = MathF.Sqrt(number);

            for (int i = 2; i <= sqrtOfNumber; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private int findNearestPrime(int number)
        {
            int tempNumber = number;

            while (true)
            {
                if (isPrime(tempNumber))
                {
                    return tempNumber;
                }
                else
                {
                    tempNumber++;
                }
            }
        }

        private int findGreatestCommonDivisor(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            return a | b;
        }

        public List<int> CalculateFactorsOfNumber(int value)
        {
            List<int> factors = new List<int>();
            int maxValue = (int)Math.Sqrt(value);

            for (int factor = 2; factor <= maxValue; factor++)
            {
                if (value % factor == 0)
                {
                    factors.Add(factor);

                    if (factor != value / factor)
                    {
                        factors.Add(value / factor);
                    }
                }
            }

            return factors;
        }

        public int CrackPrivateKey(int encryptionExponent, int phiExponent)
        {
            int crackIndex = 0, decryptionExponent = 0;

            while (true)
            {
                crackIndex++;

                if (encryptionExponent * crackIndex % phiExponent == 1)
                {
                    decryptionExponent = crackIndex;
                    break;
                }
            }

            return decryptionExponent;
        }
    }
}
