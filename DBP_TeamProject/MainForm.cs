using DBP_TeamProject.Forms;
using DBP_TeamProject.Properties;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

namespace DBP_TeamProject
{
    public partial class MainForm : Form
    {
        //�ʵ�
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private System.Windows.Forms.Timer messageCheckTimer;
        FormMessage formMessage = new FormMessage();
        FormMessage formMessage2 = FormMessage.GetInstance();

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            BtnCloseChlidFrom.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemColor()
        {
            int index = 0;

            string Color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(Color);
        }


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = Btnemployee.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    BtnCloseChlidFrom.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Btnwork_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormWork(), sender);

        }

        private void Btnemployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPersonnel_Management(), sender);
        }

        private void Btbmessage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMessage(), sender);
        }

        private void Btnapproval_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormApproval(), sender);
        }

        private void Btnchat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormChat(), sender);
        }

        private void BtnCloseChlidFrom_Click(object sender, EventArgs e)
        {
            /*
            if (activeForm != null)
                activeForm.Close();
            Reset();*/
            formMessage2.StopTimer();
            this.Close();

            // 기존에 생성된 로그인 폼을 사용
            if (Application.OpenForms["Login"] == null)
            {
                Login loginForm = new Login();
                loginForm.Show();
            }
            else
            {
                Application.OpenForms["Login"].Show();
            }
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            BtnCloseChlidFrom.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Btnemployee.PerformClick();
            try
            {
                pictureBox.Image = Properties.Resources.ShoBill;
               ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지 로드에 실패했습니다: " + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            messageCheckTimer = new System.Windows.Forms.Timer();
            messageCheckTimer.Interval = 3000; // 3초마다 확인
            messageCheckTimer.Tick += new EventHandler(formMessage.MessageCheckTimer_Tick);
            messageCheckTimer.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMessage2.StopTimer();
            if (messageCheckTimer != null)
            {
                messageCheckTimer.Stop();
                messageCheckTimer.Dispose();
            }
            LoginedUser.getInstance().UserId = "";
        }
    }
}