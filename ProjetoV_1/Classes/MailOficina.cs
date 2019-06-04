using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoV_1

{
    public class MailOficina
    {
        public bool enviou = false;
        public String body = null;
        public MailOficina(String mailTo, Parcela parcelaPareEnviar, Servico servicoParaEnviar)
        {
            body = "\r\nParcelas Incluídas: ";
            foreach (Parcela item in servicoParaEnviar.Parcelas)
            {
                body += "\r\n\tDescrição: "+ item.Descricao + 
                        "\r\n\tValor a Pagar: " + item.Valor + " €";
            }
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
                mail.Subject = "Fatura Oficina : Serviço " + servicoParaEnviar.CarroOficina.Marca + " " + servicoParaEnviar.CarroOficina.Modelo;
                mail.Body = "\r\n\r\nCarro: " + servicoParaEnviar.CarroOficina.Marca + " " + servicoParaEnviar.CarroOficina.Modelo
                + "\r\nInicio do Serviço: " + servicoParaEnviar.DataEntrada.ToLongDateString() + " " + servicoParaEnviar.DataEntrada.ToLongTimeString()
                + "\r\nFim do Serviço:" + servicoParaEnviar.DataSaida.ToLongDateString() + " " + servicoParaEnviar.DataSaida.ToLongTimeString()
                + "\r\nTipo de Serviço:" + servicoParaEnviar.Tipo
                + body
                + "\r\nTotal do Serviço:" + servicoParaEnviar.TotalServico.ToString() + " €";
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
