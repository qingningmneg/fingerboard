using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 输入速度
{
    public partial class FrmUninfo : DevExpress.XtraEditors.XtraForm
    {
        #region 键盘钩子
        /// <summary>
        /// 键盘钩子
        /// </summary>
        static int hKeyboardHook = 0; //键盘钩子句柄
        public const int WH_KEYBOARD_LL = 13; //处理键盘消息
        private const int WM_KEYDOWN = 0x100;//键盘按下
        HookProc KeyboardHookProcedure;//声明键盘钩子事件类型.

        /// <summary>
        /// 声明键盘钩子的封送结构类型
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public class KeyboardHookStruct
        {
            /// <summary>
            /// 表示一个在1到254间的虚似键盘码
            /// </summary>
            public int vkCode;
        }
        /// <summary>
        /// 装置钩子的函数
        /// </summary>
        /// <param name="idHook"></param>
        /// <param name="lpfn"></param>
        /// <param name="hInstance"></param>
        /// <param name="threadId"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        /// <summary>
        /// 卸下钩子的函数
        /// </summary>
        /// <param name="idHook"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        #region 下一个钩挂的函数
        /// <summary>
        /// 下一个钩挂的函数
        /// </summary>
        /// <param name="idHook"></param>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);
        [DllImport("user32")]
        public static extern int ToAscii(int uVirtKey, int uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, int fuState);
        [DllImport("user32")]
        public static extern int GetKeyboardState(byte[] pbKeyState);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);
        #endregion

        /// <summary>
        /// 先前按下的键
        /// </summary>
        public List<Keys> preKeys = new List<Keys>();
        int b;

        /// <summary>
        /// 析构函数
        /// </summary>
        public void Start()
        {
            //安装键盘钩子
            if (hKeyboardHook == 0)
            {
                KeyboardHookProcedure = new HookProc(KeyboardHookProc);
                Process curProcess = Process.GetCurrentProcess();//获取新的 Process 组件并将其与当前活动的进程关联
                ProcessModule curModule = curProcess.MainModule;
                hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyboardHookProcedure, GetModuleHandle(curModule.ModuleName), 0);
                if (hKeyboardHook == 0)
                {
                    Stop();
                    throw new Exception("SetWindowsHookEx ist failed.");
                }
                b = 0;
            }
        }
        public void Stop()
        {
            bool retKeyboard = true;
            if (hKeyboardHook != 0)
            {
                retKeyboard = UnhookWindowsHookEx(hKeyboardHook);
                hKeyboardHook = 0;
            }
            //如果卸下钩子失败
            if (!(retKeyboard)) throw new Exception("UnhookWindowsHookEx failed.");
        }
        int num = 0;//记录次数
        private int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            if (i == true)
            {
                if (wParam == WM_KEYDOWN)
                {
                    KeyboardHookStruct MyKeyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
                    Keys keyData = (Keys)MyKeyboardHookStruct.vkCode;
                    preKeys.Add(keyData);
                    num++;
                    Totalinputs.Text = Convert.ToString(num);
                    b = 1;
                }
            }
            return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
        }
        #endregion

        #region 函数
        /// <summary>
        /// 函数
        /// </summary>
        float nums = 0;
        int numss = 0;
        bool i = false;
        bool l = false;
        #endregion

        public FrmUninfo()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;//不能缩放
            FormBorderStyle = FormBorderStyle.FixedSingle;//不能拉边框
            MaximizeBox = false;//禁止最大化按钮
            //柠檬出品
            StartPosition = FormStartPosition.CenterScreen;//起始位置居中
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUninfo_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            l = false;
            Setthetop.Text = "取消设顶";
            this.Opacity = 0.7;
            Start();
        }

        /// <summary>
        /// 开始计算按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculation_Click(object sender, EventArgs e)
        {
            if (i == true)
            {
                Start();
            }
            if (calculation.Text == "开始计算")
            {
                TimeButton.Text = "目前状态(开始)";
                i = true;
                calculation.Text = "结束计算";
                num = 0;
                nums = 0;
                Totalinputs.Text = num.ToString();
                Inputspeeds.Text = "0" + "/m";
                Time.Text = nums.ToString() + "/s";
            }
            else
            {
                TimeButton.Text = "目前状态(开始)";
                i = false;
                calculation.Text = "开始计算";
                num = 0;
                nums = 0;
                Totalinputs.Text = num.ToString();
                Inputspeeds.Text = "0" + "/m";
                Time.Text = nums.ToString() + "/s";
            }
        }

        /// <summary>
        /// 时间事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (i == true)
            {
                CreateParams cp = base.CreateParams;
                Totalinputs.Text = num.ToString();
            }
        }

        /// <summary>
        /// 时间事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timers_Tick(object sender, EventArgs e)
        {
            if (i == true)
            {
                nums += 1;
                var a = num / nums * 60;
                Time.Text = nums.ToString() + "/s";
                Inputspeeds.Text = a.ToString() + "/m";
            }
        }

        /// <summary>
        /// 窗体设顶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Setthetop_Click(object sender, EventArgs e)
        {
            if (l == true)
            {
                this.TopMost = true;
                l = false;
                Setthetop.Text = "取消设顶";
            }
            else
            {
                this.TopMost = false;
                l = true;
                Setthetop.Text = "窗体设顶";
            }
        }

        /// <summary>
        /// 透明度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transparency_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 0.7)
            {
                this.Opacity = 0.8;
            }
            else
            if (this.Opacity == 0.8)
            {
                this.Opacity = 0.9;
            }
            else
            if (this.Opacity == 0.9)
            {
                this.Opacity = 1;
            }
            else
            if (this.Opacity == 1)
            {
                this.Opacity = 0.7;
            }
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {
            if (calculation.Text == "结束计算")
            {
                if (TimeButton.Text == "目前状态(开始)")
                {
                    i = false;
                    TimeButton.Text = "目前状态(暂停)";
                }
                else
                {
                    i = true;
                    TimeButton.Text = "目前状态(开始)";
                }
            }
        }
    }
}