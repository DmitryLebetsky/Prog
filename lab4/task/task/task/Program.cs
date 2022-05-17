using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class InternetOperator
    {
        private static InternetOperator instance;
        private Tariff tariff = new Tariff();
        private InternetOperator()
        {
        }
        public static InternetOperator getInstance()
        {
            if (instance == null)
            {
                instance = new InternetOperator();
            }
            return instance;
        }
        public void setTariff(int price, string name, int usersCount)
        {
            tariff = new Tariff(price, name, usersCount);
        }
        public int getTotalRevenue()
        {
            return this.tariff.getPrice() * this.tariff.getUsersCount();
        }
        public void setPrice(int newPrice)
        {
            this.tariff.setPrice(newPrice);
        }
    }

    class Tariff
    {
        private int price;
        private string name;
        private int usersCount;
        public Tariff(int price = 0, string name = "", int usersCount = 0)
        {
            this.price = price;
            this.name = name;
            this.usersCount = usersCount;
        }
        public int getPrice()
        {
            return this.price;
        }
        public int getUsersCount()
        {
            return this.usersCount;
        }
        public void setPrice(int newPrice)
        {
            this.price = newPrice;
        }
    }
}
