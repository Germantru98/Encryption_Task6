using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Task6
{
    class Program
    {

        static void Main(string[] args)
        {
            //передаем в конструктор класса буквы русского алфавита
            var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            DataPharser dp = new DataPharser();
            var inputText = dp.getMessage("Message.txt").ToUpper();
            Console.Write("Введите ключ: ");
            var password = Console.ReadLine().ToUpper();
            var encryptedText = cipher.Encrypt(inputText, password);
            Console.WriteLine("Зашифрованное сообщение: {0}", encryptedText);
            Console.WriteLine("Расшифрованное сообщение: {0}", cipher.Decrypt(encryptedText, password));
            Console.ReadLine();
        }
    }
}
