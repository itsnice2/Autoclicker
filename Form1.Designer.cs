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
            timer2 = new System.Windows.Forms.Timer(components);
            toolTip_onlyonce = new ToolTip(components);
            label_help = new Label();
            btnExpand = new Button();
            list_kps = new ComboBox();
            label5 = new Label();
            timer_kps = new System.Windows.Forms.Timer(components);
            boxKlickTest.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Name = "btnExit";
            toolTip_onlyonce.SetToolTip(btnExit, resources.GetString("btnExit.ToolTip"));
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtKPS
            // 
            resources.ApplyResources(txtKPS, "txtKPS");
            txtKPS.Name = "txtKPS";
            toolTip_onlyonce.SetToolTip(txtKPS, resources.GetString("txtKPS.ToolTip"));
            // 
            // txtXAchse
            // 
            resources.ApplyResources(txtXAchse, "txtXAchse");
            txtXAchse.Name = "txtXAchse";
            toolTip_onlyonce.SetToolTip(txtXAchse, resources.GetString("txtXAchse.ToolTip"));
            // 
            // txtYAchse
            // 
            resources.ApplyResources(txtYAchse, "txtYAchse");
            txtYAchse.Name = "txtYAchse";
            toolTip_onlyonce.SetToolTip(txtYAchse, resources.GetString("txtYAchse.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            toolTip_onlyonce.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            toolTip_onlyonce.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // btnStart
            // 
            resources.ApplyResources(btnStart, "btnStart");
            btnStart.Name = "btnStart";
            toolTip_onlyonce.SetToolTip(btnStart, resources.GetString("btnStart.ToolTip"));
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtKoordinaten
            // 
            resources.ApplyResources(txtKoordinaten, "txtKoordinaten");
            txtKoordinaten.Name = "txtKoordinaten";
            toolTip_onlyonce.SetToolTip(txtKoordinaten, resources.GetString("txtKoordinaten.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            toolTip_onlyonce.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // boxKlickTest
            // 
            resources.ApplyResources(boxKlickTest, "boxKlickTest");
            boxKlickTest.Controls.Add(label4);
            boxKlickTest.Name = "boxKlickTest";
            boxKlickTest.TabStop = false;
            toolTip_onlyonce.SetToolTip(boxKlickTest, resources.GetString("boxKlickTest.ToolTip"));
            boxKlickTest.Click += BoxKlickTest_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            toolTip_onlyonce.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            label4.Click += label4_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // label_help
            // 
            resources.ApplyResources(label_help, "label_help");
            label_help.BackColor = SystemColors.ControlLight;
            label_help.Name = "label_help";
            toolTip_onlyonce.SetToolTip(label_help, resources.GetString("label_help.ToolTip"));
            label_help.Click += label_help_Click;
            // 
            // btnExpand
            // 
            resources.ApplyResources(btnExpand, "btnExpand");
            btnExpand.Name = "btnExpand";
            toolTip_onlyonce.SetToolTip(btnExpand, resources.GetString("btnExpand.ToolTip"));
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // list_kps
            // 
            resources.ApplyResources(list_kps, "list_kps");
            list_kps.DropDownStyle = ComboBoxStyle.DropDownList;
            list_kps.DropDownWidth = 160;
            list_kps.FormattingEnabled = true;
            list_kps.Name = "list_kps";
            toolTip_onlyonce.SetToolTip(list_kps, resources.GetString("list_kps.ToolTip"));
            list_kps.SelectedIndexChanged += list_kps_SelectedIndexChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            toolTip_onlyonce.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            // 
            // timer_kps
            // 
            timer_kps.Tick += timer_kps_Tick;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(list_kps);
            Controls.Add(btnExpand);
            Controls.Add(label_help);
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
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            toolTip_onlyonce.SetToolTip(this, resources.GetString("$this.ToolTip"));
            TopMost = true;
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
        private System.Windows.Forms.Timer timer2;
        private ToolTip toolTip_onlyonce;
        private Label label_help;
        private Button btnExpand;
        private ComboBox list_kps;
        private Label label5;
        private System.Windows.Forms.Timer timer_kps;
    }
}
