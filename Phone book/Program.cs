using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_book
{
    internal class Program
    {
        /// <summary>
        /// Поиск владельца по номеру телефона
        /// </summary>
        static void OwnerSearch(Dictionary<string, string> PhoneBook)
        {
            Console.WriteLine("Введите номер телефона владельца, которого хотите найти:");

            string value = "";

            if (PhoneBook.TryGetValue(Console.ReadLine(), out value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Владелец этого номера не найден");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Ввод данных телефон / Ф.И.О.
        /// </summary>
        /// <param name="PhoneBook"></param>
        static void DataInput(Dictionary<string, string> PhoneBook)
        {
            Console.WriteLine("Введите номер телефона и Ф.И.О. его владельца (чтобы пропустить введите пустую строку)");

            string phoneNumber = " ";
            string fullName = " ";

            while (phoneNumber != string.Empty || fullName != string.Empty)
            {
                Console.Write("Номер телефона: ");

                phoneNumber = Console.ReadLine();

                Console.Write("Ф.И.О.: ");

                fullName = Console.ReadLine();

                PhoneBook.Add(phoneNumber, fullName);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            DataInput(phoneBook);

            OwnerSearch(phoneBook);
        }
    }
}
