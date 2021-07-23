using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_Integration
{
    public partial class MainMenu_Form : Form
    {
        string xmlURL = "https://www.tcmb.gov.tr/kurlar/today.xml";
        XmlDocument xmlDocument = new XmlDocument();

        // Dollar
        double dollarBuyPrice;
        double dollarSellPrice;

        // Euro
        double euroBuyPrice;
        double euroSellPrice;

        // Kuwait Dinar
        double dinarBuyPrice;
        double dinarSellPrice;

        public MainMenu_Form()
        {
            InitializeComponent();
        }

        private void MainMenu_Form_Load(object sender, EventArgs e)
        {
            xmlDocument.Load(xmlURL);

            dollarBuyPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/BanknoteBuying").InnerXml);
            dollarSellPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/BanknoteSelling").InnerXml);
            euroBuyPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/BanknoteBuying").InnerXml);
            euroSellPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/BanknoteSelling").InnerXml);
            dinarBuyPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='KWD']/BanknoteBuying").InnerXml);
            dinarSellPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='KWD']/BanknoteSelling").InnerXml);
        }
    }
}
