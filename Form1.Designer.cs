﻿namespace YoutubeSegmentDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_checking_ytdlp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_checking_ffmpeg = new System.Windows.Forms.Label();
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_outputDirectory = new System.Windows.Forms.TextBox();
            this.button_folder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_segment = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_youtube = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_segment = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_end = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_start = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.panel_download = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_license = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLogControl1 = new Serilog.Sinks.WinForms.RichTextBoxLogControl();
            this.checkBox_logVerbose = new System.Windows.Forms.CheckBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel_main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_segment.SuspendLayout();
            this.panel_download.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label_checking_ytdlp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_checking_ffmpeg);
            this.panel1.Location = new System.Drawing.Point(200, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 100);
            this.panel1.TabIndex = 0;
            // 
            // label_checking_ytdlp
            // 
            this.label_checking_ytdlp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_checking_ytdlp.AutoSize = true;
            this.label_checking_ytdlp.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_checking_ytdlp.Location = new System.Drawing.Point(341, 0);
            this.label_checking_ytdlp.Name = "label_checking_ytdlp";
            this.label_checking_ytdlp.Size = new System.Drawing.Size(59, 41);
            this.label_checking_ytdlp.TabIndex = 5;
            this.label_checking_ytdlp.Text = "❌";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Downloading FFmpeg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Downloading yt-dlp";
            // 
            // label_checking_ffmpeg
            // 
            this.label_checking_ffmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_checking_ffmpeg.AutoSize = true;
            this.label_checking_ffmpeg.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_checking_ffmpeg.Location = new System.Drawing.Point(341, 59);
            this.label_checking_ffmpeg.Name = "label_checking_ffmpeg";
            this.label_checking_ffmpeg.Size = new System.Drawing.Size(59, 41);
            this.label_checking_ffmpeg.TabIndex = 6;
            this.label_checking_ffmpeg.Text = "❌";
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_main.ColumnCount = 2;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.64433F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.35567F));
            this.tableLayoutPanel_main.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel_main.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel_main.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel_main.Controls.Add(this.checkBox_segment, 1, 2);
            this.tableLayoutPanel_main.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel_main.Controls.Add(this.textBox_youtube, 1, 1);
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel_main.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel_main.MinimumSize = new System.Drawing.Size(190, 0);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 3;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(776, 114);
            this.tableLayoutPanel_main.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.90814F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.09185F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_outputDirectory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_folder, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(199, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 38);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // textBox_outputDirectory
            // 
            this.textBox_outputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_outputDirectory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_outputDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_outputDirectory.Location = new System.Drawing.Point(3, 3);
            this.textBox_outputDirectory.Name = "textBox_outputDirectory";
            this.textBox_outputDirectory.Size = new System.Drawing.Size(507, 32);
            this.textBox_outputDirectory.TabIndex = 1;
            this.textBox_outputDirectory.TabStop = false;
            this.textBox_outputDirectory.DoubleClick += new System.EventHandler(this.button_folder_Click);
            this.textBox_outputDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // button_folder
            // 
            this.button_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_folder.Font = new System.Drawing.Font("Segoe UI Emoji", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_folder.Location = new System.Drawing.Point(516, 3);
            this.button_folder.Name = "button_folder";
            this.button_folder.Size = new System.Drawing.Size(58, 32);
            this.button_folder.TabIndex = 1;
            this.button_folder.TabStop = false;
            this.button_folder.Text = "📂 Folder";
            this.button_folder.UseMnemonic = false;
            this.button_folder.UseVisualStyleBackColor = true;
            this.button_folder.Click += new System.EventHandler(this.button_folder_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Segment";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Output Directory";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_segment
            // 
            this.checkBox_segment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_segment.AutoSize = true;
            this.checkBox_segment.Checked = true;
            this.checkBox_segment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_segment.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.91304F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_segment.Location = new System.Drawing.Point(202, 88);
            this.checkBox_segment.Name = "checkBox_segment";
            this.checkBox_segment.Size = new System.Drawing.Size(15, 14);
            this.checkBox_segment.TabIndex = 3;
            this.checkBox_segment.UseVisualStyleBackColor = true;
            this.checkBox_segment.CheckedChanged += new System.EventHandler(this.checkBox_segment_CheckedChanged);
            this.checkBox_segment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Youtube Link";
            // 
            // textBox_youtube
            // 
            this.textBox_youtube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_youtube.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_youtube.Location = new System.Drawing.Point(202, 41);
            this.textBox_youtube.Name = "textBox_youtube";
            this.textBox_youtube.PlaceholderText = "https://youtu.be/......";
            this.textBox_youtube.Size = new System.Drawing.Size(571, 32);
            this.textBox_youtube.TabIndex = 2;
            this.textBox_youtube.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // tableLayoutPanel_segment
            // 
            this.tableLayoutPanel_segment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_segment.ColumnCount = 2;
            this.tableLayoutPanel_segment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.64433F));
            this.tableLayoutPanel_segment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.35567F));
            this.tableLayoutPanel_segment.Controls.Add(this.textBox_end, 1, 1);
            this.tableLayoutPanel_segment.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel_segment.Controls.Add(this.textBox_start, 1, 0);
            this.tableLayoutPanel_segment.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel_segment.Location = new System.Drawing.Point(12, 126);
            this.tableLayoutPanel_segment.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel_segment.MinimumSize = new System.Drawing.Size(190, 0);
            this.tableLayoutPanel_segment.Name = "tableLayoutPanel_segment";
            this.tableLayoutPanel_segment.RowCount = 2;
            this.tableLayoutPanel_segment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_segment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_segment.Size = new System.Drawing.Size(776, 76);
            this.tableLayoutPanel_segment.TabIndex = 2;
            // 
            // textBox_end
            // 
            this.textBox_end.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_end.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_end.Location = new System.Drawing.Point(202, 41);
            this.textBox_end.Name = "textBox_end";
            this.textBox_end.PlaceholderText = "00:00:00.000";
            this.textBox_end.Size = new System.Drawing.Size(123, 32);
            this.textBox_end.TabIndex = 5;
            this.textBox_end.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "End";
            // 
            // textBox_start
            // 
            this.textBox_start.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_start.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_start.Location = new System.Drawing.Point(202, 3);
            this.textBox_start.Name = "textBox_start";
            this.textBox_start.PlaceholderText = "00:00:00.000";
            this.textBox_start.Size = new System.Drawing.Size(123, 32);
            this.textBox_start.TabIndex = 4;
            this.textBox_start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_start.Location = new System.Drawing.Point(606, 205);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(182, 108);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "Start";
            this.button_start.UseMnemonic = false;
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // panel_download
            // 
            this.panel_download.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_download.BackColor = System.Drawing.SystemColors.Control;
            this.panel_download.Controls.Add(this.richTextBox2);
            this.panel_download.Controls.Add(this.panel1);
            this.panel_download.Location = new System.Drawing.Point(0, 0);
            this.panel_download.Name = "panel_download";
            this.panel_download.Size = new System.Drawing.Size(800, 520);
            this.panel_download.TabIndex = 6;
            this.panel_download.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(19, 290);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 6);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(762, 215);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            this.richTextBox2.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox_LinkClicked);
            // 
            // richTextBox_license
            // 
            this.richTextBox_license.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_license.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_license.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_license.Enabled = false;
            this.richTextBox_license.Location = new System.Drawing.Point(609, 442);
            this.richTextBox_license.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox_license.Name = "richTextBox_license";
            this.richTextBox_license.ReadOnly = true;
            this.richTextBox_license.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_license.Size = new System.Drawing.Size(179, 69);
            this.richTextBox_license.TabIndex = 5;
            this.richTextBox_license.TabStop = false;
            this.richTextBox_license.Text = "This software is distributed under GPLv3.\nAuthor: jim60105";
            // 
            // richTextBoxLogControl1
            // 
            this.richTextBoxLogControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLogControl1.Font = new System.Drawing.Font("Consolas", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxLogControl1.ForContext = "";
            this.richTextBoxLogControl1.Location = new System.Drawing.Point(12, 205);
            this.richTextBoxLogControl1.Name = "richTextBoxLogControl1";
            this.richTextBoxLogControl1.ReadOnly = true;
            this.richTextBoxLogControl1.Size = new System.Drawing.Size(588, 275);
            this.richTextBoxLogControl1.TabIndex = 1;
            this.richTextBoxLogControl1.TabStop = false;
            this.richTextBoxLogControl1.Text = "";
            // 
            // checkBox_logVerbose
            // 
            this.checkBox_logVerbose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_logVerbose.AutoSize = true;
            this.checkBox_logVerbose.Location = new System.Drawing.Point(12, 488);
            this.checkBox_logVerbose.Name = "checkBox_logVerbose";
            this.checkBox_logVerbose.Size = new System.Drawing.Size(116, 23);
            this.checkBox_logVerbose.TabIndex = 5;
            this.checkBox_logVerbose.TabStop = false;
            this.checkBox_logVerbose.Text = "Log Verbose";
            this.checkBox_logVerbose.UseVisualStyleBackColor = true;
            this.checkBox_logVerbose.CheckedChanged += new System.EventHandler(this.checkBox_logVerbose_CheckedChanged);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.richTextBox1);
            this.panel_main.Controls.Add(this.checkBox_logVerbose);
            this.panel_main.Controls.Add(this.tableLayoutPanel_main);
            this.panel_main.Controls.Add(this.tableLayoutPanel_segment);
            this.panel_main.Controls.Add(this.button_start);
            this.panel_main.Controls.Add(this.richTextBoxLogControl1);
            this.panel_main.Controls.Add(this.richTextBox_license);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(800, 520);
            this.panel_main.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(137, 489);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(463, 25);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "https://github.com/jim60105/YoutubeSegmentDownloader";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox_LinkClicked);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Output Directory";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            this.folderBrowserDialog1.UseDescriptionForTitle = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.panel_download);
            this.Controls.Add(this.panel_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Youtube Segment Downloader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.tableLayoutPanel_main.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel_segment.ResumeLayout(false);
            this.tableLayoutPanel_segment.PerformLayout();
            this.panel_download.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label_checking_ytdlp;
        private Label label2;
        private Label label1;
        private Label label_checking_ffmpeg;
        private TableLayoutPanel tableLayoutPanel_main;
        private Label label3;
        private TextBox textBox_youtube;
        private Label label4;
        private CheckBox checkBox_segment;
        private TableLayoutPanel tableLayoutPanel_segment;
        private TextBox textBox_start;
        private Label label6;
        private Label label5;
        private TextBox textBox_end;
        private TextBox textBox_outputDirectory;
        private Label label8;
        private Button button_start;
        private Panel panel_download;
        private Serilog.Sinks.WinForms.RichTextBoxLogControl richTextBoxLogControl1;
        private RichTextBox richTextBox_license;
        private CheckBox checkBox_logVerbose;
        private Panel panel_main;
        private FolderBrowserDialog folderBrowserDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button_folder;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}