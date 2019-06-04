using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace ProjetoV_1
{
    public class MailerAluguer
    {
        public bool enviou = false;
        public MailerAluguer(String mailTo, Aluguer aluguerParaEnviarFatura)
        {
            try
            {
                MailMessage mail = new MailMessage("csharpricardoolex@gmail.com", mailTo);
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("csharpRicardoOlex", "ricardoolexcsharp");
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                mail.Subject = "Fatura : Aluguer " + aluguerParaEnviarFatura.CarroAluguer.Marca + " " + aluguerParaEnviarFatura.CarroAluguer.Modelo;
                mail.Body = "\r\n\r\nCarro: " + aluguerParaEnviarFatura.CarroAluguer.Marca + " " + aluguerParaEnviarFatura.CarroAluguer.Modelo + "\r\n\t" +aluguerParaEnviarFatura.CarroAluguer.Combustível + "\r\n\t" + aluguerParaEnviarFatura.CarroAluguer.Estado
                + "\r\nInicio do Aluguer: " + aluguerParaEnviarFatura.DataInicio.ToLongDateString() + " " + aluguerParaEnviarFatura.DataInicio.ToLongTimeString()
                + "\r\nFim do Aluguer:" + aluguerParaEnviarFatura.DataFim.ToLongDateString() + " " + aluguerParaEnviarFatura.DataFim.ToLongTimeString()
                + "\r\nValor a Pagar:" + aluguerParaEnviarFatura.Valor + " €";
                client.Send(mail);
                enviou = true;
            }
            catch
            {
                enviou = false;
            }
        }
    }
}
