namespace TestNetworkPrint
{
    public partial class Form1 : Form
    {
        private const bool hiddenGem = false;

        public Form1()
        {
            InitializeComponent();
            if (true)
            {
                ShowInTaskbar = false;
                this.FormBorderStyle = FormBorderStyle.None;
                //this.ShowInTaskbar = false; // Change this when you're ready to be complete silent ninja
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                this.Text = "THIS SHOULD BE HIDDEN";
            }
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

        }
    }
}