using System;
using composicao_exercicio.Entities.Enums;
using composicao_exercicio.Entities;

namespace composicao_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Departament name");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data");
            Console.Write("Name :");
            string name = Console.ReadLine();
            Console.Write("Enter level (Junior/mid level/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Enter base salary");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);//instanciei objeto departamento

            Worker worker = new Worker(name, level, baseSalary, dept);//inst objeto worker

            Console.Write("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter #{i} contract data: ");
                Console.Write("Date ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Vlue per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration(hours) ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);

            }


        }
    }
}
