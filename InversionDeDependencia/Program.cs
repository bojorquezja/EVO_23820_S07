// Use EmailNotification
using InversionDeDependencia;

INotification emailNotification = new EmailNotification();
var orderProcessor = new OrderProcessor(emailNotification);
orderProcessor.ProcessOrder();

INotification smsNotification = new SmsNotification();
var orderProcessor2 = new OrderProcessor(smsNotification);
orderProcessor2.ProcessOrder();
