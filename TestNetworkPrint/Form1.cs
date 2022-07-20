namespace TestNetworkPrint
{
    using System.Diagnostics;
    public partial class Form1 : Form
    {
        /*
        #####################################################################
                                    Please Note:
        The idea is that only have to edit the constants in order to see the differences. 
        
        For instance, during debut, HiddenGem = true (to show what it will look like in release. 
        
        ########################################################################
        */
        //private bool OpenOnDoubleClick = false;
        private bool debug = true;
        // private bool HiddenGem = true; // Please set this to true - false will automatically bring up the form and all undo all of the hiding. 

        public Form1()
        {
            Debug.WriteLine("Debug Information-Product Starting: ");
            InitializeComponent();

            Debug.WriteLine("THIS IS INITIALISING");

            //if (HiddenGem)
            //{
                //this.ShowInTaskbar = false;
                //this.FormBorderStyle = FormBorderStyle.None; // This needs @  protected override CreateParams CreateParams to make it hidden in taskbar too!
                //this.WindowState = System.Windows.Forms.FormWindowState.Minimized; 
                //this.Text = "Wifi Listener Settings"; //with above 2 lines text is tool title
                //this.notifyIcon.Visible = true;
            //}
            Debug.WriteLine("THIS IS after form is hiden and tray icon. INITIALISING");

        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("THIS HAPPENS UPON LOAD.... (please cheack saved files now");
            String configSettings = LoadData();
            if (configSettings != null)
            {
                // use LoadData to set settings and 
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;

            } else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
        // change save and load manager to be a seperate reusable class dummy


        private string LoadData()
        {
            //test load config & if none exist, or the config is giberish return null 
            Debug.WriteLine("Loading data ...");
            Random random = new Random();
            int n = random.Next(10);
            if (n >= 5)
            {
                return "abcdef";
            }
            else
                return null;
            //throw new NotImplementedException();
        }

        private void ShowSettings()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (checkBox4.Checked)
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            //else do nothing.
        }

        private void closeExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fakeexit
            //realexit
            if (debug)
                Application.Exit();
            else
                fakeExit();
        }

        private void fakeExit()
        {
            // just hides the notifactionicon
            this.notifyIcon1.Visible = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            //this.Text = "Wifi Listener Settings"; //with above 2 lines text is tool title
            //throw new NotImplementedException();
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            //this.FormBorderStyle = FormBorderStyle.None; // This needs @  protected override CreateParams CreateParams to make it hidden in taskbar too!
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            //this.Text = "Wifi Listener Settings"; //with above 2 lines text is tool title
            //this.notifyIcon.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fakeExit();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox4.Checked = !checkBox4.Checked;
            //OpenOnDoubleClick = checkBox4.Checked;

            //This doesnt need to work (ie. nothing changes upon the change of the checkbox. )
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Hide Options")
            {
                this.Size = new Size(340, 190);
                flowLayoutPanel1.Visible = false;
                button1.Text = "Adv. Options";
            }
            else 
            {
                this.Size = new Size(340, 300);
                button1.Text = "Hide Options";
                flowLayoutPanel1.Visible = true;
            }
            
            
        }
    }
}