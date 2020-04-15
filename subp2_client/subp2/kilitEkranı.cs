using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
namespace subp2
{
    public partial class kilitEkranı : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }
        subp2.oturum_secenekleri_kontrol sinif_cek2 = new subp2.oturum_secenekleri_kontrol();
        subp2.bag_class sinif_cek3 = new subp2.bag_class();
        int sayac = 0, kapansinmi = 0;
        public kilitEkranı()
        {
            InitializeComponent();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue("Internet Merkezi", "\"" + Application.ExecutablePath + "\"");// Projeyi Bilgisayarın Açılışına Ayarlama
        }
        /* Code to Disable WinKey, Alt+Tab, Ctrl+Esc Starts Here */
        // Structure contain information about low-level keyboard input event 
       

        //Alt tab   alt esc   altf4 gibi engellemeleri sağlıyoruz dll lerimizi çekiyoruz
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
        //Declaring Global objects     
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (Giris.tuslari_serbest_birak == 0)
            {
                if (nCode >= 0)
                {
                    KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));
                    if (objKeyInfo.key == Keys.F4 || objKeyInfo.key == Keys.Escape || objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || objKeyInfo.key == Keys.Escape && (ModifierKeys & Keys.Control) == Keys.Control)
                    {
                        return (IntPtr)1; // bu ifde engellenecek tuşlar giriliyor
                    }
                }

            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }
        /* son WinKey, Alt+Tab, Ctrl+Esc çalışmaz */
        [DllImport("user32.dll")]//Dll'mizi çekiyoruz
        [return: MarshalAs(UnmanagedType.Bool)]//Dll'mizi çekiyoruz
        static extern bool SetForegroundWindow(IntPtr hWnd);//Dll'mizi çekiyoruz

        private void kilitEkrani_Load(object sender, EventArgs e)
        {
            kapanma_kontrol.Start();
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
            formYenile.Start();
            Giris frm = new Giris();
            frm.ShowDialog();
            this.TopMost = false; 
        }
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private void formYenile_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac >= 2)
            {
                sayac = 0;
                kilitEkranı frm2 = new kilitEkranı();//2 saniye sonra  formu yeniliyoruz ve tekrar açıyoruz bunun sebebi form ilk açıldığında arka planda kalıyor bu sayede ön planda kalıyor
                frm2.BringToFront();
                Cursor.Position = new Point(50, 10);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Cursor.Position = new Point(800, 300);
                formYenile.Stop();
            }
        }
        private void kapanma_kontrol_Tick(object sender, EventArgs e)
        {
            kapansinmi = Giris.kapan;
            if (kapansinmi == 1)
            {
                this.Hide();
                kapansinmi = 0;
                kapanma_kontrol.Stop();
            }
        }
   }
}
