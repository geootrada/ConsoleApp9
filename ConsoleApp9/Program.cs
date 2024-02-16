using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPeopleQueue;
            int timePatientAdmission = 10;
            int timeWaitingQueue;
            int minutesPerHour = 60;
            int hours;
            int minutes;

            Console.WriteLine("Добро пожаловать в нашу поликлинику! Мы поможем вам определить время ожидания приема.");
            Console.Write("Сколько людей сейчас в очереди: ");
            numberPeopleQueue = Convert.ToInt32(Console.ReadLine());

            timeWaitingQueue = numberPeopleQueue * timePatientAdmission;
            hours = timeWaitingQueue / minutesPerHour;
            minutes = timeWaitingQueue - hours * minutesPerHour;

            Console.WriteLine($"Время вашего ожидания {hours} часов {minutes} минут");
        }
    }
}
