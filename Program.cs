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

        public void Operaciones()
        {
            String mDepositar, mRetirar, mOperar;
            int mDeposito, mRetiro;

            Console.WriteLine("Por favor ingrese su Usuario");
            mOperar = Console.ReadLine();

            if (mOperar==Usuario1.nombre)
            {

            }
        }




        static void Main(string[] args)
        {
            string strEleccion;
            int intEleccion;
            
            Banco banco1 = new Banco();
            do
            {
                Console.Write("Bienvenido al grupo Bancario. Si desea depositar marque 1, Si desea retirar marque 2: Si desea finalizar la operación marca 0. ");
                strEleccion = Console.ReadLine();
                intEleccion = int.Parse(strEleccion);

                if (intEleccion!=0)
                {
                    banco1.Operaciones();
                }

            } while (intEleccion != 0);


            banco1.TotalDepositos();
            Console.ReadKey();
        }
    }
}