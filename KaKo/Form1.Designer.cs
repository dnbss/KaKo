namespace KaKo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.описаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_CONS = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_RED = new System.Windows.Forms.ToolStripMenuItem();
            this.директивыРасчётаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_CALC = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_INTERNET = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_F = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_IO = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_PRIV = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_SYS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.описаниеToolStripMenuItem,
            this.ID_RED,
            this.директивыРасчётаToolStripMenuItem,
            this.ID_CALC,
            this.ID_INTERNET,
            this.видToolStripMenuItem,
            this.ID_EXIT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // описаниеToolStripMenuItem
            // 
            this.описаниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_CONS,
            this.ID_FILE});
            this.описаниеToolStripMenuItem.Name = "описаниеToolStripMenuItem";
            this.описаниеToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.описаниеToolStripMenuItem.Text = "Описание";
            // 
            // ID_CONS
            // 
            this.ID_CONS.Name = "ID_CONS";
            this.ID_CONS.Size = new System.Drawing.Size(224, 26);
            this.ID_CONS.Text = "Ввод с клавиатуры";
            // 
            // ID_FILE
            // 
            this.ID_FILE.Name = "ID_FILE";
            this.ID_FILE.Size = new System.Drawing.Size(224, 26);
            this.ID_FILE.Text = "Ввод из файла";
            // 
            // ID_RED
            // 
            this.ID_RED.Name = "ID_RED";
            this.ID_RED.Size = new System.Drawing.Size(137, 24);
            this.ID_RED.Text = "Редактирование";
            // 
            // директивыРасчётаToolStripMenuItem
            // 
            this.директивыРасчётаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_F,
            this.ID_IO});
            this.директивыРасчётаToolStripMenuItem.Name = "директивыРасчётаToolStripMenuItem";
            this.директивыРасчётаToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.директивыРасчётаToolStripMenuItem.Text = "Директивы расчёта";
            // 
            // ID_CALC
            // 
            this.ID_CALC.Name = "ID_CALC";
            this.ID_CALC.Size = new System.Drawing.Size(68, 24);
            this.ID_CALC.Text = "Расчёт";
            // 
            // ID_INTERNET
            // 
            this.ID_INTERNET.Name = "ID_INTERNET";
            this.ID_INTERNET.Size = new System.Drawing.Size(89, 24);
            this.ID_INTERNET.Text = "Интернет";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_PRIV,
            this.ID_SYS});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // ID_EXIT
            // 
            this.ID_EXIT.Name = "ID_EXIT";
            this.ID_EXIT.Size = new System.Drawing.Size(67, 24);
            this.ID_EXIT.Text = "Выход";
            this.ID_EXIT.Click += new System.EventHandler(this.ID_EXIT_Click);
            // 
            // ID_F
            // 
            this.ID_F.Name = "ID_F";
            this.ID_F.Size = new System.Drawing.Size(306, 26);
            this.ID_F.Text = "Вид частотной характеристики";
            // 
            // ID_IO
            // 
            this.ID_IO.Name = "ID_IO";
            this.ID_IO.Size = new System.Drawing.Size(306, 26);
            this.ID_IO.Text = "Вх/вых узлы";
            // 
            // ID_PRIV
            // 
            this.ID_PRIV.Name = "ID_PRIV";
            this.ID_PRIV.Size = new System.Drawing.Size(247, 26);
            this.ID_PRIV.Text = "Собственный браузер";
            // 
            // ID_SYS
            // 
            this.ID_SYS.Name = "ID_SYS";
            this.ID_SYS.Size = new System.Drawing.Size(247, 26);
            this.ID_SYS.Text = "Системный браузер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Моделирование непрерывных систем";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem описаниеToolStripMenuItem;
        private ToolStripMenuItem ID_CONS;
        private ToolStripMenuItem ID_FILE;
        private ToolStripMenuItem ID_RED;
        private ToolStripMenuItem директивыРасчётаToolStripMenuItem;
        private ToolStripMenuItem ID_F;
        private ToolStripMenuItem ID_IO;
        private ToolStripMenuItem ID_CALC;
        private ToolStripMenuItem ID_INTERNET;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem ID_PRIV;
        private ToolStripMenuItem ID_SYS;
        private ToolStripMenuItem ID_EXIT;
    }
}