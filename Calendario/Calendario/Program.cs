using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0;
            int mes = 0;
            int dia = 0;

            if (ano % 4 != 0)
            {
                switch (mes)
                {
                    case 4:
                        Calculo(dia);
                        break;
                    case 6:
                        Calculo(dia);
                        break;
                    case 9:
                        Calculo(dia);
                        break;
                    case 11:
                        Calculo(dia);
                        break;
                    default:
                        break;
                }
            }//se for bi

        }
        public static int Calculo(int dia,int mes)
        {
            if (dia == 30)
            {
                dia = 1;
                mes++;
                return dia, mes;
            }
            else
            {
                dia++;
            }
        }
    }
}
