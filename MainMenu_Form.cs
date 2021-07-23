using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace XML_Integration
{
    public partial class MainMenu_Form : Form
    {
        string xmlURL = "https://www.tcmb.gov.tr/kurlar/today.xml";
        XmlDocument xmlDocument = new XmlDocument();

        // Dollar
        string dollarName;
        double dollarForexBuyPrice;
        double dollarForexSellPrice;
        double dollarBanknoteBuyPrice;
        double dollarBanknoteSellPrice;

        string dollarNameXml;
        string dollarForexBuyPriceXml;
        string dollarForexSellPriceXml;
        string dollarBanknoteBuyPriceXml;
        string dollarBanknoteSellPriceXml;

        // Euro
        string euroName;
        double euroForexBuyPrice;
        double euroForexSellPrice;
        double euroBanknoteBuyPrice;
        double euroBanknoteSellPrice;

        string euroNameXml;
        string euroForexBuyPriceXml;
        string euroForexSellPriceXml;
        string euroBanknoteBuyPriceXml;
        string euroBanknoteSellPriceXml;

        // Kuwait Dinar
        string dinarName;
        double dinarForexBuyPrice;
        double dinarForexSellPrice;
        double dinarBanknoteBuyPrice;
        double dinarBanknoteSellPrice;

        string dinarNameXml;
        string dinarForexBuyPriceXml;
        string dinarForexSellPriceXml;
        string dinarBanknoteBuyPriceXml;
        string dinarBanknoteSellPriceXml;

        // Customer Operation
        enum ButtonOperation {BuyUSD, SellUSD, BuyEUR, SellEUR, BuyKWD, SellKWD, Settings};
        ButtonOperation buttonOperation = new ButtonOperation();

        double customerMoneyTL;
        double customerMoneyUSD;
        double customerMoneyEUR;
        double customerMoneyKWD;

        double customerGetTL;
        double customerGetUSD;
        double customerGetEUR;
        double customerGetKWD;

        public MainMenu_Form()
        {
            InitializeComponent();
        }

        private void MainMenu_Form_Load(object sender, EventArgs e)
        {
            // Sets The Enum To BuyUSD
            buttonOperation = ButtonOperation.BuyUSD;

            // Loads The XML Document
            xmlDocument.Load(xmlURL);

            // Dollar
            dollarName = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/CurrencyName").InnerXml;
            dollarForexBuyPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/ForexBuying").InnerXml);
            dollarForexSellPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/ForexSelling").InnerXml);
            dollarBanknoteBuyPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/BanknoteBuying").InnerXml);
            dollarBanknoteSellPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/BanknoteSelling").InnerXml);

            dollarNameXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/CurrencyName").OuterXml;
            dollarForexBuyPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/ForexBuying").OuterXml;
            dollarForexSellPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/ForexSelling").OuterXml;
            dollarBanknoteBuyPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/BanknoteBuying").OuterXml;
            dollarBanknoteSellPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='USD']/BanknoteSelling").OuterXml;

            // Euro
            euroName = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/CurrencyName").InnerXml;
            euroForexBuyPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/ForexBuying").InnerXml);
            euroForexSellPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/ForexSelling").InnerXml);
            euroBanknoteBuyPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/BanknoteBuying").InnerXml);
            euroBanknoteSellPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/BanknoteSelling").InnerXml);

            euroNameXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/CurrencyName").OuterXml;
            euroForexBuyPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/ForexBuying").OuterXml;
            euroForexSellPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/ForexSelling").OuterXml;
            euroBanknoteBuyPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/BanknoteBuying").OuterXml;
            euroBanknoteSellPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='EUR']/BanknoteSelling").OuterXml;

            // Kuwait Dinar
            dinarName = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@CurrencyCode='KWD']/CurrencyName").InnerXml;
            dinarForexBuyPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='KWD']/ForexBuying").InnerXml);
            dinarForexSellPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='KWD']/ForexSelling").InnerXml);
            dinarBanknoteBuyPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='KWD']/BanknoteBuying").InnerXml);
            dinarBanknoteSellPrice = Convert.ToDouble(xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='KWD']/BanknoteSelling").InnerXml);

            dinarNameXml = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@CurrencyCode='KWD']/CurrencyName").OuterXml;
            dinarForexBuyPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='KWD']/ForexBuying").OuterXml;
            dinarForexSellPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='KWD']/ForexSelling").OuterXml;
            dinarBanknoteBuyPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='KWD']/BanknoteBuying").OuterXml;
            dinarBanknoteSellPriceXml = xmlDocument.SelectSingleNode(@"Tarih_Date/Currency[@CurrencyCode='KWD']/BanknoteSelling").OuterXml;

            // Sets The BuyUSD Operation For Loading
            CurrencyUpdater(dollarName, dollarForexBuyPrice, dollarForexSellPrice, dollarBanknoteBuyPrice, dollarBanknoteSellPrice);
            XMLFormattedMoneyStatistics_RichTextBox.Text = $"{dollarNameXml}\n{dollarForexBuyPriceXml}\n{dollarForexSellPriceXml}\n{dollarBanknoteBuyPriceXml}\n{dollarBanknoteSellPriceXml}";
            CurrencyValue_TextBox.Text = $"  Currency Value: {dollarBanknoteBuyPrice}₺";
            CustomerMoney_TextBox.Text = "   Customer Money (₺):";
        }

        private void BuyUSD_Button_Click(object sender, EventArgs e)
        {
            buttonOperation = ButtonOperation.BuyUSD;
            ButtonUIChange(BuyUSD_Button, SellUSD_Button, BuyEUR_Button, SellEUR_Button, BuyKWD_Button, SellKWD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);
            CurrencyUpdater(dollarName, dollarForexBuyPrice, dollarForexSellPrice, dollarBanknoteBuyPrice, dollarBanknoteSellPrice);
            XMLFormattedMoneyStatistics_RichTextBox.Text = $"{dollarNameXml}\n{dollarForexBuyPriceXml}\n{dollarForexSellPriceXml}\n{dollarBanknoteBuyPriceXml}\n{dollarBanknoteSellPriceXml}";
            CurrencyValue_TextBox.Text = $"  Currency Value: {dollarBanknoteBuyPrice}₺";
            CustomerMoney_TextBox.Text = "   Customer Money (₺):";
        }

        private void SellUSD_Button_Click(object sender, EventArgs e)
        {
            buttonOperation = ButtonOperation.SellUSD;
            ButtonUIChange(SellUSD_Button, BuyUSD_Button, BuyEUR_Button, SellEUR_Button, BuyKWD_Button, SellKWD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);
            CurrencyUpdater(dollarName, dollarForexBuyPrice, dollarForexSellPrice, dollarBanknoteBuyPrice, dollarBanknoteSellPrice);
            XMLFormattedMoneyStatistics_RichTextBox.Text = $"{dollarNameXml}\n{dollarForexBuyPriceXml}\n{dollarForexSellPriceXml}\n{dollarBanknoteBuyPriceXml}\n{dollarBanknoteSellPriceXml}";
            CurrencyValue_TextBox.Text = $"  Currency Value: {dollarBanknoteSellPrice}₺";
            CustomerMoney_TextBox.Text = "   Customer Money ($):";
        }

        private void BuyEUR_Button_Click(object sender, EventArgs e)
        {
            buttonOperation = ButtonOperation.BuyEUR;
            ButtonUIChange(BuyEUR_Button, SellUSD_Button, BuyUSD_Button, SellEUR_Button, BuyKWD_Button, SellKWD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);
            CurrencyUpdater(euroName, euroForexBuyPrice, euroForexSellPrice, euroBanknoteBuyPrice, euroBanknoteSellPrice);
            XMLFormattedMoneyStatistics_RichTextBox.Text = $"{euroNameXml}\n{euroForexBuyPriceXml}\n{euroForexSellPriceXml}\n{euroBanknoteBuyPriceXml}\n{euroBanknoteSellPriceXml}";
            CurrencyValue_TextBox.Text = $"  Currency Value: {euroBanknoteBuyPrice}₺";
            CustomerMoney_TextBox.Text = "   Customer Money (₺):";
        }

        private void SellEUR_Button_Click(object sender, EventArgs e)
        {
            buttonOperation = ButtonOperation.SellEUR;
            ButtonUIChange(SellEUR_Button, SellUSD_Button, BuyEUR_Button, BuyUSD_Button, BuyKWD_Button, SellKWD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);
            CurrencyUpdater(euroName, euroForexBuyPrice, euroForexSellPrice, euroBanknoteBuyPrice, euroBanknoteSellPrice);
            XMLFormattedMoneyStatistics_RichTextBox.Text = $"{euroNameXml}\n{euroForexBuyPriceXml}\n{euroForexSellPriceXml}\n{euroBanknoteBuyPriceXml}\n{euroBanknoteSellPriceXml}";
            CurrencyValue_TextBox.Text = $"  Currency Value: {euroBanknoteSellPrice}₺";
            CustomerMoney_TextBox.Text = "   Customer Money (€):";
        }

        private void BuyKWD_Button_Click(object sender, EventArgs e)
        {
            buttonOperation = ButtonOperation.BuyKWD;
            ButtonUIChange(BuyKWD_Button, SellUSD_Button, BuyEUR_Button, SellEUR_Button, BuyUSD_Button, SellKWD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);
            CurrencyUpdater(dinarName, dinarForexBuyPrice, dinarForexSellPrice, dinarBanknoteBuyPrice, dinarBanknoteSellPrice);
            XMLFormattedMoneyStatistics_RichTextBox.Text = $"{dinarNameXml}\n{dinarForexBuyPriceXml}\n{dinarForexSellPriceXml}\n{dinarBanknoteBuyPriceXml}\n{dinarBanknoteSellPriceXml}";
            CurrencyValue_TextBox.Text = $"  Currency Value: {dinarBanknoteBuyPrice}₺";
            CustomerMoney_TextBox.Text = "   Customer Money (₺):";
        }

        private void SellKWD_Button_Click(object sender, EventArgs e)
        {
            buttonOperation = ButtonOperation.SellKWD;
            ButtonUIChange(SellKWD_Button, SellUSD_Button, BuyEUR_Button, SellEUR_Button, BuyKWD_Button, BuyUSD_Button, Settings_Button, Navigation_Panel, MenuHeader_Label);
            CurrencyUpdater(dinarName, dinarForexBuyPrice, dinarForexSellPrice, dinarBanknoteBuyPrice, dinarBanknoteSellPrice);
            XMLFormattedMoneyStatistics_RichTextBox.Text = $"{dinarNameXml}\n{dinarForexBuyPriceXml}\n{dinarForexSellPriceXml}\n{dinarBanknoteBuyPriceXml}\n{dinarBanknoteSellPriceXml}";
            CurrencyValue_TextBox.Text = $"  Currency Value: {dinarBanknoteSellPrice}₺";
            CustomerMoney_TextBox.Text = "  Customer Money(د.ك):";
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            buttonOperation = ButtonOperation.Settings;
            ButtonUIChange(Settings_Button, SellUSD_Button, BuyEUR_Button, SellEUR_Button, BuyKWD_Button, SellKWD_Button, BuyUSD_Button, Navigation_Panel, MenuHeader_Label);
        }
        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void CurrencyUpdater(string pickedCurrencyName, double forexBuyingPrice, double forexSellingPrice, double banknoteBuyingPrice, double banknoteSellingPrice)
        {
            CurrencyName_Button.Text = $"Currency Name:   {pickedCurrencyName}";
            ForexBuying_Button.Text = $"Forex Buying:   {forexBuyingPrice}";
            ForexSelling_Button.Text = $"Forex Selling:   {forexSellingPrice}";
            BanknoteBuying_Button.Text = $"Banknote Buying:   {banknoteBuyingPrice}";
            BanknoteSelling_Button.Text = $"Banknote Selling:   {banknoteSellingPrice}";
        }
    }
}

// Programmer: Mert Gunduz
