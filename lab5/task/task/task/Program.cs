using System;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Provider provider = new Provider();

            Tariff velcomTariff = new Tariff("velcom", 100);
            Customer customerDmitry = new Customer("Дмитрий", 20);
            Customer customerAlex = new Customer("Александр", 10);
            velcomTariff.registerCustomer(customerDmitry);
            velcomTariff.registerCustomer(customerAlex);
            provider.addTariff(velcomTariff);

            Tariff MTSTariff = new Tariff("MTS", 20);
            Customer customerMasha = new Customer("Маша", 30);
            Customer customerDasha = new Customer("Даша", 15);
            MTSTariff.registerCustomer(customerMasha);
            MTSTariff.registerCustomer(customerDasha);
            provider.addTariff(MTSTariff);
            Console.WriteLine(provider.getTotalConsumedTrafficPrice());
            Console.WriteLine(provider.getRichestCustomer());
        }
    }
    public class Provider
    {
        List<Tariff> listTariff = new List<Tariff>();
        public void addTariff(Tariff tariff)
        {
            listTariff.Add(tariff);
        }
        public int getTotalConsumedTrafficPrice()
        {
            int summ = 0;
            foreach(Tariff trafficItem in listTariff)
            {
                foreach(Customer customerItem in trafficItem.getListCustomer())
                {
                    summ += customerItem.getUsedMBAmount() * trafficItem.getPrice();
                }
            }
            return summ;
        }
        public string getRichestCustomer()
        {
            string richestCustomerName = "";
            foreach(Tariff tariffItem in listTariff)
            {
                int paidAmountPrev = 0;
                foreach(Customer customerItem in tariffItem.getListCustomer())
                {
                    if (richestCustomerName == "")
                    {
                        richestCustomerName = customerItem.getName();
                        paidAmountPrev = customerItem.getUsedMBAmount() * tariffItem.getPrice();
                        continue;
                    }
                    int paidAmount = customerItem.getUsedMBAmount() * tariffItem.getPrice();
                    if (paidAmount > paidAmountPrev)
                    {
                        richestCustomerName = customerItem.getName();
                    }
                    paidAmountPrev = paidAmount;
                }
            }
            return richestCustomerName;
        }
    }
    public class Tariff
    {
        List<Customer> listCustomer = new List<Customer>();
        string name;
        int price;
        public Tariff(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public void registerCustomer(Customer customer)
        {
            listCustomer.Add(customer);
        }
        public List<Customer> getListCustomer()
        {
            return this.listCustomer;
        }
        public int getPrice()
        {
            return this.price;
        }
    }

    public class Customer {
        string name;
        int usedMBAmount;
        public Customer(string name, int usedMBAmount = 0)
        {
            this.name = name;
            this.usedMBAmount = usedMBAmount;
        }
        public int getUsedMBAmount()
        {
            return this.usedMBAmount;
        }
        public string getName()
        {
            return this.name;
        }

        public void setUsedMBAmount(int amount)
        {
            this.usedMBAmount = amount;
        }
        public void setConsumedTraffic(int amount)
        {
            this.usedMBAmount = amount;
        }
    }

}
