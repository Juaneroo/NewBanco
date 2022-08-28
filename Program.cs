using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoAPP
{
    class Cliente
    {
        public string nombre;
        private int monto;

        public Cliente(string nom)
        {
            
            nombre = nom;
            monto = 0;
        }

        public void Depositar(int m)
        {
            
            monto = monto + m;
        }

        public void Retirar(int ret)
        {
            
            monto = monto - ret;
        }

        public int RegresarDinero()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }

        
    }

    class Banco
    {
        private Cliente Usuario1, Usuario2, Usuario3;

        public Banco()
        {
            Console.Write("Ingrese nombre del cliente 1: ");
            Usuario1 = new Cliente(Console.ReadLine());
            Console.Write("Ingrese nombre del cliente 2: ");
            Usuario2 = new Cliente(Console.ReadLine());
            Console.Write("Ingrese nombre del cliente 3: ");
            Usuario3 = new Cliente(Console.ReadLine());

        }

        

        public void TotalDepositos()
        {
            int total = Usuario1.RegresarDinero() +
                    Usuario2.RegresarDinero() +
                    Usuario3.RegresarDinero();
            Console.WriteLine("El dinero depositado en el banco es:" + total);
            Usuario1.Imprimir();
            Usuario2.Imprimir();
            Usuario3.Imprimir();
        }

        public void Operar(int opcion)
        {
            string montoDepositar, montoRetirar, nombreOperar;
            int montoDeposito, montoRetiro;

            Console.Write("Ingresa tu nombre por favor: ");
            nombreOperar = Console.ReadLine();

            if (int opcion == 1)
            {
                Console.Write("Ingresa el monto a depositar: ");
                montoDepositar = Console.ReadLine();
                montoDeposito = int.Parse(montoDepositar);

                if (nombreOperar == Usuario1.nombre)
                {
                    Usuario1.Depositar(montoDeposito);
                }
                else if (nombreOperar == Usuario2.nombre)
                {
                    Usuario2.Depositar(montoDeposito);
                }
                else if (nombreOperar == Usuario3.nombre)
                {
                    Usuario3.Depositar(montoDeposito);
                }
                else
                {
                    Console.Write("Nombre no registrado: ");
                }

            }
            else if (int opcion == 2)
            {

                Console.Write("Ingresa el monto a retirar: ");
                montoRetirar = Console.ReadLine();
                montoRetiro = int.Parse(montoRetirar);

                if (nombreOperar == Usuario1.nombre)
                {
                    Usuario1.Retirar(montoRetiro);
                }
                else if (nombreOperar == Usuario2.nombre)
                {
                    Usuario2.Retirar(montoRetiro);
                }
                else if (nombreOperar == Usuario3.nombre)
                {
                    Usuario3.Retirar(montoRetiro);
                }
                else
                {
                    Console.Write("Nombre no registrado: ");
                }
            }
            else
            {
                Console.Write("Opción no valida");

            }

        }




        static void Main(string[] args)
        {
            bool salir = false;
            Banco banco1 = new Banco();

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Si desea guardar dinero marque 1");
                    Console.WriteLine("2. Si desea retirar dinero marque 2");
                    Console.WriteLine("3. Si desea salir del menú marque 3");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has elegido depositar dinero");
                            break;

                        case 2:
                            Console.WriteLine("Has elegido retirar dinero");
                            break;

                        case 3:
                            Console.WriteLine("Has elegido salir del menú");
                            salir = true
                            break;
            |               default:
                            Console.WriteLine("Por favor elige una opcion entre 1 y 3");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            banco1.TotalDepositos();
            Console.ReadLine();
        }
    }
}