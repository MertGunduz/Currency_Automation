
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
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Header_Label = new System.Windows.Forms.Label();
            this.Mid_Panel.SuspendLayout();
            this.Mid_ExpandPanel.SuspendLayout();
            this.Button_Panel.SuspendLayout();
            this.Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.Header_Panel.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.Header_Panel.ResumeLayout(false);
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
    }
}

