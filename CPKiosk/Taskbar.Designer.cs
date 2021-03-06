﻿namespace CPKiosk
{
    partial class TaskBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.StartMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.firefoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Border1 = new System.Windows.Forms.PictureBox();
            this.Border2 = new System.Windows.Forms.PictureBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.StartMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Border1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Location = new System.Drawing.Point(2, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.StartButton.Size = new System.Drawing.Size(54, 22);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.Paint += new System.Windows.Forms.PaintEventHandler(this.StartButton_Paint);
            // 
            // StartMenu
            // 
            this.StartMenu.AutoSize = false;
            this.StartMenu.DropShadowEnabled = false;
            this.StartMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.StartMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firefoxToolStripMenuItem,
            this.internetExplorerToolStripMenuItem,
            this.testToolStripMenuItem,
            this.testToolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.shutDownToolStripMenuItem});
            this.StartMenu.Name = "StartMenu";
            this.StartMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.StartMenu.Size = new System.Drawing.Size(300, 300);
            this.StartMenu.Opened += new System.EventHandler(this.StartMenu_Opened);
            this.StartMenu.LayoutCompleted += new System.EventHandler(this.StartMenu_LayoutCompleted);
            this.StartMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.StartMenu_Paint);
            // 
            // firefoxToolStripMenuItem
            // 
            this.firefoxToolStripMenuItem.Name = "firefoxToolStripMenuItem";
            this.firefoxToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.firefoxToolStripMenuItem.Text = "Firefox";
            // 
            // internetExplorerToolStripMenuItem
            // 
            this.internetExplorerToolStripMenuItem.Name = "internetExplorerToolStripMenuItem";
            this.internetExplorerToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.internetExplorerToolStripMenuItem.Text = "Internet Explorer";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Image = global::CPKiosk.Properties.Resources.flag;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.testToolStripMenuItem.Text = "Google Chrome";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(296, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.optionsToolStripMenuItem.Text = "Options...";
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.shutdownToolStripMenuItem1});
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.shutDownToolStripMenuItem.Text = "Shut Down";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.restartToolStripMenuItem.Text = "Restart...";
            // 
            // shutdownToolStripMenuItem1
            // 
            this.shutdownToolStripMenuItem1.Name = "shutdownToolStripMenuItem1";
            this.shutdownToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.shutdownToolStripMenuItem1.Text = "Shutdown...";
            // 
            // Border1
            // 
            this.Border1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Border1.Location = new System.Drawing.Point(0, 1);
            this.Border1.Name = "Border1";
            this.Border1.Size = new System.Drawing.Size(700, 1);
            this.Border1.TabIndex = 3;
            this.Border1.TabStop = false;
            // 
            // Border2
            // 
            this.Border2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Border2.Location = new System.Drawing.Point(0, 2);
            this.Border2.Name = "Border2";
            this.Border2.Size = new System.Drawing.Size(700, 1);
            this.Border2.TabIndex = 4;
            this.Border2.TabStop = false;
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLbl.Location = new System.Drawing.Point(629, 4);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(68, 22);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "0:00 AM";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(62, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 25);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // TaskBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 28);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Border1);
            this.Controls.Add(this.Border2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskBar";
            this.Text = "CPK TaskBar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TaskBar_Load);
            this.StartMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Border1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox Border1;
        private System.Windows.Forms.PictureBox Border2;
        private System.Windows.Forms.ContextMenuStrip StartMenu;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem firefoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

