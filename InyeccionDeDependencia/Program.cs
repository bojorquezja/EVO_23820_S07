// Use EmailNotification
using InyeccionDeDependencia;

EmailNotification emailNotification = new EmailNotification();
var orderProcessor = new OrderProcessor(emailNotification);
orderProcessor.ProcessOrder();
