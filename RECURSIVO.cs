using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1._5
{
    internal class Recursividad
    {
        public string SumaSecuencia(int n)
        {
            if (n <= 0) return "0";
            StringBuilder sb = new StringBuilder();
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
                sb.Append(i);
                if (i < n)
                    sb.Append(" + ");
            }
            sb.Append(" = " + suma);
            return sb.ToString();
        }
        public string FactorialSecuencia(int n)
        {
            if (n < 0) return "No definido";
            if (n == 0) return "0! = 1";

            StringBuilder sb = new StringBuilder();
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sb.Append(i);
                if (i < n)
                    sb.Append(" x ");
            }
            sb.Append(" = " + fact);
            return sb.ToString();
        }
        public string FibonacciSecuencia(int n)
        {
            if (n < 0) return "No definido";
            if (n == 0) return "0";

            StringBuilder sb = new StringBuilder();
            int a = 0, b = 1;
            sb.Append(a);

            for (int i = 1; i < n; i++)
            {
                sb.Append(", " + b);
                int temp = a + b;
                a = b;
                b = temp;
            }

            return sb.ToString();
        }
    }
}