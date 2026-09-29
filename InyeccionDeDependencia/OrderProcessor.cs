using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencia {
    public class OrderProcessor {
        private readonly EmailNotification _notification;

        public OrderProcessor(EmailNotification notification) {
            _notification = notification;
        }

        public void ProcessOrder() {
            // Order processing logic
            Console.WriteLine("Order processed.");

            // Send notification
            _notification.Send("Your order has been processed.");
        }
    }
}
