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

        private void BuyUSD_Button_Click(object sender, EventArgs e)
        {
            ButtonUIChange(BuyUSD_Button, SellUSD_Button, BuyEUR_Button, SellEUR_Button, BuyKWD_Button, SellKWD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);
        }

        private void SellUSD_Button_Click(object sender, EventArgs e)
        {
            ButtonUIChange(SellUSD_Button, BuyUSD_Button, BuyEUR_Button, SellEUR_Button, BuyKWD_Button, SellKWD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);

        }

        private void BuyEUR_Button_Click(object sender, EventArgs e)
        {
            ButtonUIChange(BuyEUR_Button, SellUSD_Button, BuyUSD_Button, SellEUR_Button, BuyKWD_Button, SellKWD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);

        }

        private void SellEUR_Button_Click(object sender, EventArgs e)
        {
            ButtonUIChange(SellEUR_Button, SellUSD_Button, BuyEUR_Button, BuyUSD_Button, BuyKWD_Button, SellKWD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);

        }

        private void BuyKWD_Button_Click(object sender, EventArgs e)
        {
            ButtonUIChange(BuyKWD_Button, SellUSD_Button, BuyEUR_Button, SellEUR_Button, BuyUSD_Button, SellKWD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);
        }

        private void SellKWD_Button_Click(object sender, EventArgs e)
        {
            ButtonUIChange(SellKWD_Button, SellUSD_Button, BuyEUR_Button, SellEUR_Button, BuyKWD_Button, BuyUSD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);

        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            ButtonUIChange(Settings_Button, SellUSD_Button, BuyEUR_Button, SellEUR_Button, BuyKWD_Button, SellKWD_Button, BuyUSD_Button, Navigation_Panel, MenuHeader_Label);
        }

        private void ButtonUIChange(Button clickedButton, Button secondButton, Button thirdButton, Button fourthButton, Button fifthButton, Button sixthButton, Button seventhButton, Panel navigatingPanel, Label menuHeaderLabel)
        {
            // Clicked Button
            clickedButton.BackColor = Color.FromArgb(40, 49, 64);
            clickedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 49, 64);
            clickedButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 49, 64);
            navigatingPanel.Top = clickedButton.Top;
            navigatingPanel.Height = clickedButton.Height;
            menuHeaderLabel.Text = clickedButton.Text;

            // Other Buttons
            secondButton.BackColor = Color.FromArgb(19, 30, 45);
            secondButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 30, 45);
            secondButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 30, 45);

            thirdButton.BackColor = Color.FromArgb(19, 30, 45);
            thirdButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 30, 45);
            thirdButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 30, 45);

            fourthButton.BackColor = Color.FromArgb(19, 30, 45);
            fourthButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 30, 45);
            fourthButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 30, 45);

            fifthButton.BackColor = Color.FromArgb(19, 30, 45);
            fifthButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 30, 45);
            fifthButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 30, 45);

            sixthButton.BackColor = Color.FromArgb(19, 30, 45);
            sixthButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 30, 45);
            sixthButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 30, 45);

            seventhButton.BackColor = Color.FromArgb(19, 30, 45);
            seventhButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 30, 45);
            seventhButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 30, 45);
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
