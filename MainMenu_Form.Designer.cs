
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
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.Mid_ExpandPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_Panel = new System.Windows.Forms.Panel();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.Top_ExpandPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Mid_Panel.SuspendLayout();
            this.Mid_ExpandPanel.SuspendLayout();
            this.Button_Panel.SuspendLayout();
            this.Top_Panel.SuspendLayout();
            this.Top_ExpandPanel.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.Mid_ExpandPanel.Location = new System.Drawing.Point(0, 0);
            this.Mid_ExpandPanel.Name = "Mid_ExpandPanel";
            this.Mid_ExpandPanel.Size = new System.Drawing.Size(826, 480);
            this.Mid_ExpandPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Button_Panel
            // 
            this.Button_Panel.Controls.Add(this.button1);
            this.Button_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Panel.Location = new System.Drawing.Point(0, 0);
            this.Button_Panel.Name = "Button_Panel";
            this.Button_Panel.Size = new System.Drawing.Size(150, 480);
            this.Button_Panel.TabIndex = 1;
            // 
            // Top_Panel
            // 
            this.Top_Panel.Controls.Add(this.Top_ExpandPanel);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(150, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(676, 100);
            this.Top_Panel.TabIndex = 2;
            // 
            // Top_ExpandPanel
            // 
            this.Top_ExpandPanel.Controls.Add(this.panel2);
            this.Top_ExpandPanel.Controls.Add(this.panel1);
            this.Top_ExpandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top_ExpandPanel.Location = new System.Drawing.Point(0, 0);
            this.Top_ExpandPanel.Name = "Top_ExpandPanel";
            this.Top_ExpandPanel.Size = new System.Drawing.Size(676, 100);
            this.Top_ExpandPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(120)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(70, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 3);
            this.panel3.TabIndex = 0;
            // 
            // MainMenu_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(826, 480);
            this.Controls.Add(this.Mid_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrencyX";
            this.Load += new System.EventHandler(this.MainMenu_Form_Load);
            this.Mid_Panel.ResumeLayout(false);
            this.Mid_ExpandPanel.ResumeLayout(false);
            this.Button_Panel.ResumeLayout(false);
            this.Top_Panel.ResumeLayout(false);
            this.Top_ExpandPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.Panel Mid_ExpandPanel;
        private System.Windows.Forms.Panel Button_Panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Panel Top_ExpandPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}

