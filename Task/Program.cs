using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExample
{
    class Program
    {
        public static void Main()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
            });

            t.Wait();
            Console.ReadLine();
        }
    }
}
  //              var emailResquest = new Acesso.BusinessObjects.Mail.Modelo.MailRequest();
  //              emailResquest.Formato = BusinessObjects.Mail.Enums.MailFormato.Html;
  //              emailResquest.SenderAddress = request.Data.email;
  //              emailResquest.Subject = assuntoMensagem;
  //              emailResquest.MailBody = conteudoMensagem.ToString();
  //              emailResquest.ToAdress = ConfigurationManager.AppSettings["FaleConoscoDestinatario"];

  //              var emailResult = MailWs.Enviar(emailResquest); 
                
  //              if(emailResult.Status == BusinessObjects.Mail.Enums.MailStatus.Erro)
  //                  throw new ServiceException(1, emailResult.Mensagem);



  //          var mailRequest = new MailRequest
  //          {
  //              Formato = BusinessObjects.Mail.Enums.MailFormato.Html,
  //              ReplyAddress = "naoresponda@acessocard.com.br",
  //              SenderAddress = "naoresponda@acessocard.com.br",
  //              Subject = usuario.PrimeiroNome + " lhe convidou para adquirir o cartão Acesso pré-pago",
  //              NameSender = usuario.NomeCompleto
  //          };
  //          mailRequest.MailBody = _CriarMensagemIndicacaoEmail(message, usuario);
  //          foreach (var item in emails)
  //          {
  //              mailRequest.ToAdress = item;
  //              var mailres = MailWs.Enviar(mailRequest);
  //              if (mailres.Status != BusinessObjects.Mail.Enums.MailStatus.Sucesso)
  //                  LogUtils.Add("GestaoMGM.EnviarEmailIndicacao", mailres.Mensagem);
  //          }


  //                          var mailRequest = new MailRequest
  //                          {
  //                              ReplyAddress = item.ReplyAddress,
  //                              NameSender = item.NameSender,
  //                              SenderAddress = item.SenderAddress,
  //                              ToAdress = item.Email,
  //                              Subject = item.Subject,
  //                              MailBody = GetHtmlEmail(item.Url).
  //                                  Replace("##NOME##", item.Nome).
  //                                  Replace("##EMAIL##", item.Email).
  //                                  Replace("##LINKBOLETO##", item.LinkBoleto).
  //                                  Replace("##DATAVENCTO##", item.DataVencto.ToShortDateString()).
  //                                  Replace("##LINK2VIABOLETO##", item.Link2viaBoleto).
  //                                  Replace("##DD/MM/AAAA", item.DtCriacao.ToShortDateString()).
  //                                  Replace("##HH:MM", item.DtCriacao.ToShortTimeString())
  //                          };

  //                          var mailResult = mail.Enviar(mailRequest);
  //                          if (mailResult.Status == MailStatus.Erro)
  //                          {
  //                              Trace.TraceError("Erro ao processar eventos primários! {0}", mailResult.Mensagem);
  //                              LogUtils.Add("Regua.ProcessamentoPrimario", mailResult.Mensagem);
  //                          }


  //private static string GetHtmlEmail(string path)
  //      {
  //          string html;

  //          using (var reader = new StreamReader(path, Encoding.UTF8))
  //          {
  //              html = reader.ReadToEnd();
  //          }

  //          return html;
  //      }