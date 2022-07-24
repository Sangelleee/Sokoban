namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.player = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.звукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.Label();
            this.box2 = new System.Windows.Forms.Label();
            this.box3 = new System.Windows.Forms.Label();
            this.base1 = new System.Windows.Forms.Label();
            this.base2 = new System.Windows.Forms.Label();
            this.base3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.DeepPink;
            this.player.Location = new System.Drawing.Point(130, 80);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.звукToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // звукToolStripMenuItem
            // 
            this.звукToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.включитьToolStripMenuItem,
            this.выключитьToolStripMenuItem});
            this.звукToolStripMenuItem.Name = "звукToolStripMenuItem";
            this.звукToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.звукToolStripMenuItem.Text = "Звук";
            // 
            // включитьToolStripMenuItem
            // 
            this.включитьToolStripMenuItem.Name = "включитьToolStripMenuItem";
            this.включитьToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.включитьToolStripMenuItem.Text = "Включить";
            this.включитьToolStripMenuItem.Click += new System.EventHandler(this.включитьToolStripMenuItem_Click);
            // 
            // выключитьToolStripMenuItem
            // 
            this.выключитьToolStripMenuItem.Name = "выключитьToolStripMenuItem";
            this.выключитьToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.выключитьToolStripMenuItem.Text = "Выключить";
            this.выключитьToolStripMenuItem.Click += new System.EventHandler(this.выключитьToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Звук включен";
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.Peru;
            this.box1.Location = new System.Drawing.Point(486, 181);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(50, 50);
            this.box1.TabIndex = 0;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.Peru;
            this.box2.Location = new System.Drawing.Point(384, 80);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(50, 50);
            this.box2.TabIndex = 3;
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.Color.Peru;
            this.box3.Location = new System.Drawing.Point(283, 282);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(50, 50);
            this.box3.TabIndex = 4;
            // 
            // base1
            // 
            this.base1.BackColor = System.Drawing.Color.Black;
            this.base1.Location = new System.Drawing.Point(503, 45);
            this.base1.Name = "base1";
            this.base1.Size = new System.Drawing.Size(20, 20);
            this.base1.TabIndex = 5;
            // 
            // base2
            // 
            this.base2.BackColor = System.Drawing.Color.Black;
            this.base2.Location = new System.Drawing.Point(553, 45);
            this.base2.Name = "base2";
            this.base2.Size = new System.Drawing.Size(20, 20);
            this.base2.TabIndex = 6;
            // 
            // base3
            // 
            this.base3.BackColor = System.Drawing.Color.Black;
            this.base3.Location = new System.Drawing.Point(603, 45);
            this.base3.Name = "base3";
            this.base3.Size = new System.Drawing.Size(20, 20);
            this.base3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.yep;
            this.ClientSize = new System.Drawing.Size(802, 473);
            this.Controls.Add(this.base3);
            this.Controls.Add(this.base2);
            this.Controls.Add(this.base1);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem звукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключитьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label box1;
        private System.Windows.Forms.Label box2;
        private System.Windows.Forms.Label box3;
        private System.Windows.Forms.Label base1;
        private System.Windows.Forms.Label base2;
        private System.Windows.Forms.Label base3;
    }
}

