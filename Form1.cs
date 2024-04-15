using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using System.Text;


namespace Autoclicker
{
    public partial class Form1 : Form
    {
        public int klicktest = 0;
        int zaehler;
        public bool abbruch = false;
        public Point myPoint = new Point();
        public KeyInfo taste = new KeyInfo();

        private HotKey StopThisNow = new HotKey();

        // Nächste 4 Zeilen für Mausklicks:
        private const UInt32 MouseEventLeftDown = 0x0002;
        private const UInt32 MouseEventLeftUp = 0x0004;

        [DllImport("user32", EntryPoint = "mouse_event")]
        private static extern void mouse_event(UInt32 dwFlags, UInt32 dx, UInt32 dy, UInt32 dwData, IntPtr dwExtraInfo);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {

            // Steht überhaupt etwas in den Koordinatenboxen?
            if (txtXAchse.Text == "" || txtXAchse.Text == "")
            {
                string myOldText = label3.Text;
                label3.Text = "Oh no!";
                label3.ForeColor = Color.Red;
                timer2.Interval = 3000;
                timer2.Start();
                //label3.Text = "Klicktest";
            }
            // Wenn ja, dann hier weitermachen
            else
            {
                int klickintervall = 0;
                int auswahl = list_kps.SelectedIndex;
                Point myPoint = new Point();
                myPoint.X = Int32.Parse(txtXAchse.Text);
                myPoint.Y = Int32.Parse(txtYAchse.Text);

                //schauen ob das "Anzahl der Klicks"-Feld gefüllt ist
                if (txtKPS.Text == "")
                {
                    zaehler = 1;
                }
                else
                {
                    zaehler = Int32.Parse(txtKPS.Text);
                }

                // Klicks pro Sekunde auslesen
                if (auswahl == 1)
                {
                    klickintervall = 10;
                }
                else if (auswahl == 2)
                {
                    klickintervall = 100;
                }
                else if (auswahl == 3)
                {
                    klickintervall = 1000;
                }
                else if (auswahl == 4)
                {
                    klickintervall = 2000;
                }
                else if (auswahl == 5)
                {
                    klickintervall = 5000;
                }
                else if (auswahl == 6)
                {
                    klickintervall = 10000;
                }
                else if (auswahl == 7)
                {
                    klickintervall = 60000;
                }
                else if (auswahl == 8)
                {
                    klickintervall = 300000;
                }

                Cursor.Position = myPoint;
                //timer_kps.Interval = klickintervall;
                //timer_kps.Start();

                while (zaehler > 0)
                {

                    if (zaehler == 0) break;

                    if (auswahl > 3)
                    {
                        Cursor.Position = myPoint;
                    }

                    mouse_event(MouseEventLeftDown, uint.Parse(txtXAchse.Text), uint.Parse(txtYAchse.Text), 0, new System.IntPtr());
                    mouse_event(MouseEventLeftUp, uint.Parse(txtXAchse.Text), uint.Parse(txtYAchse.Text), 0, new System.IntPtr());

                    Thread.Sleep(klickintervall);
                    zaehler -= 1;
                }

                //timer_kps.Stop();

                /* Alte Schleife aus v0.2
                for (int i = 0; i < zaehler; i++)
                {                    
                    mouse_event(MouseEventLeftDown, uint.Parse(txtXAchse.Text), uint.Parse(txtYAchse.Text), 0, new System.IntPtr());
                    mouse_event(MouseEventLeftUp, uint.Parse(txtXAchse.Text), uint.Parse(txtYAchse.Text), 0, new System.IntPtr());
                    
                    if (klickintervall > 3)
                    {
                        Cursor.Position = myPoint;
                    }

                }
                */

                // Am Ende den Fokus wieder auf das Autoclicker-Fenster setzen
                this.BringToFront();
                this.Activate();
                //txtKPS.Focus();
                btnStart.Focus();

            }
        }


        private void BoxKlickTest_Click(object sender, EventArgs e)
        {
            klicktest += 1;
            label3.Text = "Klicktest: " + klicktest.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BoxKlickTest_Click(0, e);
            //klicktest += 1;
            //label3.Text = "Klicktest: " + klicktest.ToString();
        }

        private void Form1_MouseMove(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Korrdinaten speichern
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                Point myPoint = new Point();
                myPoint = System.Windows.Forms.Control.MousePosition;

                //tKoordinaten.Text = myPoint.ToString();
                txtXAchse.Text = myPoint.X.ToString();
                txtYAchse.Text = myPoint.Y.ToString();
                label3.ForeColor = Color.Black;
            }

            StopThisNow.OwnerForm = this;
            StopThisNow.HotKeyPressed += new HotKey.HotKeyPressedEventHandler(HK_HotKeyPressed);
            StopThisNow.AddHotKey(Keys.X, HotKey.MODKEY.MOD_WIN, "TEST");





            // Klicken abbrechen
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {
                if (abbruch == false)
                {
                    label3.Text = "Warum?";
                    Thread.Sleep(1000);
                    label3.Text = "Klicktest";
                    klicktest = 0;
                }
                else
                {
                    abbruch = true;
                }
            }

        }
        public void HK_HotKeyPressed(string ID)
        {
            //MessageBox.Show(ID);
            abbruch = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            myPoint = System.Windows.Forms.Control.MousePosition;
            txtKoordinaten.Text = myPoint.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
            label3.Text = "Klicktest";
            timer2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtKPS.Text = "100";

            // SelectedIndex = { 0 | 8 }
            list_kps.Items.Add("Ja.");
            list_kps.Items.Add("100");
            list_kps.Items.Add("10");
            list_kps.Items.Add("1");
            list_kps.Items.Add("1 Klick alle 2 Sekunden");
            list_kps.Items.Add("1 Klick alle 5 Sekunden");
            list_kps.Items.Add("1 Klick alle 10 Sekunden");
            list_kps.Items.Add("1 Klick pro Minute");
            list_kps.Items.Add("1 Klick alle 5 Minute");
            list_kps.SelectedIndex = 0;

            toolTip_onlyonce.SetToolTip(this.label_help,
                "STRG + S = Mauskoordinaten speichern\n" +
                "(ALT +) S\t = Klicks ausführen\n" +
                "STRG + SHIFT + X = Klicks abbrechen\n" +
                "STRG + 1 = Checkbox \"nur 1x\" setzen\n" +
                "(ALT +) B = Programm beenden\n");
        }


        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (btnExpand.Text == "-")
            {
                this.Size = new Size(213, 205);
                btnExpand.Text = "+";
            }
            else
            {
                this.Size = new Size(213, 294);
                btnExpand.Text = "-";
            }
        }

        private void list_kps_SelectedIndexChanged(object sender, EventArgs e)
        {
            // gibt den Text der Auswahl aus
            //label2.Text = list_kps.SelectedItem.ToString();

            // gibt den Indexwert der Auswahl aus, beginnend mit 0
            //label2.Text = list_kps.SelectedIndex.ToString(); 
        }

        private void timer_kps_Tick(object sender, EventArgs e)
        {
            mouse_event(MouseEventLeftDown, uint.Parse(txtXAchse.Text), uint.Parse(txtYAchse.Text), 0, new System.IntPtr());
            mouse_event(MouseEventLeftUp, uint.Parse(txtXAchse.Text), uint.Parse(txtYAchse.Text), 0, new System.IntPtr());
            zaehler -= 1;
        }

        private void label_help_Click(object sender, EventArgs e)
        {
            //AboutBox1.

            AboutAutoclicker myForm = new AboutAutoclicker();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }
    }
}
