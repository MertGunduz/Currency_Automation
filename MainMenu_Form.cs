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

        string dollarAlisFiyati;
        string DollarVerisFiyati;

        public MainMenu_Form()
        {
            InitializeComponent();
        }

        private void MainMenu_Form_Load(object sender, EventArgs e)
        {
            xmlDocument.Load(xmlURL);

            dollarAlisFiyati = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/BanknoteBuying").InnerXml;
        }
    }
}
