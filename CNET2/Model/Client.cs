using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public interface IGreetable {
        string SayHello();
    }
    public  class Client : IGreetable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SayHello()
        {
            return $"Hello {Name}";
        }
    }
    public class ClientVIP : IGreetable
    {
        public string Status { get; set; }
        public string Name { get; set; }

        public string SayHello()
        {
            return $"Hello VIP ( {Status} {Name})";
        }

    }
}
