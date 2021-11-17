
namespace Свой_тип
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
            this.task = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Label();
            this.heading1 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.volume1 = new System.Windows.Forms.TextBox();
            this.type1 = new System.Windows.Forms.ComboBox();
            this.type2 = new System.Windows.Forms.ComboBox();
            this.volume2 = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.ComboBox();
            this.text2 = new System.Windows.Forms.Label();
            this.header2 = new System.Windows.Forms.Label();
            this.type4 = new System.Windows.Forms.ComboBox();
            this.volume4 = new System.Windows.Forms.TextBox();
            this.type3 = new System.Windows.Forms.ComboBox();
            this.volume3 = new System.Windows.Forms.TextBox();
            this.equals = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // task
            // 
            this.task.AutoSize = true;
            this.task.Font = new System.Drawing.Font("Gotham Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task.Location = new System.Drawing.Point(19, 20);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(400, 45);
            this.task.TabIndex = 0;
            this.task.Text = "Перевод объёмов";
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about.Location = new System.Drawing.Point(24, 81);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(550, 100);
            this.about.TabIndex = 1;
            this.about.Text = "Данный калькулятор реализует перевод из одной меры объёма в другую. Также можно п" +
    "роизводить математические преобразования и сравнивать два значения.";
            // 
            // heading1
            // 
            this.heading1.AutoSize = true;
            this.heading1.Font = new System.Drawing.Font("Gotham Pro Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heading1.Location = new System.Drawing.Point(22, 208);
            this.heading1.Name = "heading1";
            this.heading1.Size = new System.Drawing.Size(207, 30);
            this.heading1.TabIndex = 2;
            this.heading1.Text = "Калькулятор";
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.Location = new System.Drawing.Point(23, 253);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(550, 54);
            this.text1.TabIndex = 3;
            this.text1.Text = "Произведение математический преобразований с одним или двумя значениями.";
            // 
            // volume1
            // 
            this.volume1.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volume1.Location = new System.Drawing.Point(27, 320);
            this.volume1.Margin = new System.Windows.Forms.Padding(10);
            this.volume1.Name = "volume1";
            this.volume1.Size = new System.Drawing.Size(120, 30);
            this.volume1.TabIndex = 4;
            this.volume1.Text = "100";
            this.volume1.TextChanged += new System.EventHandler(this.ChangeActive);
            // 
            // type1
            // 
            this.type1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.type1.Font = new System.Drawing.Font("Gotham Pro Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type1.FormattingEnabled = true;
            this.type1.Items.AddRange(new object[] {
            "м^3",
            "мл",
            "л",
            "бр",
            "ам"});
            this.type1.Location = new System.Drawing.Point(156, 320);
            this.type1.Margin = new System.Windows.Forms.Padding(10);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(70, 30);
            this.type1.TabIndex = 5;
            this.type1.Text = "м^3";
            this.type1.SelectedIndexChanged += new System.EventHandler(this.ChangeActive);
            // 
            // type2
            // 
            this.type2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.type2.Font = new System.Drawing.Font("Gotham Pro Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type2.FormattingEnabled = true;
            this.type2.Items.AddRange(new object[] {
            "м^3",
            "мл",
            "л",
            "бр",
            "ам"});
            this.type2.Location = new System.Drawing.Point(498, 320);
            this.type2.Margin = new System.Windows.Forms.Padding(10);
            this.type2.Name = "type2";
            this.type2.Size = new System.Drawing.Size(70, 30);
            this.type2.TabIndex = 7;
            this.type2.Text = "м^3";
            this.type2.SelectedIndexChanged += new System.EventHandler(this.ChangeActive);
            // 
            // volume2
            // 
            this.volume2.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volume2.Location = new System.Drawing.Point(371, 320);
            this.volume2.Margin = new System.Windows.Forms.Padding(10);
            this.volume2.Name = "volume2";
            this.volume2.Size = new System.Drawing.Size(120, 30);
            this.volume2.TabIndex = 6;
            this.volume2.Text = "100";
            this.volume2.TextChanged += new System.EventHandler(this.ChangeActive);
            // 
            // operation
            // 
            this.operation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation.Font = new System.Drawing.Font("Gotham Pro Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation.ForeColor = System.Drawing.Color.Black;
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "<>"});
            this.operation.Location = new System.Drawing.Point(263, 320);
            this.operation.Margin = new System.Windows.Forms.Padding(10);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(70, 30);
            this.operation.TabIndex = 8;
            this.operation.Text = "+";
            this.operation.SelectedIndexChanged += new System.EventHandler(this.ChangeActive);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.Location = new System.Drawing.Point(23, 480);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(480, 22);
            this.text2.TabIndex = 10;
            this.text2.Text = "Перевод из одной единицы объема в другую.";
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.Font = new System.Drawing.Font("Gotham Pro Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header2.Location = new System.Drawing.Point(22, 435);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(141, 30);
            this.header2.TabIndex = 9;
            this.header2.Text = "Перевод";
            // 
            // type4
            // 
            this.type4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.type4.Font = new System.Drawing.Font("Gotham Pro Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type4.FormattingEnabled = true;
            this.type4.Items.AddRange(new object[] {
            "м^3",
            "мл",
            "л",
            "бр",
            "ам"});
            this.type4.Location = new System.Drawing.Point(498, 523);
            this.type4.Margin = new System.Windows.Forms.Padding(10);
            this.type4.Name = "type4";
            this.type4.Size = new System.Drawing.Size(70, 30);
            this.type4.TabIndex = 14;
            this.type4.Text = "л";
            this.type4.SelectedIndexChanged += new System.EventHandler(this.TranslateActive);
            // 
            // volume4
            // 
            this.volume4.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volume4.Location = new System.Drawing.Point(325, 523);
            this.volume4.Margin = new System.Windows.Forms.Padding(10);
            this.volume4.Name = "volume4";
            this.volume4.ReadOnly = true;
            this.volume4.Size = new System.Drawing.Size(166, 30);
            this.volume4.TabIndex = 13;
            this.volume4.Text = "1000";
            // 
            // type3
            // 
            this.type3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.type3.Font = new System.Drawing.Font("Gotham Pro Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type3.FormattingEnabled = true;
            this.type3.Items.AddRange(new object[] {
            "м^3",
            "мл",
            "л",
            "бр",
            "ам"});
            this.type3.Location = new System.Drawing.Point(206, 523);
            this.type3.Margin = new System.Windows.Forms.Padding(10);
            this.type3.Name = "type3";
            this.type3.Size = new System.Drawing.Size(70, 30);
            this.type3.TabIndex = 12;
            this.type3.Text = "м^3";
            this.type3.SelectedIndexChanged += new System.EventHandler(this.TranslateActive);
            // 
            // volume3
            // 
            this.volume3.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volume3.Location = new System.Drawing.Point(27, 523);
            this.volume3.Margin = new System.Windows.Forms.Padding(10);
            this.volume3.Name = "volume3";
            this.volume3.Size = new System.Drawing.Size(170, 30);
            this.volume3.TabIndex = 11;
            this.volume3.Text = "1";
            this.volume3.TextChanged += new System.EventHandler(this.TranslateActive);
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equals.Location = new System.Drawing.Point(289, 526);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(23, 22);
            this.equals.TabIndex = 15;
            this.equals.Text = "=";
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res.Location = new System.Drawing.Point(25, 366);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(119, 23);
            this.res.TabIndex = 16;
            this.res.Text = "Результат:";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(144, 366);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(92, 22);
            this.result.TabIndex = 17;
            this.result.Text = "200 м^3";
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Font = new System.Drawing.Font("Gotham Pro Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notes.Location = new System.Drawing.Point(24, 599);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(194, 30);
            this.notes.TabIndex = 18;
            this.notes.Text = "Справочник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "м^3 — метры кубические";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 681);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "л — литры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(323, 681);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "бр — баррели";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(323, 645);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "мл — миллилитры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 716);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "ам — антиматерия";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(601, 765);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.result);
            this.Controls.Add(this.res);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.type4);
            this.Controls.Add(this.volume4);
            this.Controls.Add(this.type3);
            this.Controls.Add(this.volume3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.type2);
            this.Controls.Add(this.volume2);
            this.Controls.Add(this.type1);
            this.Controls.Add(this.volume1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.heading1);
            this.Controls.Add(this.about);
            this.Controls.Add(this.task);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label task;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.Label heading1;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.TextBox volume1;
        private System.Windows.Forms.ComboBox type1;
        private System.Windows.Forms.ComboBox type2;
        private System.Windows.Forms.TextBox volume2;
        private System.Windows.Forms.ComboBox operation;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label header2;
        private System.Windows.Forms.ComboBox type4;
        private System.Windows.Forms.TextBox volume4;
        private System.Windows.Forms.ComboBox type3;
        private System.Windows.Forms.TextBox volume3;
        private System.Windows.Forms.Label equals;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

