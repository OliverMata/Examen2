using System;

namespace programa_1
{
     class Empleados
    {
       private string[] nombre;
       private float[] sueldo;

        public void Cargar() 
        {
            nombre=new string[5];
            sueldo=new float[5];
            for(int x=0; x < nombre.Length; x++) 
            {
                Console.WriteLine();
                Console.Write("Ingrese el nombre del empleado: ");
                nombre[x] = Console.ReadLine();
                Console.Write("Ingrese el sueldo: ");
                string n;
                n = Console.ReadLine();
                sueldo[x]=float.Parse(n);
            }
        }

        public void MayorSueldo() 
        {
            float mayor;
            int pos;
            mayor = sueldo[0];
            pos = 0;
            for(int f=1; f < nombre.Length; f++) 
            {
                if (sueldo[f] > mayor) 
                {
                    mayor = sueldo[f];
                    pos=f;
                }
            }
            Console.WriteLine();
            Console.WriteLine("El empleado con sueldo mayor es " + nombre[pos]);
            Console.WriteLine("Tiene un sueldo: " + mayor);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Empleados obj = new Empleados();
            obj.Cargar();
            obj.MayorSueldo();
        }
    }
}

