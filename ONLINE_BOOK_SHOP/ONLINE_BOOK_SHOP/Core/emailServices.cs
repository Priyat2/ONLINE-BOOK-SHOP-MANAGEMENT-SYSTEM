using System;
using System.IO;
using Microsoft.VisualBasic;
using System.Net.Mail;

namespace Core
{
    class emailServices
    {
        public struct Message
        {
            public string _Body;
            public string Body
            {
                get
                {
                    return Interaction.IIf(Information.IsNothing(_Body), string.Empty, _Body);
                }
                set
                {
                    _Body = Value;
                }
            }

            public string _From;
            public string From
            {
                get
                {
                    return Interaction.IIf(Information.IsNothing(_From), string.Empty, _From);
                }
                set
                {
                    _From = Value;
                }
            }

            public string _Subject;
            public string Subject
            {
                get
                {
                    return Interaction.IIf(Information.IsNothing(_Subject), string.Empty, _Subject);
                }
                set
                {
                    _Subject = Value;
                }
            }

            public string _To;
            public string To
            {
                get
                {
                    return Interaction.IIf(Information.IsNothing(_To), string.Empty, _To);
                }
                set
                {
                    _To = Value;
                }
            }

            public bool HTML;


            // Public Function ToMessage(Optional ByVal tags As System.Collections.Specialized.NameValueCollection = Nothing) As System.Web.Mail.MailMessage
            // Dim m As New System.Web.Mail.MailMessage
            // m.To = Me.To
            // m.From = Me.From


            // Dim sb As New StringBuilder(Me.Body)
            // If Not IsNothing(tags) Then
            // For Each k As String In tags.Keys
            // sb.Replace(k, tags(k))
            // Next
            // End If

            // m.Body = sb.ToString()

            // sb = New StringBuilder(Me.Subject)
            // If Not IsNothing(tags) Then
            // For Each k As String In tags.Keys
            // sb.Replace(k, tags(k))
            // Next
            // End If

            // m.Subject = sb.ToString()
            // m.BodyFormat = IIf(Me.HTML, MailFormat.Html, MailFormat.Text)

            // If Not Me.HTML Then
            // m.Body = Regex.Replace(m.Body.Replace("<br>", vbCrLf), "<[^>]*>", "", RegexOptions.Multiline)
            // End If

            // Return m
            // End Function

            public string ToXml()         // ByVal s As InventoryConfig) As String
            {
                System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(Message));
                System.IO.StringWriter s1 = new System.IO.StringWriter();
                xs.Serialize(s1, this);

                return s1.ToString();
            }

            public static Message FromXml(string s)
            {
                Message ic = new Message();
                if (s != string.Empty)
                {
                    try
                    {
                        System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(Message));
                        System.IO.StringReader s1 = new System.IO.StringReader(s);
                        ic = xs.Deserialize(s1);
                    }
                    catch (Exception ex)
                    {
                    }
                }

                return ic;
            }
        }

        // Public Class emailServices
        // Public Shared Function GetEmailsTemplates(ByVal id As Integer) As DataTable
        // Dim data As New DataLayer.DataFunctions(WebAppSettings.ConnectionString)
        // Dim res As DataTable = data.SelectByParamDT("udsp_getEmail_Msgs_templates", New SqlClient.SqlParameter("@id", id))
        // data = Nothing
        // Return res
        // End Function

        public static bool SendMail(string emailtemplename, string clientEmail, string EmailSub, string leadid, string name, string plan, string amount, string url, string remark, int email_type_id)
        {
            string trid = "";
            StreamReader sr;
            string emailbody;
            string webtemple = ConfigurationManager.AppSettings("MailTempletepath").ToString();
            string mailserver = ConfigurationManager.AppSettings("mailserver").ToString();
            string MailServerUsername = ConfigurationManager.AppSettings("MailServerUsername").ToString();
            string MailServerPassword = ConfigurationManager.AppSettings("MailServerPassword").ToString();


            sr = File.OpenText(webtemple + @"\" + emailtemplename);
            emailbody = "";
            emailbody = sr.ReadToEnd();

            // trid = Lead.insertEmailTransaction(email_type_id, MailServerUsername, clientEmail, EmailSub, emailbody, leadid, UserManagement.getCurrentUserId())

            emailbody = emailbody.Replace("%name%", name);
            emailbody = emailbody.Replace("%plan%", plan);
            emailbody = emailbody.Replace("%amount%", amount);
            emailbody = emailbody.Replace("%url%", url);
            emailbody = emailbody.Replace("%Emailmsg%", remark);
            emailbody = emailbody.Replace("%trId%", trid);
            emailbody = emailbody.Replace("#WEB#", "<a href=\"http://www.health-total.com\">www.health-total.com</a>");


            int retVal = 0;
            MailMessage mailMsg = new MailMessage();

            mailMsg.From = new MailAddress(MailServerUsername, "Health Total");
            mailMsg.To.Add(clientEmail);
            mailMsg.Subject = EmailSub;
            mailMsg.Body = emailbody;
            mailMsg.IsBodyHtml = true;
            // mailMsg.From.DisplayName = "Health Total"

            SmtpClient mySmtpClient = new SmtpClient();


            System.Net.NetworkCredential myCredential = new System.Net.NetworkCredential(MailServerUsername, MailServerPassword);
            mySmtpClient.Host = mailserver;
            mySmtpClient.UseDefaultCredentials = false;
            mySmtpClient.Credentials = myCredential;
            mySmtpClient.ServicePoint.MaxIdleTime = 1;

            mySmtpClient.Send(mailMsg);

            mailMsg.Dispose();

            return 1;
        }
    }

}
