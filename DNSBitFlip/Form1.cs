using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DNSBitFlip.extensions;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace DNSBitFlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFlipNoValidate_Click(object sender, EventArgs e)
        {
            tsLblMessage.Text = "Calculating flips...";
            var flipped = PerformFlip(txtDomainName.Text.ToBinary());
            StringBuilder builder = new StringBuilder();
            foreach (string s in flipped)
            {
                builder.AppendLine(s);
            }

            txtOutput.Text = builder.ToString();
            tsLblMessage.Text = "Done";
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            tsLblMessage.Text = "Calculating flips...";
            var flipped = PerformFlip(txtDomainName.Text.ToBinary());
            var validated = ValidateURL(flipped);
            StringBuilder builder = new StringBuilder();
            foreach (var s in validated)
            {
                if (s.Value != DomainStatus.FAILURE)
                {
                    builder.AppendFormat("{0, -10} : {1}{2}",s.Key, s.Value.ToString(), Environment.NewLine);
                    //builder.AppendLine(s.Key + " :      " + s.Value.ToString());
                }  
                
            }
            txtOutput.Text = builder.ToString();
            tsLblMessage.Text = "Done";

        }

        private List<string> PerformFlip(string BinaryDomain)
        {
            List<string> retList = new List<string>();

            for (int i = 0; i < BinaryDomain.Length; i++)
            {
                char[] newString = new char[BinaryDomain.Length];
                newString = BinaryDomain.ToCharArray();
                if (newString[i] == '1')
                {
                    newString[i] = '0';
                }
                else
                {
                    newString[i] = '1';
                }
                retList.Add(new string(newString).BinaryToString());
            }

            return retList;
        }

        private Dictionary<string, DomainStatus> ValidateURL(List<string> URLs)
        {
            Dictionary<string, DomainStatus> returnVals = new Dictionary<string, DomainStatus>();

            foreach (string s in URLs)
            {
                try
                {
                   string regex = "^[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,6}$";
                   if(Regex.IsMatch(s, regex))
                   {
                       returnVals.Add(s, CheckDomainAvailable(s));
                   }
                }
                catch
                {
                    tsLblMessage.Text = "Error: Unable to match regex.";
                }
                
            }
            return returnVals;
        }

        private DomainStatus CheckDomainAvailable(string domain)
        {
            tsLblMessage.Text = "Querying Domains...";
            StringBuilder builder = new StringBuilder();
            //build the request
            builder.Append("https://testapi.internet.bs/Domain/Check?Domain=");
            builder.Append(domain);
            builder.Append("&ApiKey=testapi&Password=testpass");
            string html = string.Empty;
            try
            {
                WebRequest request = WebRequest.Create(builder.ToString());
                var response = request.GetResponse();
                var data = response.GetResponseStream();
                using (StreamReader sr = new StreamReader(data))
                {
                    html = sr.ReadToEnd();        
                }
            }
            catch
            {
                tsLblMessage.Text = "Error: Web request failed.";
            }

            if (html.Contains("=" + DomainStatus.AVAILABLE.ToString()))
            {
                return DomainStatus.AVAILABLE;
            }
            else if (html.Contains(DomainStatus.UNAVAILABLE.ToString()))
            {
                return DomainStatus.UNAVAILABLE;
            }
            else
            {
                return DomainStatus.FAILURE;
            }
        }

        private enum DomainStatus
        {
            AVAILABLE,
            FAILURE,
            UNAVAILABLE
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
