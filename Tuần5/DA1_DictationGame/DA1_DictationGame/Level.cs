﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DA1_DictationGame.BS_layer;


namespace DA1_DictationGame
{
    public partial class Level : Form
    {
        public Level()
        {
            InitializeComponent();
        }

        private const int WM_INCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void mix(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_INCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Main.level = 1;
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Main.level = 2;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Main.level = 3;
        }
    }
}
