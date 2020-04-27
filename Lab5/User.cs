using System;

namespace Solucion_Lab_21_abril
{
    public class User
    {
        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);

        public event EmailVerifiedEventHandler EmailVerified;

        public void OnEmailSent(object source , EventArgs no)
        {
            int eleccion;
            Console.WriteLine("Desea Verificar su Correo? ");
            Console.WriteLine("0.- Si ");
            Console.WriteLine("1.- No ");
            eleccion = Convert.ToInt32(Console.ReadLine());

            if(eleccion == 0 || eleccion == 1)
            {
                if(eleccion == 0)
                {
                    EmailVerified(this, EventArgs.Empty);
                }
                else if(eleccion == 1)
                {
                    Console.WriteLine("OK , no se verificara su correo ...");
                }
            }
            else
            {
                Console.WriteLine("Opcion invalida ...");
            }
        }
    }
}
