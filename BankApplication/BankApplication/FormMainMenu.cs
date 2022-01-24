using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BankApplication.Forms;
using FontAwesome.Sharp;
using ClassLibrary;
using TechSupport;
using config_library;

namespace BankApplication
{
    public partial class FormMainMenu : Form
    {
        public BankApp bankapp = new BankApp();
        public config jakub = new config(); //kuby dziwna kontrolka xddd
        

        

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormMainMenu()
        {
            InitializeComponent();


            bankapp.user = new User{ id=24, type=UserType.Employee, balance=1327.35, password="Asdasd", firstname="Maciejos" };

            //jakub.setUser(Convert.ToString(bankapp.user.id)); 


            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            OpenChildForm(new FormJagerBank());
            if (bankapp.user.type == UserType.User) {
            } else {
                btnDashboard.Text = "Panel Admin";
                btnDashboard.IconChar = IconChar.UserCog;
                btnOnlinehelp.IconChar = IconChar.Headset;
                btnCards.Visible = false;
                btnFriends.Visible = false;
                btnTransfers.Visible = false;
                btnStockmarket.Visible = false;
                btnExchange.Visible = false;
            }
        }

        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(234, 71, 16);
            public static Color color2 = Color.FromArgb(249, 202, 3);
            public static Color color3 = Color.FromArgb(204, 220, 12);
            public static Color color4 = Color.FromArgb(99, 188, 39);
            public static Color color5 = Color.FromArgb(61, 174, 47);
            public static Color color6 = Color.FromArgb(1, 157, 60);
            public static Color color7 = Color.FromArgb(0, 149, 113);
            public static Color color8 = Color.FromArgb(1, 140, 200);
            public static Color color9 = Color.FromArgb(214, 215, 223);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(57, 57, 57);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                //leftBorderBtn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                labelTitleChildForm.Text = Text;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(39, 39, 39);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.QuestionCircle;
            iconCurrentChildForm.IconColor = Color.White;
            labelTitleChildForm.Text = "Information";
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = childForm.Text;
            labelTitleChildForm.ForeColor = Color.Gainsboro;
        }

        private void btnlogoHome_Click(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new FormJagerBank());
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            if(bankapp.user.type == UserType.User) {
                OpenChildForm(new FormDashboard());
            } else {
                OpenChildForm(new FormAdmin());
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color6);
            OpenChildForm(new FormSettings());
            jakub.LaunguageChanged += Jakub_LaunguageChanged;
            jakub.ColorChanged += Jakub_ColorChanged;

        }

        private void Jakub_ColorChanged(object o, EventArgs e)
        {
            config jakub = new config();
            var kolor = jakub.returnColor();
        }

        private void Jakub_LaunguageChanged(object o, EventArgs e)
        {
            config jakub = new config();
            var jezyk = jakub.returnLaunguage();
        }

        private void btnCards_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            OpenChildForm(new FormCards());
        }

        private void btnTransfers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color5);
            OpenChildForm(new FormTransfers());
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color4);
        }

        private void btnStockmarket_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color2);
            OpenChildForm(new FormStockMarket());
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color7);
            OpenChildForm(new FormFriends());
        }

        private void btnOnlinehelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color8);
            TechSupportControl.OpenSupport(bankapp);
        }
        //drag from
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
