using Hackathon.Models;
using Hackathon.Repositories;
using System;

namespace Hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
         var a = new TimeRepository();

            foreach(var item in a.GetData())
            {
                Console.WriteLine(item.RegisterationNumber + "  " + item.StartingDate + "  "+ item.EndDate + "  "+ item.TotalTime + "  "+ item.Status + "  "+ item.Reason);
                Console.WriteLine();
            }
        
        }
    }
}
