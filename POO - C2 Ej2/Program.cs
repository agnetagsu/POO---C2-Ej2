using System;

namespace POO___C2_Ej2
{
    class Employee
    {
        private string nombre;
        private decimal sueldo;

        public Employee(string nombre, decimal sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }
        public void printEmployee()
        {
            System.Console.WriteLine("Nombre: {0}\nSueldo: {1}", nombre, sueldo);
        }

        public decimal Sueldo
        {
            get { return sueldo; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public void PagarImpuestos()
        {
            if (this.sueldo > 3000)
            {
                System.Console.WriteLine("{0} debe pagar impuestos", this.nombre);
            }
            else
            {
                System.Console.WriteLine("{0} no tiene que pagar impuestos", this.nombre);
            }
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Employee A1 = new Employee("Cristina", 3100);
            A1.printEmployee();
            A1.PagarImpuestos();

        }
    }
}
