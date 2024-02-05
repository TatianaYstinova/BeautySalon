using BeautySalon.DAL.IRepositories;
using BeautySalon.DAL.Repositories;

namespace BeautySalon.Console;

using System;

class Program
{
    static void Main(string[] args)
    { 
        IOrderRepository orderRepository = new OrderRepository();
        var orders = orderRepository.GetOrdersByMasterId(2);
        foreach (var order in orders)
        {
            Console.WriteLine();
        }

        

        IOrderRepository repository = new OrderRepository();
        repository.UpdateOrderTimeForClientById(1,1,1,1);
        Console.WriteLine();
    }
}