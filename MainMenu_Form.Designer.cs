
namespace XML_Integration
{
    partial class MainMenu_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu_Form));
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.Mid_ExpandPanel = new System.Windows.Forms.Panel();
            this.Button_Panel = new System.Windows.Forms.Panel();
            this.Logo_Panel = new System.Windows.Forms.Panel();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Header_Label = new System.Windows.Forms.Label();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.SellKWD_Button = new System.Windows.Forms.Button();
            this.BuyKWD_Button = new System.Windows.Forms.Button();
            this.SellEUR_Button = new System.Windows.Forms.Button();
            this.BuyEUR_Button = new System.Windows.Forms.Button();
            this.SellUSD_Button = new System.Windows.Forms.Button();
            this.BuyUSD_Button = new System.Windows.Forms.Button();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.Top_ExpandPanel = new System.Windows.Forms.Panel();
            this.Mid_Panel.SuspendLayout();
            this.Mid_ExpandPanel.SuspendLayout();
            this.Button_Panel.SuspendLayout();
            this.Logo_Panel.SuspendLayout();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.Top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.Mid_Panel.Controls.Add(this.Mid_ExpandPanel);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(826, 480);
            this.Mid_Panel.TabIndex = 0;
            // 
            // Mid_ExpandPanel
            // 
            this.Mid_ExpandPanel.Controls.Add(this.Top_Panel);
            this.Mid_ExpandPanel.Controls.Add(this.Button_Panel);
            this.Mid_ExpandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_ExpandPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(120)))), ((int)(((byte)(228)))));
            this.Mid_ExpandPanel.Location = new System.Drawing.Point(0, 0);
            this.Mid_ExpandPanel.Name = "Mid_ExpandPanel";
            this.Mid_ExpandPanel.Size = new System.Drawing.Size(826, 480);
            this.Mid_ExpandPanel.TabIndex = 0;
            // 
            // Button_Panel
            // 
            this.Button_Panel.Controls.Add(this.Settings_Button);
            this.Button_Panel.Controls.Add(this.SellKWD_Button);
            this.Button_Panel.Controls.Add(this.BuyKWD_Button);
            this.Button_Panel.Controls.Add(this.SellEUR_Button);
            this.Button_Panel.Controls.Add(this.BuyEUR_Button);
            this.Button_Panel.Controls.Add(this.SellUSD_Button);
            this.Button_Panel.Controls.Add(this.BuyUSD_Button);
            this.Button_Panel.Controls.Add(this.Header_Panel);
            this.Button_Panel.Controls.Add(this.Logo_Panel);
            this.Button_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Panel.Location = new System.Drawing.Point(0, 0);
            this.Button_Panel.Name = "Button_Panel";
            this.Button_Panel.Size = new System.Drawing.Size(150, 480);
            this.Button_Panel.TabIndex = 1;
            // 
            // Logo_Panel
            // 
            this.Logo_Panel.Controls.Add(this.Logo_PictureBox);
            this.Logo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_Panel.Location = new System.Drawing.Point(0, 0);
            this.Logo_Panel.Name = "Logo_Panel";
            this.Logo_Panel.Size = new System.Drawing.Size(150, 125);
            this.Logo_Panel.TabIndex = 0;
            // 
            // Header_Panel
            // 
            this.Header_Panel.Controls.Add(this.Header_Label);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 125);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(150, 30);
            this.Header_Panel.TabIndex = 1;
            // 
            // Header_Label
            // 
            this.Header_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Header_Label.Location = new System.Drawing.Point(0, 0);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(150, 30);
            this.Header_Label.TabIndex = 0;
            this.Header_Label.Text = "CurrencyX";
            this.Header_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings_Button
            // 
            this.Settings_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings_Button.FlatAppearance.BorderSize = 0;
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Settings_Button.Image = global::XML_Integration.Properties.Resources.CurrencyX_SettingsIcon;
            this.Settings_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings_Button.Location = new System.Drawing.Point(0, 440);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Settings_Button.Size = new System.Drawing.Size(150, 40);
            this.Settings_Button.TabIndex = 8;
            this.Settings_Button.Text = "Settings";
            this.Settings_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_Button.UseVisualStyleBackColor = true;
            // 
            // SellKWD_Button
            // 
            this.SellKWD_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.SellKWD_Button.FlatAppearance.BorderSize = 0;
            this.SellKWD_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellKWD_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SellKWD_Button.Image = ((System.Drawing.Image)(resources.GetObject("SellKWD_Button.Image")));
            this.SellKWD_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SellKWD_Button.Location = new System.Drawing.Point(0, 355);
            this.SellKWD_Button.Name = "SellKWD_Button";
            this.SellKWD_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.SellKWD_Button.Size = new System.Drawing.Size(150, 40);
            this.SellKWD_Button.TabIndex = 7;
            this.SellKWD_Button.Text = "Sell KWD";
            this.SellKWD_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SellKWD_Button.UseVisualStyleBackColor = true;
            // 
            // BuyKWD_Button
            // 
            this.BuyKWD_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuyKWD_Button.FlatAppearance.BorderSize = 0;
            this.BuyKWD_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyKWD_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BuyKWD_Button.Image = ((System.Drawing.Image)(resources.GetObject("BuyKWD_Button.Image")));
            this.BuyKWD_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuyKWD_Button.Location = new System.Drawing.Point(0, 315);
            this.BuyKWD_Button.Name = "BuyKWD_Button";
            this.BuyKWD_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BuyKWD_Button.Size = new System.Drawing.Size(150, 40);
            this.BuyKWD_Button.TabIndex = 6;
            this.BuyKWD_Button.Text = "Buy KWD";
            this.BuyKWD_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyKWD_Button.UseVisualStyleBackColor = true;
            // 
            // SellEUR_Button
            // 
            this.SellEUR_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.SellEUR_Button.FlatAppearance.BorderSize = 0;
            this.SellEUR_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellEUR_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SellEUR_Button.Image = ((System.Drawing.Image)(resources.GetObject("SellEUR_Button.Image")));
            this.SellEUR_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SellEUR_Button.Location = new System.Drawing.Point(0, 275);
            this.SellEUR_Button.Name = "SellEUR_Button";
            this.SellEUR_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.SellEUR_Button.Size = new System.Drawing.Size(150, 40);
            this.SellEUR_Button.TabIndex = 5;
            this.SellEUR_Button.Text = "Sell EUR";
            this.SellEUR_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SellEUR_Button.UseVisualStyleBackColor = true;
            // 
            // BuyEUR_Button
            // 
            this.BuyEUR_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuyEUR_Button.FlatAppearance.BorderSize = 0;
            this.BuyEUR_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyEUR_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BuyEUR_Button.Image = ((System.Drawing.Image)(resources.GetObject("BuyEUR_Button.Image")));
            this.BuyEUR_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuyEUR_Button.Location = new System.Drawing.Point(0, 235);
            this.BuyEUR_Button.Name = "BuyEUR_Button";
            this.BuyEUR_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BuyEUR_Button.Size = new System.Drawing.Size(150, 40);
            this.BuyEUR_Button.TabIndex = 4;
            this.BuyEUR_Button.Text = "Buy EUR";
            this.BuyEUR_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyEUR_Button.UseVisualStyleBackColor = true;
            // 
            // SellUSD_Button
            // 
            this.SellUSD_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.SellUSD_Button.FlatAppearance.BorderSize = 0;
            this.SellUSD_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellUSD_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SellUSD_Button.Image = ((System.Drawing.Image)(resources.GetObject("SellUSD_Button.Image")));
            this.SellUSD_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SellUSD_Button.Location = new System.Drawing.Point(0, 195);
            this.SellUSD_Button.Name = "SellUSD_Button";
            this.SellUSD_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.SellUSD_Button.Size = new System.Drawing.Size(150, 40);
            this.SellUSD_Button.TabIndex = 3;
            this.SellUSD_Button.Text = "Sell USD";
            this.SellUSD_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SellUSD_Button.UseVisualStyleBackColor = true;
            // 
            // BuyUSD_Button
            // 
            this.BuyUSD_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuyUSD_Button.FlatAppearance.BorderSize = 0;
            this.BuyUSD_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyUSD_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BuyUSD_Button.Image = ((System.Drawing.Image)(resources.GetObject("BuyUSD_Button.Image")));
            this.BuyUSD_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuyUSD_Button.Location = new System.Drawing.Point(0, 155);
            this.BuyUSD_Button.Name = "BuyUSD_Button";
            this.BuyUSD_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BuyUSD_Button.Size = new System.Drawing.Size(150, 40);
            this.BuyUSD_Button.TabIndex = 2;
            this.BuyUSD_Button.Text = "Buy USD";
            this.BuyUSD_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyUSD_Button.UseVisualStyleBackColor = true;
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo_PictureBox.Image = global::XML_Integration.Properties.Resources.CurrencyX_ExchanceIcon;
            this.Logo_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(150, 125);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            // 
            // Top_Panel
            // 
            this.Top_Panel.Controls.Add(this.Top_ExpandPanel);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(150, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(676, 30);
            this.Top_Panel.TabIndex = 2;
            // 
            // Top_ExpandPanel
            // 
            this.Top_ExpandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top_ExpandPanel.Location = new System.Drawing.Point(0, 0);
            this.Top_ExpandPanel.Name = "Top_ExpandPanel";
            this.Top_ExpandPanel.Size = new System.Drawing.Size(676, 30);
            this.Top_ExpandPanel.TabIndex = 3;
            // 
            // MainMenu_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(826, 480);
            this.Controls.Add(this.Mid_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrencyX";
            this.Load += new System.EventHandler(this.MainMenu_Form_Load);
            this.Mid_Panel.ResumeLayout(false);
            this.Mid_ExpandPanel.ResumeLayout(false);
            this.Button_Panel.ResumeLayout(false);
            this.Logo_Panel.ResumeLayout(false);
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.Top_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.Panel Mid_ExpandPanel;
        private System.Windows.Forms.Panel Button_Panel;
        private System.Windows.Forms.Panel Logo_Panel;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Label Header_Label;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Button SellKWD_Button;
        private System.Windows.Forms.Button BuyKWD_Button;
        private System.Windows.Forms.Button SellEUR_Button;
        private System.Windows.Forms.Button BuyEUR_Button;
        private System.Windows.Forms.Button SellUSD_Button;
        private System.Windows.Forms.Button BuyUSD_Button;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Panel Top_ExpandPanel;
    }
}

