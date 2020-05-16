using Gma.System.MouseKeyHook;
using System;
using System.Windows.Forms;

namespace ClipboardSetter.WindowsForms
{
    public partial class FrmMain : Form
    {
        int idx = 0;
        private IKeyboardMouseEvents m_GlobalHook;

        public FrmMain()
        {
            InitializeComponent();
            Subscribe();
        }



        private void BtnNext_Click(object sender, EventArgs e)
        {
            idx++;
            txtClipboardContent.SelectAll();
            txtClipboardContent.Text = idx.ToString();
            Clipboard.SetText(txtClipboardContent.Text);
        }
        public void Subscribe()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyUp += GlobalHook_KeyUp; 
        }

        private void ShowForm()
        {
            Show();
            this.WindowState = FormWindowState.Normal;          
            txtClipboardContent.Focus();
            txtClipboardContent.SelectAll();
        }

        private void GlobalHook_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add && e.Shift && e.Control)
            {
                ShowForm();
                Activate();
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            idx = 0;
        }
    }
}
