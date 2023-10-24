using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammaShifr
{
    internal class modN
    {

        public modN() 
        {
        
        }

        static public string Decoding(string massenge, string key)
        {
            string tmpString = massenge.ToUpper(), tmpKey = "", 
                bigReg = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ", result = "";

            int[] arrayMassenge = new int[massenge.Length], arrayKey = new int[massenge.Length];

            if (massenge.Length > key.Length)
            {
                for (int i = 0; i < massenge.Length; i++)
                    tmpKey += key[i % key.Length];
            }

            tmpKey = tmpKey.ToUpper();

            for (int i = 0; i < massenge.Length; i++)
            {
                for (int j = 0; j < bigReg.Length; j++)
                {
                    if (tmpString[i] == bigReg[j])
                        arrayMassenge[i] = j;
                    
                    if (tmpKey[i] == bigReg[j])
                        arrayKey[i] = j;
                }
            }

            for (int i = 0; i < massenge.Length; i++)
                result += $"{bigReg[(arrayMassenge[i] + arrayKey[i]) % bigReg.Length]}";

            return result;
        }
    }
}
