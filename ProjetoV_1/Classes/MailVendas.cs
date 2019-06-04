using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoV_1
{
    public class MailVendas
    {
        public bool enviou = false;
        public MailVendas(String mailTo, Venda VendaParaEnviar)
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
                mail.Subject = "Fatura Venda : Venda  " + VendaParaEnviar.CarroVenda.Marca + " " + VendaParaEnviar.CarroVenda.Modelo;
                mail.Body = "\r\n\r\nCarro: " + VendaParaEnviar.CarroVenda.Marca + " " + VendaParaEnviar.CarroVenda.Modelo + " " + VendaParaEnviar.CarroVenda.Combustível + " ( " + VendaParaEnviar.Estado + " ) " + " Com " + VendaParaEnviar.CarroVenda.NumeroChassis + " chassis "
                + "\r\nData da Venda: " + VendaParaEnviar.Data.ToLongDateString() + " " + VendaParaEnviar.Data.ToLongDateString()
                + "\r\nValor a Pagar:" + VendaParaEnviar.Valor + " €";
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
