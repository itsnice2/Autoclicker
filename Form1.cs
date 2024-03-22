using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;

namespace Autoclicker
{
    public partial class Form1 : Form
    {

        public int klicktest = 0;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtXAchse.Text == "" || txtXAchse.Text == "")
            {
                string myOldText = label3.Text;
                label3.Text = "Oh no!";
                label3.ForeColor = Color.Red;
                timer2.Interval = 3000;
                timer2.Start();
            }
            else
            {

                int zaehler = 0;
                Point myPoint = new Point();
                myPoint.X = Int32.Parse(txtXAchse.Text);
                myPoint.Y = Int32.Parse(txtYAchse.Text);
                
                if(txtKPS.Text == "")
                {
                    zaehler = 0;
                }
                else
                {
                    zaehler = Int32.Parse(txtKPS.Text);
                }

                if (chkbox_once.Checked == true) 
                {
                    Cursor.Position = myPoint;

                    for (int i = 0; i < zaehler; i++)
                    {
                        mouse_event(MouseEventLeftDown, uint.Parse(txtXAchse.Text), uint.Parse(txtYAchse.Text), 0, new System.IntPtr());
                        mouse_event(MouseEventLeftUp, uint.Parse(txtXAchse.Text), uint.Parse(txtYAchse.Text), 0, new System.IntPtr());
                        Thread.Sleep(100);
                    }
                }
                else
                {
                    //KeyEventHandler meinEvent = new KeyEventHandler();
                    
                    do 
                    {
                        Cursor.Position = myPoint;
                        mouse_event(MouseEventLeftDown, uint.Parse(txtXAchse.Text), uint.Parse(txtYAchse.Text), 0, new System.IntPtr());
                        mouse_event(MouseEventLeftUp, uint.Parse(txtXAchse.Text), uint.Parse(txtYAchse.Text), 0, new System.IntPtr());
                        Thread.Sleep(100);

                        zaehler += 1;

                        if (abbruch == true || zaehler == 100)
                        {
                            break;
                        }
                    }
                    while (abbruch == false);
                    
                }
                
                


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

            // "nur 1x" Checkbox
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D1)
            {
                if (chkbox_once.Checked == false)
                {
                    chkbox_once.Checked = true;
                }
                else
                {
                    chkbox_once.Checked = false;
                }
            }

            StopThisNow.OwnerForm = this;
            StopThisNow.HotKeyPressed += new HotKey.HotKeyPressedEventHandler(HK_HotKeyPressed);
            StopThisNow.AddHotKey(Keys.X, HotKey.MODKEY.MOD_WIN, "TEST");

        

            

            // Klicken abbrechen
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {
                if(abbruch == false)
                { 
                    label3.Text = "Warum?";
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
            timer2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkbox_once.Checked = true;
            chkbox_once.Enabled = false;
            txtKPS.Text = "100";
            
            toolTip_onlyonce.SetToolTip(this.chkbox_once, "Diese Klicks nur einmal auführen, oder wiederholen?");
            toolTip_onlyonce.SetToolTip(this.label_help,
                "STRG + S = Mauskoordinaten speichern\n" +
                "(ALT +) S\t = Klicks ausführen\n" +
                "STRG + SHIFT + X = Klicks abbrechen\n" +
                "STRG + 1 = Checkbox \"nur 1x\" setzen\n" +
                "(ALT +) B = Programm beenden\n");
        }

        //klicktest += 1;
        //txtKlickTest.Text = klicktest.ToString();
    }
}
