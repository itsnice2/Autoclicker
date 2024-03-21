namespace Autoclicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnExit = new Button();
            txtKPS = new TextBox();
            txtXAchse = new TextBox();
            txtYAchse = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnStart = new Button();
            txtKoordinaten = new TextBox();
            label3 = new Label();
            boxKlickTest = new GroupBox();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            chkbox_once = new CheckBox();
            timer2 = new System.Windows.Forms.Timer(components);
            toolTip_onlyonce = new ToolTip(components);
            label_help = new Label();
            boxKlickTest.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(105, 213);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "&Beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtKPS
            // 
            txtKPS.Location = new Point(9, 27);
            txtKPS.Name = "txtKPS";
            txtKPS.Size = new Size(110, 23);
            txtKPS.TabIndex = 1;
            txtKPS.TextAlign = HorizontalAlignment.Center;
            // 
            // txtXAchse
            // 
            txtXAchse.Location = new Point(9, 76);
            txtXAchse.Name = "txtXAchse";
            txtXAchse.Size = new Size(77, 23);
            txtXAchse.TabIndex = 3;
            txtXAchse.TextAlign = HorizontalAlignment.Center;
            // 
            // txtYAchse
            // 
            txtYAchse.Location = new Point(103, 76);
            txtYAchse.Name = "txtYAchse";
            txtYAchse.Size = new Size(77, 23);
            txtYAchse.TabIndex = 4;
            txtYAchse.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 5;
            label1.Text = "Anzahl an Klicks";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 6;
            label2.Text = "Koordinaten (STRG+S)";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(9, 213);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 6;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtKoordinaten
            // 
            txtKoordinaten.Enabled = false;
            txtKoordinaten.Location = new Point(9, 105);
            txtKoordinaten.Name = "txtKoordinaten";
            txtKoordinaten.Size = new Size(171, 23);
            txtKoordinaten.TabIndex = 5;
            txtKoordinaten.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 12;
            label3.Text = "Klicktest";
            // 
            // boxKlickTest
            // 
            boxKlickTest.Controls.Add(label4);
            boxKlickTest.Location = new Point(9, 155);
            boxKlickTest.Name = "boxKlickTest";
            boxKlickTest.Size = new Size(171, 52);
            boxKlickTest.TabIndex = 13;
            boxKlickTest.TabStop = false;
            boxKlickTest.Click += BoxKlickTest_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 19);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 0;
            label4.Text = "Klicken um zu testen";
            label4.Click += label4_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // chkbox_once
            // 
            chkbox_once.Location = new Point(125, 26);
            chkbox_once.Name = "chkbox_once";
            chkbox_once.Size = new Size(69, 24);
            chkbox_once.TabIndex = 2;
            chkbox_once.Text = "nur &1x";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // label_help
            // 
            label_help.AutoSize = true;
            label_help.BackColor = SystemColors.ControlLight;
            label_help.Location = new Point(173, 8);
            label_help.Name = "label_help";
            label_help.Size = new Size(12, 15);
            label_help.TabIndex = 15;
            label_help.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(197, 255);
            Controls.Add(label_help);
            Controls.Add(chkbox_once);
            Controls.Add(boxKlickTest);
            Controls.Add(label3);
            Controls.Add(txtKoordinaten);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtYAchse);
            Controls.Add(txtXAchse);
            Controls.Add(txtKPS);
            Controls.Add(btnStart);
            Controls.Add(btnExit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(213, 294);
            MinimizeBox = false;
            MinimumSize = new Size(213, 294);
            Name = "Form1";
            Text = "Autoclicker v0.1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            MouseMove += Form1_MouseMove;
            boxKlickTest.ResumeLayout(false);
            boxKlickTest.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        /*private void BoxKlickTest_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private Button btnExit;
        private TextBox txtKPS;
        private TextBox txtXAchse;
        private TextBox txtYAchse;
        private Label label1;
        private Label label2;
        private Button btnStart;
        private TextBox txtKoordinaten;
        private Label label3;
        private GroupBox boxKlickTest;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private CheckBox chkbox_once;
        private System.Windows.Forms.Timer timer2;
        private ToolTip toolTip_onlyonce;
        private Label label_help;
    }
}
