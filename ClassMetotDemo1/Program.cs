using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-----Yazılım Geliştirme Kampı-Engin Demiroğ-----Ödev
              ClassMetotDemo projesi oluştur.
              Customer isimli Class oluştur(bilgi ekle). CustomerManager sınıfı oluşturup parametre 
              kullanarak Müşteri Ekleme,Silme,Listeleme gibi metotlar simule et. */

            Customers customer1 = new Customers();
            customer1.Id = 12345;
            customer1.name = "Ege";
            customer1.surname = "Büyük";
            customer1.Age = 28;
            customer1.Iban = 987654321;

            Customers customer2 = new Customers();
            customer2.Id = 9876;
            customer2.name = "Efe";
            customer2.surname = "Derin";
            customer2.Age = 30;
            customer2.Iban = 135791113;

            Customers customer3 = new Customers();
            customer3.Id = 5678910;
            customer3.name = "Can";
            customer3.surname = "Küçük";
            customer3.Age = 32;
            customer3.Iban = 24681012;


            CustomerManagers customerManager = new CustomerManagers();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("********************");
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);

            Console.ReadLine();

        }
    }
    }
