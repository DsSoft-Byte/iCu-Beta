﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button button1;
        private Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Panel panel1;
        private Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private Panel panel2;
        private Label label4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private Label label3;
        private Panel panel3;
        private Label label5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private Label label6;
        private Panel panel4;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private Label label7;
        private Panel panel5;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private Label label8;
        private Panel panel6;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel7;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private System.Windows.Forms.Button button26;
        private Label label16;
        private Label label17;
        private System.Windows.Forms.Button button2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process.Start("cmd.exe");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.ShowDialog();
        }

        class Program
        {
            static void Lolhamburgir(string[] args)
            {
                string startPath = @".\start";
                string zipPath = @".\result.zip";
                string extractPath = @".\extract";

                ZipFile.CreateFromDirectory(startPath, zipPath);

                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\extract\iCures\CB-A-config.txt"))
            {
                MessageBox.Show("Update files are present. ERROR CODE 2");
            }
            else
            {
                // Download Zip file using WebClient from github link, save to Updater.zip, Extract to extracted. Pass onto updater then.
                WebClient webClient = new WebClient();
                webClient.DownloadFile(new Uri("https://raw.githubusercontent.com/DsSoft-Byte/iCu/main/iCures_Updater.zip"), @"C:\Updater.zip");
                string zipPath = @"C:\Updater.zip";
                string extractPath = @"C:\extract";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                //MessageBox.Show("Downloaded and Extracted!");
                //Start Standalone Updater
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Checker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "DUZIP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "iCu+ Dev Beta 47 GUI Panel";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Start Bat1.bat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(195, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "Update Hub";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(737, 480);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 52);
            this.button5.TabIndex = 6;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 170);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(92, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pwned DFU A7-A11";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Location = new System.Drawing.Point(15, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(261, 28);
            this.button6.TabIndex = 9;
            this.button6.Text = "Install MinGW (Optional)";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Location = new System.Drawing.Point(15, 73);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(261, 28);
            this.button7.TabIndex = 10;
            this.button7.Text = "Use Zadig";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button8.Location = new System.Drawing.Point(15, 107);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(261, 28);
            this.button8.TabIndex = 11;
            this.button8.Text = "Run gaster";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(337, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 170);
            this.panel2.TabIndex = 12;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button10.Location = new System.Drawing.Point(15, 73);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(261, 28);
            this.button10.TabIndex = 10;
            this.button10.Text = "Run UDID/ECID scan";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button11.Location = new System.Drawing.Point(15, 40);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(124, 28);
            this.button11.TabIndex = 9;
            this.button11.Text = "Bypa$$ x86";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(100, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tethered Bypa$$";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button12.Location = new System.Drawing.Point(145, 40);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(131, 28);
            this.button12.TabIndex = 12;
            this.button12.Text = "Bypa$$ x64";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(49, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "All A5 Devices supported";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(655, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 170);
            this.panel3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(31, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "All iOS 7.X.X Devices supported";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button9.Location = new System.Drawing.Point(145, 40);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 28);
            this.button9.TabIndex = 12;
            this.button9.Text = "Bypa$$ x64";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button13.Location = new System.Drawing.Point(15, 73);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(261, 28);
            this.button13.TabIndex = 10;
            this.button13.Text = "Run Pangu7";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button14.Location = new System.Drawing.Point(15, 40);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(124, 28);
            this.button14.TabIndex = 9;
            this.button14.Text = "Bypa$$ x86";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(104, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pangu7 Bypa$$";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.panel4.Controls.Add(this.button15);
            this.panel4.Controls.Add(this.button16);
            this.panel4.Controls.Add(this.button17);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(18, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 170);
            this.panel4.TabIndex = 12;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button15.Location = new System.Drawing.Point(15, 107);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(261, 28);
            this.button15.TabIndex = 11;
            this.button15.Text = "Run XAMPP";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button16.Location = new System.Drawing.Point(15, 73);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(261, 28);
            this.button16.TabIndex = 10;
            this.button16.Text = "Download XAMPP";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button17.Location = new System.Drawing.Point(15, 40);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(261, 28);
            this.button17.TabIndex = 9;
            this.button17.Text = "Flash Linux *.iso to USB";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(79, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bypa$$ Preparation tools";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.panel5.Controls.Add(this.button18);
            this.panel5.Controls.Add(this.button19);
            this.panel5.Controls.Add(this.button20);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(337, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(292, 170);
            this.panel5.TabIndex = 13;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button18.Location = new System.Drawing.Point(15, 107);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(261, 28);
            this.button18.TabIndex = 11;
            this.button18.Text = "Limera1n DFU";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button19.Enabled = false;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button19.Location = new System.Drawing.Point(15, 73);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(261, 28);
            this.button19.TabIndex = 10;
            this.button19.Text = "Legacy Tools | Soon!";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button20.Location = new System.Drawing.Point(15, 40);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(261, 28);
            this.button20.TabIndex = 9;
            this.button20.Text = "Install iTunes package";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(75, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Legacy tools | Win 7 x64 best";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.panel6.Controls.Add(this.button24);
            this.panel6.Controls.Add(this.button21);
            this.panel6.Controls.Add(this.button22);
            this.panel6.Controls.Add(this.button23);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(655, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(292, 170);
            this.panel6.TabIndex = 14;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button21.Location = new System.Drawing.Point(145, 107);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(131, 28);
            this.button21.TabIndex = 11;
            this.button21.Text = "Info/Help";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button22.Location = new System.Drawing.Point(15, 73);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(261, 28);
            this.button22.TabIndex = 10;
            this.button22.Text = "Update Hub";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click_1);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button23.Location = new System.Drawing.Point(15, 40);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(261, 28);
            this.button23.TabIndex = 9;
            this.button23.Text = "Settings";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(94, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Settings | Misc tools";
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button24.Location = new System.Drawing.Point(14, 107);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(125, 28);
            this.button24.TabIndex = 12;
            this.button24.Text = "CB/X/A | Unsupported";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(277, 522);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(454, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "IF YOU SEE THIS BUILD CONTACT u/The_Hackintosh ON REDDIT FOR A CASH BOUNTY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(862, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 31);
            this.label11.TabIndex = 16;
            this.label11.Text = "47B51";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.button3);
            this.panel7.Location = new System.Drawing.Point(337, 478);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(382, 38);
            this.panel7.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(14, 478);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Current iDevice mode:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(14, 512);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Current iDevice UDID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(186, 481);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "null\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(186, 515);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "null\r\n";
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button26.Location = new System.Drawing.Point(824, 9);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(130, 28);
            this.button26.TabIndex = 12;
            this.button26.Text = "Version Information";
            this.button26.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(417, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(225, 39);
            this.label16.TabIndex = 21;
            this.label16.Text = "iCu+ V47.X.X";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(635, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 24);
            this.label17.TabIndex = 22;
            this.label17.Text = "Rewritten in C#";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(966, 544);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "iCu+ DBeta 47";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
                if (File.Exists(@"C:\iCuPlus.zip"))
                    MessageBox.Show("Update file detected ERROR 2");
            else

            {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://raw.githubusercontent.com/DsSoft-Byte/iCu/main/iCures_Updater.zip", @"C:\iCuPlus.zip");
                    string zipPath = @"C:\iCuPlus.zip";
                    string extractPath = @"C:\UpdateData";
                    System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);

                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\iCU\bat1.bat");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"C:\iCures\mingw-inst.exe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\iCures\zadig27.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\iCures\gaster.bat");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\iCures\idact.bat");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\iCures\idact-x64.bat");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\iCures\prelaunch.bat");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\iCures\idact.bat");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\iCures\idact-x64.bat");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\iCures\Dependencies\Pangu\pangu_1.0-en.exe");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothin' here yet. But soon will be.");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process.Start("https://downloadsapachefriends.global.ssl.fastly.net/8.1.10/xampp-windows-x64-8.1.10-0-VS16-installer.exe?from_af=true");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\xampp\xampp-control.exe");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.filehorse.com/download-itunes-64/16353/download/");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\iCures\idpwn.bat");
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothin' here yet.");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I dont know yet if this will be used");
        }
    }


}
