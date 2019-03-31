using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._05
{
    public sealed class Polynomial
    {
        private double[] coefficient;

        public Polynomial(params double[] coef)
        {
            if (coef == null)
                throw new ArgumentNullException(nameof(coef));
            if (coef.Length <= 1)
                throw new ArgumentException(nameof(coef));

            coefficient = coef;
        }

        private static double[] MaxMinLength(Polynomial pol1, Polynomial pol2, out int min)
        {
            double[] result;

            if (pol1.coefficient.Length >= pol2.coefficient.Length)
            {
                result = new double[pol1.coefficient.Length];
                min = pol2.coefficient.Length;
            }
            else
            {
                result = new double[pol2.coefficient.Length];
                min = pol1.coefficient.Length;
            }
            return result;
        }

        public static Polynomial operator +(Polynomial pol1, Polynomial pol2)
        {
            double[] result;
            int minLength;

            result = MaxMinLength(pol1, pol2, out minLength);

            for (int i = 0; i < minLength; i++)
            {
                result[i] = pol1.coefficient[i] + pol2.coefficient[i];
            }

            return new Polynomial(result);
        }


        public static Polynomial operator -(Polynomial pol1, Polynomial pol2)
        {
            double[] result;
            int minLength;

            result = MaxMinLength(pol1, pol2, out minLength);

            for (int i = 0; i < minLength; i++)
            {
                result[i] = pol1.coefficient[i] - pol2.coefficient[i];
            }

            return new Polynomial(result);
        }

        public static Polynomial operator *(Polynomial pol1, Polynomial pol2)
        {
            double[] result;
            int minLength;

            result = MaxMinLength(pol1, pol2, out minLength);

            for (int i = 0; i < minLength; i++)
            {
                result[i] = pol1.coefficient[i] * pol2.coefficient[i];
            }

            return new Polynomial(result);
        }

        private bool IsEqual(double[] first, double[] second)
        {
            if (first.Length != second.Length)
                return false;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                    return false;
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            var polynomial = obj as Polynomial;
            return polynomial != null && IsEqual(this.coefficient, polynomial.coefficient);
        }

        public static bool operator ==(Polynomial first, Polynomial second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Polynomial first, Polynomial second)
        {
            return !first.Equals(second);
        }

        public override string ToString()
        {
            string resultStr = string.Empty;

            for (int i = coefficient.Length - 1; i > 0; i--)
            {
                if (coefficient[i] != 0)
                {
                    if (coefficient[i] > 0 && resultStr != string.Empty)
                        resultStr += "+";
                    resultStr += (Convert.ToString(coefficient[i]) + "*x^" + Convert.ToString(i));
                }
            }

            if (coefficient[0] >= 0 && resultStr != string.Empty)
                resultStr += "+";
            resultStr += Convert.ToString(coefficient[0]);

            return resultStr;
        }

        public override int GetHashCode()
        {

            int hashcode = 17;

            for (int i = 0; i < coefficient.Length; i++)
            {
                hashcode = (hashcode * 7) + coefficient[i].GetHashCode();
            }

            return hashcode;
        }
    }
}
