using System;
using System.Linq;

namespace UseParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(13,27,45,80,35)); //istediğimiz kadar sayı gönderebiliriz..
        }

        static int Add(params int[] numbers) //params buradaki Add metodundaki diziyi dinamik hale getirir. İstediğimiz kadar verilen sayıları taoplamamızı sağlar.
        {
            return numbers.Sum(); //number degiskeninin degerlerini toplar        
        }
    }
}
