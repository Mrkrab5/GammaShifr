using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammaShifr
{
    internal class mod2
    {

        public mod2() 
        { 
        
        }

        static public string Decoding(string massenge, string key)
        {
            string tmpString = massenge.ToUpper(), tmpKey = "",
                bigReg = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ", result = "";
                                    
            if (massenge.Length > key.Length)
            {
                for (int i = 0; i < massenge.Length; i++)
                    tmpKey += key[i % key.Length];
            }

            tmpKey = tmpKey.ToUpper();

            for (int i = 0; i < massenge.Length; i++)
                result += $"{bigReg[tmpString[i] ^ tmpKey[i]]}";

            return result;
        }
    }
}
