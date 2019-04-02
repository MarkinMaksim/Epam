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

        public static Polynomial operator +(Polynomial pol1, double Number)
        {
            double[] result = new double[pol1.coefficient.Length];

            for (int i = 0; i < pol1.coefficient.Length; i++)
            {
                result[i] = pol1.coefficient[i] + Number;
            }

            return new Polynomial(result);
        }

        public static Polynomial operator +(double Number, Polynomial pol1)
        {
            double[] result = new double[pol1.coefficient.Length];

            for (int i = 0; i < pol1.coefficient.Length; i++)
            {
                result[i] = pol1.coefficient[i] + Number;
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
                result[i] = pol1.coefficient[i] + (-1 * pol2.coefficient[i]);
            }

            return new Polynomial(result);
        }

        public static Polynomial operator -(Polynomial pol1, double Number)
        {
            double[] result = new double[pol1.coefficient.Length];

            for (int i = 0; i < pol1.coefficient.Length; i++)
            {
                result[i] = pol1.coefficient[i] + (-1 * Number);
            }

            return new Polynomial(result);
        }

        public static Polynomial operator -(double Number, Polynomial pol1)
        {
            double[] result = new double[pol1.coefficient.Length];

            for (int i = 0; i < pol1.coefficient.Length; i++)
            {
                result[i] = pol1.coefficient[i] + (-1 * Number);
            }

            return new Polynomial(result);
        }

        public static Polynomial operator *(Polynomial pol1, Polynomial pol2)
        {
            double[] result = new double[pol1.coefficient.Length * pol2.coefficient.Length];
            int k = 0;
            for (int i = 0; i < pol1.coefficient.Length; i++)
            {
                for (int j = 0; j < pol2.coefficient.Length; j++)
                {
                    result[k] = pol1.coefficient[i] * pol2.coefficient[j];
                    k++;
                }
            }

            return new Polynomial(result);
        }

        public static Polynomial operator *(Polynomial pol1, double Number)
        {
            double[] result = new double[pol1.coefficient.Length];

            for (int i = 0; i < pol1.coefficient.Length; i++)
            {
                    result[i] = pol1.coefficient[i] * Number;
            }

            return new Polynomial(result);
        }

        public static Polynomial operator *(double Number, Polynomial pol1)
        {
            double[] result = new double[pol1.coefficient.Length];

            for (int i = 0; i < pol1.coefficient.Length; i++)
            {
                result[i] = pol1.coefficient[i] * Number;
            }

            return new Polynomial(result);
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (this is null || obj is null)
            {
                return false;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }
            var polynomial = obj as Polynomial;

            for (int i = 0; i < polynomial.coefficient.Length; i++)
            {
                if (polynomial.coefficient[i] != this.coefficient[i])
                    return false;
            }

            return true;
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
