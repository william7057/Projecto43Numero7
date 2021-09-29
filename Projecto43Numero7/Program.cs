using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto43Numero7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int NivelU = 0, Admin=0 , Ica=0;
            int CNU = 0,CA=0 , Cica=0 ,CNica=0;
            while (x<=2)
            {
                Console.WriteLine("Tiene Nivel Universitario ?");
                Console.WriteLine("Si Opcion[1], No Opcion[2]");
                NivelU = int.Parse(Console.ReadLine());
                if (NivelU==1)
                {
                    CNU = CNU + 1;
                }
                Console.WriteLine("=======================================");
                Console.WriteLine("Es Adminitrador ?");
                Console.WriteLine("Si Opcion[1], No Opcion[2]");
                Admin = int.Parse(Console.ReadLine());
                if (Admin==1)
                {
                    CA = CA + 1;
                }
                Console.WriteLine("=======================================");
                Console.WriteLine("Es de Ica ?");
                Console.WriteLine("Si Opcion[1], No Opcion[2]");
                Ica = int.Parse(Console.ReadLine());
                if (Ica==1)
                {
                    Cica = Cica + 1;
                }
                else
                {
                    CNica = CNica + 1;
                }

                x = x + 1;
            }

            Console.WriteLine("Cantidad de vendedores que son de nivel universitario : {0} ", CNU);
            Console.WriteLine("Cantidad de vendedores que son de profesión administradores: {0}", CA);
            Console.WriteLine(" Cantidad de vendedores que no son del distrito de Ica : {0}", CNica);

            Console.ReadLine();
        }
    }
}
