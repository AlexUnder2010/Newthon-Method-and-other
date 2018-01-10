using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методНайшвидшогоСпускуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методНайшвидшогоСпускуДляПершоїФункціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методПокоординатногоСпускуМетодомЗейделяГаусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.узагальненийМетодНьютонаДляПошукуДругоїФункціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Точка мінімуму";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методНайшвидшогоСпускуToolStripMenuItem,
            this.методНайшвидшогоСпускуДляПершоїФункціїToolStripMenuItem,
            this.методПокоординатногоСпускуМетодомЗейделяГаусаToolStripMenuItem,
            this.методToolStripMenuItem,
            this.узагальненийМетодНьютонаДляПошукуДругоїФункціїToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // методНайшвидшогоСпускуToolStripMenuItem
            // 
            this.методНайшвидшогоСпускуToolStripMenuItem.Name = "методНайшвидшогоСпускуToolStripMenuItem";
            this.методНайшвидшогоСпускуToolStripMenuItem.Size = new System.Drawing.Size(602, 22);
            this.методНайшвидшогоСпускуToolStripMenuItem.Text = "Метод найшвидшого спуску для пошуку мінімуму функції Розенброка";
            this.методНайшвидшогоСпускуToolStripMenuItem.Click += new System.EventHandler(this.методНайшвидшогоСпускуToolStripMenuItem_Click_1);
            // 
            // методНайшвидшогоСпускуДляПершоїФункціїToolStripMenuItem
            // 
            this.методНайшвидшогоСпускуДляПершоїФункціїToolStripMenuItem.Name = "методНайшвидшогоСпускуДляПершоїФункціїToolStripMenuItem";
            this.методНайшвидшогоСпускуДляПершоїФункціїToolStripMenuItem.Size = new System.Drawing.Size(602, 22);
            this.методНайшвидшогоСпускуДляПершоїФункціїToolStripMenuItem.Text = "Метод найшвидшого спуску для пошуку мінімуму першої функції";
            this.методНайшвидшогоСпускуДляПершоїФункціїToolStripMenuItem.Click += new System.EventHandler(this.методНайшвидшогоСпускуДляПершоїФункціїToolStripMenuItem_Click);
            // 
            // методПокоординатногоСпускуМетодомЗейделяГаусаToolStripMenuItem
            // 
            this.методПокоординатногоСпускуМетодомЗейделяГаусаToolStripMenuItem.Name = "методПокоординатногоСпускуМетодомЗейделяГаусаToolStripMenuItem";
            this.методПокоординатногоСпускуМетодомЗейделяГаусаToolStripMenuItem.Size = new System.Drawing.Size(602, 22);
            this.методПокоординатногоСпускуМетодомЗейделяГаусаToolStripMenuItem.Text = "Метод покоординатного спуску методом Зейделя - Гауса для пошуку мінімуму першої ф" +
    "ункції";
            this.методПокоординатногоСпускуМетодомЗейделяГаусаToolStripMenuItem.Click += new System.EventHandler(this.методПокоординатногоСпускуМетодомЗейделяГаусаToolStripMenuItem_Click);
            // 
            // методToolStripMenuItem
            // 
            this.методToolStripMenuItem.Name = "методToolStripMenuItem";
            this.методToolStripMenuItem.Size = new System.Drawing.Size(602, 22);
            this.методToolStripMenuItem.Text = "Метод Ньютона для пошуку мінімуму другої функції";
            this.методToolStripMenuItem.Click += new System.EventHandler(this.методToolStripMenuItem_Click);
            // 
            // узагальненийМетодНьютонаДляПошукуДругоїФункціїToolStripMenuItem
            // 
            this.узагальненийМетодНьютонаДляПошукуДругоїФункціїToolStripMenuItem.Name = "узагальненийМетодНьютонаДляПошукуДругоїФункціїToolStripMenuItem";
            this.узагальненийМетодНьютонаДляПошукуДругоїФункціїToolStripMenuItem.Size = new System.Drawing.Size(602, 22);
            this.узагальненийМетодНьютонаДляПошукуДругоїФункціїToolStripMenuItem.Text = "Узагальнений метод ньютона для пошуку другої функції";
            this.узагальненийМетодНьютонаДляПошукуДругоїФункціїToolStripMenuItem.Click += new System.EventHandler(this.узагальненийМетодНьютонаДляПошукуДругоїФункціїToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Функція в точці";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Викликів функції";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(268, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ітерацій";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(268, 20);
            this.textBox4.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0,001",
            "0,0001",
            "0,00001",
            "0,000001"});
            this.comboBox1.Location = new System.Drawing.Point(15, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "0,0001";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 129);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результати";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(402, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 53);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Точність";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 163);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторна робота 4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem методНайшвидшогоСпускуToolStripMenuItem;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private ToolStripMenuItem методНайшвидшогоСпускуДляПершоїФункціїToolStripMenuItem;
        private ToolStripMenuItem методПокоординатногоСпускуМетодомЗейделяГаусаToolStripMenuItem;
        private ToolStripMenuItem методToolStripMenuItem;
        private ToolStripMenuItem узагальненийМетодНьютонаДляПошукуДругоїФункціїToolStripMenuItem;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStripMenuItem вихідToolStripMenuItem;
    }
}

