using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Check <T>
    {
        private T Number {  get; set; }
        private double Balance { get; set; }
        private string FIO { get; set; }
        //public Check (T number, double balance, string fio)
        //{
        //    this.Number = number;
        //    this.Balance = balance;
        //    this.FIO = fio;
        //}
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Number= (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс счета");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            FIO = Console.ReadLine();

        }
        public string Output() 
        { 
            return ($"{Number} {Balance} {FIO}");
        
        }
        
    }
    

}
