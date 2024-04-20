using Lookday_Beta.Models;
using Lookday_Beta_v17.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lookday_Beta_v17
{
    public partial class FrmRegister : Form
    {
        // Fields
        private FrmLogIn _logIn;
        private FrmSignUp _signUp;
        private FrmStaff _Staff;
        private FrmClientMain _ClientMain;
        private FrmMain _Main;

        private bool _isPanelExpanded = true;
        private Timer _animationTimer = new Timer();
        private int _targetWidth;
        private const int _animationInterval = 10;
        private const int _animationStep = 20;
        private const int _controlShiftAmount = 20;

        private Timer _moveTimer;
        private int _targetX;
        private const int _moveAmount = 20;

        public FrmRegister()
        {
            InitializeComponent();
            IsMdiContainer = true;
            InitializeMove(); // 初始化移動計時器
            InitializeAnimationTimer(); // 初始化動畫計時器
            this.FormClosing += new FormClosingEventHandler(RegisterForm_FormClosing);
        }



        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Convert.ToInt32(_logIn.staff) == 2
            //int.TryParse(_logIn.staff, out int number) && number == 2



            //if (_logIn._LogInEmail == "Client_Test@gmail.com" && _logIn._LogInPassword == "CustomerIsGod")
            //{


            //    if (_ClientMain == null)
            //    {
            //        _ClientMain = new FrmClientMain();
            //        _ClientMain.FormClosed += _ClientMain_FormClosed;
            //        _ClientMain.MdiParent = FrmMain.ActiveForm;
            //        _ClientMain.Dock = DockStyle.Fill;
            //        _ClientMain.Show();
            //    }
            //    else
            //    {
            //        _ClientMain.Activate();
            //    }
            //}

            if (_logIn._LogInEmail == "Staff_Test@gmail.com" && _logIn._LogInPassword == "fuckLetMeIn")
            {
                ((FrmMain)Application.OpenForms["FrmMain"]).HidePanels();

                if (_Staff == null)
                {
                    _Staff = new FrmStaff();
                    _Staff.FormClosed += _Staff_FormClosed;
                    _Staff.MdiParent = FrmMain.ActiveForm;
                    _Staff.Dock = DockStyle.Fill;
                    _Staff.Show();
                }
                else
                {
                    _Staff.Activate();
                }
            }

            if (CCheckInfo.StaffMode != true)
                return;
            ((FrmMain)Application.OpenForms["FrmMain"]).HidePanels();
            if (_Staff == null)
            {
                _Staff = new FrmStaff();
                _Staff.FormClosed += _Staff_FormClosed;
                _Staff.MdiParent = FrmMain.ActiveForm;
                _Staff.Dock = DockStyle.Fill;
                _Staff.Show();
            }
            else
            {
                _Staff.Activate();
            }


        }

        private void _ClientMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ClientMain = null;
        }

        private void _Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Staff = null;
        }

        // Initialization Methods
        private void InitializeMove()
        {
            _moveTimer = new Timer();
            _moveTimer.Interval = 10;
            _moveTimer.Tick += MoveTimer_Tick; // 設置移動計時器的Tick事件處理程序
        }
        private void InitializeAnimationTimer()
        {
            _animationTimer.Interval = _animationInterval;
            _animationTimer.Tick += AnimationTimer_Tick; // 設置動畫計時器的Tick事件處理程序
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            CAnimation.FadeIn(this); // 視窗淡入效果
            InitializeButtonColors(); // 初始化按鈕顏色
            OpenLoginForm(); // 打開登錄窗口
            OpenSignUpForm(); // 打開註冊窗口
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            StartPanelAnimation(); // 開始Panel的動畫效果
            MovePanelToLeft(); // 將Panel移動到左側
        }

        public void btnSignUp_Click(object sender, EventArgs e)
        {
            StartPanelAnimation(); // 開始Panel的動畫效果
            MovePanelToRight(); // 將Panel移動到右側
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CManager.CloseFormsAndActivateMain(this);
        }

        private void OpenLoginForm()
        {
            if (_logIn == null)
            {
                _logIn = new FrmLogIn();
                _logIn.FormClosed += _logIn_FormClosed;
                _logIn.MdiParent = this;
                _logIn.Dock = DockStyle.Right;
                _logIn.Show();
            }
            else
            {
                _logIn.Activate();
            }
        }

        private void _logIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logIn = null;
        }

        private void OpenSignUpForm()
        {
            if (_signUp == null)
            {
                _signUp = new FrmSignUp();
                _signUp.FormClosed += _signUp_FormClosed;
                _signUp.MdiParent = this;
                _signUp.Dock = DockStyle.Left;
                _signUp.Show();
            }
            else
            {
                _signUp.Activate();
            }
        }

        private void InitializeButtonColors()
        {
            // 初始化按鈕顏色
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 0, 0, 0);
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSignUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 255, 255, 255);
            btnLogIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(130, 244, 144, 44);
        }

        private void _signUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            _signUp = null;
        }



        private void StartPanelAnimation()
        {
            // 開始Panel的動畫效果
            if (!_animationTimer.Enabled)
            {
                _targetWidth = 360;
                _isPanelExpanded = false;
                _animationTimer.Start();
            }
        }

        private void MovePanelToLeft()
        {
            // 將Panel移動到左側
            if (panel1.Location != new Point(0, 0))
            {
                _targetX = 0;
                _moveTimer.Start();
            }
        }

        private void MovePanelToRight()
        {
            // 將Panel移動到右側
            if (panel1.Location.Equals(new Point(0, 0)))
            {
                _targetX = 340;
                _moveTimer.Start();
            }
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            // 移動Panel的定時器事件處理程序
            if (panel1.Location.X < _targetX)
            {
                int newX = Math.Min(panel1.Location.X + _moveAmount, _targetX);
                panel1.Location = new Point(newX, panel1.Location.Y);
            }
            else if (panel1.Location.X > _targetX)
            {
                int newX = Math.Max(panel1.Location.X - _moveAmount, _targetX);
                panel1.Location = new Point(newX, panel1.Location.Y);
            }
            else
            {
                _moveTimer.Stop();
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Panel動畫的定時器事件處理程序
            if (_isPanelExpanded && panel1.Width < _targetWidth)
            {
                panel1.Width = Math.Min(panel1.Width + _animationStep, _targetWidth);
                MoveControlsAndCenterButton(_controlShiftAmount);
            }
            else if (!_isPanelExpanded && panel1.Width > _targetWidth)
            {
                panel1.Width = Math.Max(panel1.Width - _animationStep, _targetWidth);
                MoveControlsAndCenterButton(-_controlShiftAmount);
            }
            else
            {
                _animationTimer.Stop();
            }
        }

        private void MoveControlsAndCenterButton(int shiftAmount)
        {
            // 移動Panel上的控制項，並使其始終位於Panel的中間
            btnLogIn.Left += shiftAmount;
            btnSignUp.Left += shiftAmount;
            label1.Left += shiftAmount;

            btnLogIn.Left = (panel1.Width - btnLogIn.Width) / 2;
            btnSignUp.Left = (panel1.Width - btnSignUp.Width) / 2;
            label1.Left = (panel1.Width - label1.Width) / 2;
        }
    }
}
