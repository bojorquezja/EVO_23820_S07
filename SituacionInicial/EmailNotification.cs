using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SituacionInicial{
    public class EmailNotification    {
        public void Send(string message)        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
