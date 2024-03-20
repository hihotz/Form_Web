using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Motion
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser browser = null;
        public static int count = 0;
        private static int max = 10;
        
        public Form1()
        {
            InitializeComponent();

            InitBrowser();
        }

        #region DLL 이용
        //c++ dll 이용
        [DllImport("MotionDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SUM(int a, int b);

        private static void sum(int a) 
        {
            //c++ dll 이용
            count = SUM(count, a);
            if(count>=max)
            {
                MessageBox.Show("횟수가 " + max + "이상입니다");
            }
        }
        private static void showmsgbox()
        {
            MessageBox.Show("전달받은 값의 합 : " + count.ToString());
        }
        #endregion

        #region 크롬
        private void InitBrowser()
        {
            CefSettings settings = new CefSettings();
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");

            Cef.Initialize(settings);
            browser = new ChromiumWebBrowser("www.google.com");     //웹사이트 이동
            this.browser.AddressChanged += Browser_AddressChanged;  //페이지 변경시 상단 주소바 텍스트 변경
            //browser = new ChromiumWebBrowser(@"C:\Users\h0104\Desktop\234.pdf");

            browser.BrowserSettings.AcceptLanguageList = "ko-KR";   //한국어 설정
            this.panel3.Controls.Add(browser);                      //panel3에 브라우저 추가
            browser.Dock = DockStyle.Fill;                          //영역 채우기

            // Javascript Event 호출 - cAPI.showMsg()
            browser.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true;
            browser.JavascriptObjectRepository.Register("cAPI", new ChromeAPI(), false, BindingOptions.DefaultBinder);
        }
        internal class ChromeAPI 
        { 
            public void showMsg(string msg) 
            { 
                MessageBox.Show("전달한 값 : " + msg);
                sum(Int32.Parse(msg));
            } 
        }

        #endregion

        #region 좌측 버튼
        private void GoBack_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void GoFront_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void GoHome_Click(object sender, EventArgs e)
        {
            browser.Load("www.google.com");
        }
        #endregion

        #region 우측 버튼
        private void Web_URL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_Click(sender, e);
            }
        }

        private void Web_URL2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                browser.Load("https://www.google.com/search?q=" + Web_URL2.Text);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            browser.Load(Web_URL.Text);
        }

        private void FindFile_Click(object sender, EventArgs e)
        {
            Web_URL.Clear();

            String file_path = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                Web_URL.Text = file_path;
            }
            browser.Load(Web_URL.Text);
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            try
            {
                Web_URL.Text = e.Address;
            }
            catch { }
        }

        private void move_Click(object sender, EventArgs e)
        {
            browser.Load("http://localhost:8080/posemodel/index.html");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            showmsgbox();
        }
        #endregion
    }
}

