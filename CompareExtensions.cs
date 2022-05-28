using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib
{
    public static class CompareExtensions
    {
        /// <summary>
        /// verificar se o numero é par (ou nao)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsEven(double n) => (n % 2 == 0);
    }
}
