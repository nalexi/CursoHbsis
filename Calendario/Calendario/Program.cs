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

            if (ano%4 != 0)
            {
                switch (mes)
                {
                    case 4:
                        if (dia == 30)
                        {
                            dia = 0;
                            mes++;
                        }
                        else
                        {
                            dia++; 
                        }
                        break;
                    default:
                }
            }//se for bi
            
            

               

                   
            
            

        }
    }
}
