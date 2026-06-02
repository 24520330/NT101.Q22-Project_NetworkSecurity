using System;
using System.Numerics;

namespace RSAVirtualization
{
    public class RSACore
    {
        public BigInteger P { get; private set; }
        public BigInteger Q { get; private set; }
        public BigInteger N { get; private set; }
        public BigInteger PhiN { get; private set; }
        public BigInteger E { get; private set; }
        public BigInteger D { get; private set; }

        // Đổi thành public để Form1 có thể dùng chung, tránh viết lại code
        public bool IsPrime(BigInteger number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (BigInteger i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public void InitializeKeys(string pText, string qText, string eText)
        {
            P = BigInteger.Parse(pText);
            Q = BigInteger.Parse(qText);
            E = BigInteger.Parse(eText);

            if (!IsPrime(P)) throw new Exception("P phải là số nguyên tố.");
            if (!IsPrime(Q)) throw new Exception("Q phải là số nguyên tố.");
            if (P == Q) throw new Exception("P và Q phải khác nhau.");

            N = BigInteger.Multiply(P, Q);
            PhiN = BigInteger.Multiply(P - 1, Q - 1);

            if (E <= 1 || E >= PhiN) throw new Exception("E phải thỏa mãn 1 < E < Phi(N).");
            if (CalculateGCD(E, PhiN) != 1) throw new Exception("E và Phi(N) không nguyên tố cùng nhau.");

            D = CalculatePrivateKey(E, PhiN);
        }

        private BigInteger CalculatePrivateKey(BigInteger e, BigInteger phi)
        {
            BigInteger d = 0, x1 = 0, x2 = 1, y1 = 1, tempPhi = phi;

            while (e > 0)
            {
                BigInteger temp1 = tempPhi / e;
                BigInteger temp2 = tempPhi - temp1 * e;
                tempPhi = e;
                e = temp2;

                BigInteger x = x2 - temp1 * x1;
                BigInteger y = d - temp1 * y1;

                x2 = x1;
                x1 = x;
                d = y1;
                y1 = y;
            }

            if (tempPhi == 1)
            {
                if (d < 0) d += phi;
                return d;
            }

            throw new Exception("e và Phi(N) không nguyên tố cùng nhau. Không thể tạo khóa bí mật!");
        }

        public BigInteger Encrypt(BigInteger message)
        {
            return BigInteger.ModPow(message, E, N);
        }

        public BigInteger Decrypt(BigInteger cipherText)
        {
            return BigInteger.ModPow(cipherText, D, N);
        }

        public BigInteger CalculateGCD(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}