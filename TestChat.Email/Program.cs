// отправитель - устанавливаем адрес и отображаемое в письме имя
using System.Net;
using System.Net.Mail;

MailAddress from = new MailAddress("myshalow@mail.ru", "testClient");
// кому отправляем
MailAddress to = new MailAddress("den_080202@mail.ru");
// создаем объект сообщения
MailMessage m = new MailMessage(from, to);
// тема письма
m.Subject = "Надо учиться";
// текст письма
m.Body = "<h2>Надо учиться</h2>";
// письмо представляет код html
m.IsBodyHtml = true;
// адрес smtp-сервера и порт, с которого будем отправлять письмо
SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
// логин и пароль
smtp.Credentials = new NetworkCredential("myshalow@mail.ru", "BygAnDxTtQdRJRN5x49p");
smtp.EnableSsl = true;

int count = 0;
while (count < 100)
{
    smtp.Send(m);
    Console.WriteLine("Письмо отправлено");
    Thread.Sleep(10000);
    count++;
}

Console.Read();