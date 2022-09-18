
namespace GroupsMaker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popsicleSticksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceSticksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.presentStudentsLabel = new System.Windows.Forms.Label();
            this.presentStudents = new System.Windows.Forms.ListBox();
            this.markAllAbsentBtn = new System.Windows.Forms.Button();
            this.markSelAbsentBtn = new System.Windows.Forms.Button();
            this.absentStudents = new System.Windows.Forms.ListBox();
            this.absentStudentsLabel = new System.Windows.Forms.Label();
            this.markAllPresentBtn = new System.Windows.Forms.Button();
            this.markSelPresentBtn = new System.Windows.Forms.Button();
            this.popsicleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.popsicleStickPulled = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.popTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearTip = new System.Windows.Forms.ToolTip(this.components);
            this.buddyTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupsTip = new System.Windows.Forms.ToolTip(this.components);
            this.showLastCalledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buddyview = new System.Windows.Forms.DataGridView();
            this.buddyTalkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLastPartnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.header1 = new System.Windows.Forms.PictureBox();
            this.header2 = new System.Windows.Forms.PictureBox();
            this.changeHeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peanutButterJellyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chipsAndSalsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frybreadAndStewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baconAndEggsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buddyview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.popsicleSticksToolStripMenuItem,
            this.buddyTalkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadStudentsToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "&Students";
            // 
            // loadStudentsToolStripMenuItem
            // 
            this.loadStudentsToolStripMenuItem.Name = "loadStudentsToolStripMenuItem";
            this.loadStudentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadStudentsToolStripMenuItem.Text = "&Load Students";
            this.loadStudentsToolStripMenuItem.Click += new System.EventHandler(this.loadStudentsToolStripMenuItem_Click);
            // 
            // popsicleSticksToolStripMenuItem
            // 
            this.popsicleSticksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceSticksToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showLastCalledToolStripMenuItem});
            this.popsicleSticksToolStripMenuItem.Name = "popsicleSticksToolStripMenuItem";
            this.popsicleSticksToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.popsicleSticksToolStripMenuItem.Text = "&Popsicle Sticks";
            // 
            // replaceSticksToolStripMenuItem
            // 
            this.replaceSticksToolStripMenuItem.Name = "replaceSticksToolStripMenuItem";
            this.replaceSticksToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.replaceSticksToolStripMenuItem.Text = "&Replace Sticks Each Time";
            this.replaceSticksToolStripMenuItem.Click += new System.EventHandler(this.replaceSticksToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.toolStripMenuItem1.Text = "&All Sticks Back In Now";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // presentStudentsLabel
            // 
            this.presentStudentsLabel.AutoSize = true;
            this.presentStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentStudentsLabel.Location = new System.Drawing.Point(4, 115);
            this.presentStudentsLabel.Name = "presentStudentsLabel";
            this.presentStudentsLabel.Size = new System.Drawing.Size(104, 13);
            this.presentStudentsLabel.TabIndex = 1;
            this.presentStudentsLabel.Text = "Present Students";
            // 
            // presentStudents
            // 
            this.presentStudents.FormattingEnabled = true;
            this.presentStudents.Location = new System.Drawing.Point(7, 131);
            this.presentStudents.Name = "presentStudents";
            this.presentStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.presentStudents.Size = new System.Drawing.Size(130, 368);
            this.presentStudents.TabIndex = 2;
            this.presentStudents.TabStop = false;
            // 
            // markAllAbsentBtn
            // 
            this.markAllAbsentBtn.Location = new System.Drawing.Point(7, 505);
            this.markAllAbsentBtn.Name = "markAllAbsentBtn";
            this.markAllAbsentBtn.Size = new System.Drawing.Size(107, 23);
            this.markAllAbsentBtn.TabIndex = 3;
            this.markAllAbsentBtn.Text = "Mark All Absent";
            this.markAllAbsentBtn.UseVisualStyleBackColor = true;
            this.markAllAbsentBtn.Click += new System.EventHandler(this.markAllAbsentBtn_Click);
            // 
            // markSelAbsentBtn
            // 
            this.markSelAbsentBtn.Location = new System.Drawing.Point(7, 534);
            this.markSelAbsentBtn.Name = "markSelAbsentBtn";
            this.markSelAbsentBtn.Size = new System.Drawing.Size(130, 23);
            this.markSelAbsentBtn.TabIndex = 4;
            this.markSelAbsentBtn.Text = "Mark Selected Absent";
            this.markSelAbsentBtn.UseVisualStyleBackColor = true;
            this.markSelAbsentBtn.Click += new System.EventHandler(this.markSelAbsentBtn_Click);
            // 
            // absentStudents
            // 
            this.absentStudents.FormattingEnabled = true;
            this.absentStudents.Location = new System.Drawing.Point(7, 622);
            this.absentStudents.Name = "absentStudents";
            this.absentStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.absentStudents.Size = new System.Drawing.Size(130, 69);
            this.absentStudents.TabIndex = 5;
            this.absentStudents.TabStop = false;
            // 
            // absentStudentsLabel
            // 
            this.absentStudentsLabel.AutoSize = true;
            this.absentStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absentStudentsLabel.Location = new System.Drawing.Point(4, 596);
            this.absentStudentsLabel.Name = "absentStudentsLabel";
            this.absentStudentsLabel.Size = new System.Drawing.Size(112, 13);
            this.absentStudentsLabel.TabIndex = 6;
            this.absentStudentsLabel.Text = "Absent Students:  ";
            // 
            // markAllPresentBtn
            // 
            this.markAllPresentBtn.Location = new System.Drawing.Point(7, 697);
            this.markAllPresentBtn.Name = "markAllPresentBtn";
            this.markAllPresentBtn.Size = new System.Drawing.Size(120, 23);
            this.markAllPresentBtn.TabIndex = 7;
            this.markAllPresentBtn.Text = "Mark All Present";
            this.markAllPresentBtn.UseVisualStyleBackColor = true;
            this.markAllPresentBtn.Click += new System.EventHandler(this.markAllPresentBtn_Click);
            // 
            // markSelPresentBtn
            // 
            this.markSelPresentBtn.Location = new System.Drawing.Point(7, 726);
            this.markSelPresentBtn.Name = "markSelPresentBtn";
            this.markSelPresentBtn.Size = new System.Drawing.Size(135, 23);
            this.markSelPresentBtn.TabIndex = 8;
            this.markSelPresentBtn.Text = "Mark Selected Present";
            this.markSelPresentBtn.UseVisualStyleBackColor = true;
            this.markSelPresentBtn.Click += new System.EventHandler(this.markSelPresentBtn_Click_1);
            // 
            // popsicleBtn
            // 
            this.popsicleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("popsicleBtn.BackgroundImage")));
            this.popsicleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.popsicleBtn.FlatAppearance.BorderSize = 3;
            this.popsicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.popsicleBtn.Location = new System.Drawing.Point(28, 27);
            this.popsicleBtn.Name = "popsicleBtn";
            this.popsicleBtn.Size = new System.Drawing.Size(80, 80);
            this.popsicleBtn.TabIndex = 0;
            this.popTip.SetToolTip(this.popsicleBtn, "Click to pull the next popsicle stick");
            this.popsicleBtn.UseVisualStyleBackColor = true;
            this.popsicleBtn.Click += new System.EventHandler(this.popsicleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(351, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // popsicleStickPulled
            // 
            this.popsicleStickPulled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.popsicleStickPulled.BackColor = System.Drawing.Color.Transparent;
            this.popsicleStickPulled.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popsicleStickPulled.Image = ((System.Drawing.Image)(resources.GetObject("popsicleStickPulled.Image")));
            this.popsicleStickPulled.Location = new System.Drawing.Point(208, 292);
            this.popsicleStickPulled.Name = "popsicleStickPulled";
            this.popsicleStickPulled.Size = new System.Drawing.Size(803, 207);
            this.popsicleStickPulled.TabIndex = 11;
            this.popsicleStickPulled.Text = "Student";
            this.popsicleStickPulled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.popsicleStickPulled.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(139, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 12;
            this.buddyTip.SetToolTip(this.button1, "Click to generate partners for buddy talk.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(239, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 13;
            this.groupsTip.SetToolTip(this.button2, "Click to generate groups");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearBtn.FlatAppearance.BorderSize = 3;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.Location = new System.Drawing.Point(339, 27);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(80, 80);
            this.clearBtn.TabIndex = 14;
            this.clearTip.SetToolTip(this.clearBtn, "Click to clear the display area.");
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // popTip
            // 
            this.popTip.ToolTipTitle = "Popsicle Sticks";
            // 
            // clearTip
            // 
            this.clearTip.ToolTipTitle = "Clear the Board";
            // 
            // buddyTip
            // 
            this.buddyTip.ToolTipTitle = "Buddy Talk";
            // 
            // groupsTip
            // 
            this.groupsTip.ToolTipTitle = "Groups Maker";
            // 
            // showLastCalledToolStripMenuItem
            // 
            this.showLastCalledToolStripMenuItem.Name = "showLastCalledToolStripMenuItem";
            this.showLastCalledToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.showLastCalledToolStripMenuItem.Text = "&Show Last Called";
            this.showLastCalledToolStripMenuItem.Click += new System.EventHandler(this.showLastCalledToolStripMenuItem_Click);
            // 
            // buddyview
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buddyview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.buddyview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buddyview.DefaultCellStyle = dataGridViewCellStyle14;
            this.buddyview.Location = new System.Drawing.Point(202, 231);
            this.buddyview.Name = "buddyview";
            this.buddyview.Size = new System.Drawing.Size(816, 541);
            this.buddyview.TabIndex = 15;
            this.buddyview.Visible = false;
            // 
            // buddyTalkToolStripMenuItem
            // 
            this.buddyTalkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLastPartnersToolStripMenuItem,
            this.changeHeadersToolStripMenuItem});
            this.buddyTalkToolStripMenuItem.Name = "buddyTalkToolStripMenuItem";
            this.buddyTalkToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.buddyTalkToolStripMenuItem.Text = "&Buddy Talk";
            this.buddyTalkToolStripMenuItem.Click += new System.EventHandler(this.buddyTalkToolStripMenuItem_Click);
            // 
            // showLastPartnersToolStripMenuItem
            // 
            this.showLastPartnersToolStripMenuItem.Name = "showLastPartnersToolStripMenuItem";
            this.showLastPartnersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showLastPartnersToolStripMenuItem.Text = "&Show Last Partners";
            this.showLastPartnersToolStripMenuItem.Click += new System.EventHandler(this.showLastPartnersToolStripMenuItem_Click);
            // 
            // header1
            // 
            this.header1.Image = ((System.Drawing.Image)(resources.GetObject("header1.Image")));
            this.header1.Location = new System.Drawing.Point(319, 131);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(90, 90);
            this.header1.TabIndex = 16;
            this.header1.TabStop = false;
            this.header1.Visible = false;
            // 
            // header2
            // 
            this.header2.Image = ((System.Drawing.Image)(resources.GetObject("header2.Image")));
            this.header2.Location = new System.Drawing.Point(776, 131);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(90, 90);
            this.header2.TabIndex = 17;
            this.header2.TabStop = false;
            this.header2.Visible = false;
            // 
            // changeHeadersToolStripMenuItem
            // 
            this.changeHeadersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peanutButterJellyToolStripMenuItem,
            this.chipsAndSalsaToolStripMenuItem,
            this.frybreadAndStewToolStripMenuItem,
            this.baconAndEggsToolStripMenuItem});
            this.changeHeadersToolStripMenuItem.Name = "changeHeadersToolStripMenuItem";
            this.changeHeadersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeHeadersToolStripMenuItem.Text = "&Change Headers";
            // 
            // peanutButterJellyToolStripMenuItem
            // 
            this.peanutButterJellyToolStripMenuItem.Name = "peanutButterJellyToolStripMenuItem";
            this.peanutButterJellyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.peanutButterJellyToolStripMenuItem.Text = "&Peanut Butter and Jelly";
            this.peanutButterJellyToolStripMenuItem.Click += new System.EventHandler(this.peanutButterJellyToolStripMenuItem_Click);
            // 
            // chipsAndSalsaToolStripMenuItem
            // 
            this.chipsAndSalsaToolStripMenuItem.Name = "chipsAndSalsaToolStripMenuItem";
            this.chipsAndSalsaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.chipsAndSalsaToolStripMenuItem.Text = "&Chips and Salsa";
            this.chipsAndSalsaToolStripMenuItem.Click += new System.EventHandler(this.chipsAndSalsaToolStripMenuItem_Click);
            // 
            // frybreadAndStewToolStripMenuItem
            // 
            this.frybreadAndStewToolStripMenuItem.Name = "frybreadAndStewToolStripMenuItem";
            this.frybreadAndStewToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.frybreadAndStewToolStripMenuItem.Text = "&Frybread and Stew";
            this.frybreadAndStewToolStripMenuItem.Click += new System.EventHandler(this.frybreadAndStewToolStripMenuItem_Click);
            // 
            // baconAndEggsToolStripMenuItem
            // 
            this.baconAndEggsToolStripMenuItem.Name = "baconAndEggsToolStripMenuItem";
            this.baconAndEggsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.baconAndEggsToolStripMenuItem.Text = "&Bacon and Eggs";
            this.baconAndEggsToolStripMenuItem.Click += new System.EventHandler(this.baconAndEggsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 811);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.buddyview);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.popsicleStickPulled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.popsicleBtn);
            this.Controls.Add(this.markSelPresentBtn);
            this.Controls.Add(this.markAllPresentBtn);
            this.Controls.Add(this.absentStudentsLabel);
            this.Controls.Add(this.absentStudents);
            this.Controls.Add(this.markSelAbsentBtn);
            this.Controls.Add(this.markAllAbsentBtn);
            this.Controls.Add(this.presentStudents);
            this.Controls.Add(this.presentStudentsLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buddyview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadStudentsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Label presentStudentsLabel;
        internal System.Windows.Forms.ListBox presentStudents;
        private System.Windows.Forms.Button markAllAbsentBtn;
        private System.Windows.Forms.Button markSelAbsentBtn;
        internal System.Windows.Forms.ListBox absentStudents;
        private System.Windows.Forms.Button markAllPresentBtn;
        private System.Windows.Forms.Button markSelPresentBtn;
        internal System.Windows.Forms.Label absentStudentsLabel;
        private System.Windows.Forms.Button popsicleBtn;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label popsicleStickPulled;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ToolStripMenuItem popsicleSticksToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem replaceSticksToolStripMenuItem;
        private System.Windows.Forms.ToolTip popTip;
        private System.Windows.Forms.ToolTip buddyTip;
        private System.Windows.Forms.ToolTip groupsTip;
        private System.Windows.Forms.ToolTip clearTip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showLastCalledToolStripMenuItem;
        internal System.Windows.Forms.DataGridView buddyview;
        private System.Windows.Forms.ToolStripMenuItem buddyTalkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLastPartnersToolStripMenuItem;
        internal System.Windows.Forms.PictureBox header1;
        internal System.Windows.Forms.PictureBox header2;
        private System.Windows.Forms.ToolStripMenuItem changeHeadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peanutButterJellyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chipsAndSalsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frybreadAndStewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baconAndEggsToolStripMenuItem;
    }
}

