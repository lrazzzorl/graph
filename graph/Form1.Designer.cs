namespace graph
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_f = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_T = new System.Windows.Forms.TextBox();
            this.textBox_v0 = new System.Windows.Forms.TextBox();
            this.textBox_tmax = new System.Windows.Forms.TextBox();
            this.textBox_dl = new System.Windows.Forms.TextBox();
            this.textBox_tmin = new System.Windows.Forms.TextBox();
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_speed = new System.Windows.Forms.RadioButton();
            this.radioButton_path = new System.Windows.Forms.RadioButton();
            this.label_B = new System.Windows.Forms.Label();
            this.label_dt = new System.Windows.Forms.Label();
            this.label_w = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.coordLabel = new System.Windows.Forms.Label();
            this.button_save_to_exel = new System.Windows.Forms.Button();
            this.button_save_as_bitmap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(289, 12);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(500, 318);
            this.zedGraph.TabIndex = 0;
            this.zedGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "расчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calculation);
            // 
            // textBox_f
            // 
            this.textBox_f.Location = new System.Drawing.Point(184, 367);
            this.textBox_f.Name = "textBox_f";
            this.textBox_f.Size = new System.Drawing.Size(59, 20);
            this.textBox_f.TabIndex = 56;
            this.textBox_f.Text = "600";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Коэффициент сопротивления f =";
            // 
            // textBox_x0
            // 
            this.textBox_x0.Location = new System.Drawing.Point(182, 243);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.Size = new System.Drawing.Size(59, 20);
            this.textBox_x0.TabIndex = 54;
            this.textBox_x0.Text = "0,006";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Начальное смещение x0 =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Коэффициент затухания B =";
            // 
            // textBox_T
            // 
            this.textBox_T.Location = new System.Drawing.Point(182, 333);
            this.textBox_T.Name = "textBox_T";
            this.textBox_T.Size = new System.Drawing.Size(59, 20);
            this.textBox_T.TabIndex = 50;
            this.textBox_T.Text = "0,18395";
            // 
            // textBox_v0
            // 
            this.textBox_v0.Location = new System.Drawing.Point(182, 275);
            this.textBox_v0.Name = "textBox_v0";
            this.textBox_v0.Size = new System.Drawing.Size(59, 20);
            this.textBox_v0.TabIndex = 48;
            this.textBox_v0.Text = "0";
            // 
            // textBox_tmax
            // 
            this.textBox_tmax.Location = new System.Drawing.Point(182, 135);
            this.textBox_tmax.Name = "textBox_tmax";
            this.textBox_tmax.Size = new System.Drawing.Size(59, 20);
            this.textBox_tmax.TabIndex = 45;
            this.textBox_tmax.Text = "10";
            // 
            // textBox_dl
            // 
            this.textBox_dl.Location = new System.Drawing.Point(182, 215);
            this.textBox_dl.Name = "textBox_dl";
            this.textBox_dl.Size = new System.Drawing.Size(59, 20);
            this.textBox_dl.TabIndex = 47;
            this.textBox_dl.Text = "0,00841";
            // 
            // textBox_tmin
            // 
            this.textBox_tmin.Location = new System.Drawing.Point(182, 109);
            this.textBox_tmin.Name = "textBox_tmin";
            this.textBox_tmin.Size = new System.Drawing.Size(59, 20);
            this.textBox_tmin.TabIndex = 44;
            this.textBox_tmin.Text = "0";
            // 
            // textBox_k
            // 
            this.textBox_k.Location = new System.Drawing.Point(182, 47);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.Size = new System.Drawing.Size(59, 20);
            this.textBox_k.TabIndex = 43;
            this.textBox_k.Text = "3500000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Δ t =";
            // 
            // textBox_m
            // 
            this.textBox_m.Location = new System.Drawing.Point(182, 18);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(59, 20);
            this.textBox_m.TabIndex = 42;
            this.textBox_m.Text = "3000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "t max =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Период колебаний T =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "t min =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Круговая частота w =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Начальная скорость v0 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Временной интервал ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Статическое удлинение  dl =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Жесткость пружины k =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Масса тела m =";
            // 
            // radioButton_speed
            // 
            this.radioButton_speed.AutoSize = true;
            this.radioButton_speed.Checked = true;
            this.radioButton_speed.Location = new System.Drawing.Point(441, 338);
            this.radioButton_speed.Name = "radioButton_speed";
            this.radioButton_speed.Size = new System.Drawing.Size(73, 17);
            this.radioButton_speed.TabIndex = 57;
            this.radioButton_speed.TabStop = true;
            this.radioButton_speed.Text = "Скорость";
            this.radioButton_speed.UseVisualStyleBackColor = true;
            this.radioButton_speed.CheckedChanged += new System.EventHandler(this.Calculation);
            // 
            // radioButton_path
            // 
            this.radioButton_path.AutoSize = true;
            this.radioButton_path.Location = new System.Drawing.Point(569, 340);
            this.radioButton_path.Name = "radioButton_path";
            this.radioButton_path.Size = new System.Drawing.Size(79, 17);
            this.radioButton_path.TabIndex = 58;
            this.radioButton_path.Text = "Смещение";
            this.radioButton_path.UseVisualStyleBackColor = true;
            this.radioButton_path.CheckedChanged += new System.EventHandler(this.Calculation);
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(179, 399);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(13, 13);
            this.label_B.TabIndex = 59;
            this.label_B.Text = "0";
            // 
            // label_dt
            // 
            this.label_dt.AutoSize = true;
            this.label_dt.Location = new System.Drawing.Point(179, 167);
            this.label_dt.Name = "label_dt";
            this.label_dt.Size = new System.Drawing.Size(13, 13);
            this.label_dt.TabIndex = 60;
            this.label_dt.Text = "0";
            // 
            // label_w
            // 
            this.label_w.AutoSize = true;
            this.label_w.Location = new System.Drawing.Point(181, 303);
            this.label_w.Name = "label_w";
            this.label_w.Size = new System.Drawing.Size(13, 13);
            this.label_w.TabIndex = 61;
            this.label_w.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(247, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "кг";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(247, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "Н/м";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(247, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "с";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(247, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 65;
            this.label17.Text = "с";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(247, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 66;
            this.label18.Text = "с";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(247, 222);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 13);
            this.label19.TabIndex = 67;
            this.label19.Text = "м";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(247, 250);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 13);
            this.label20.TabIndex = 68;
            this.label20.Text = "м";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(247, 282);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 69;
            this.label21.Text = "м/с";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(247, 340);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 70;
            this.label22.Text = "с";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(249, 374);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 71;
            this.label23.Text = "кг/с";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(249, 303);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 13);
            this.label24.TabIndex = 72;
            this.label24.Text = "рад/с";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(247, 399);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 13);
            this.label25.TabIndex = 73;
            this.label25.Text = "м-1";
            // 
            // coordLabel
            // 
            this.coordLabel.AutoSize = true;
            this.coordLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.coordLabel.Location = new System.Drawing.Point(313, 303);
            this.coordLabel.Name = "coordLabel";
            this.coordLabel.Size = new System.Drawing.Size(45, 13);
            this.coordLabel.TabIndex = 74;
            this.coordLabel.Text = "X:     Y: ";
            // 
            // button_save_to_exel
            // 
            this.button_save_to_exel.Location = new System.Drawing.Point(677, 376);
            this.button_save_to_exel.Name = "button_save_to_exel";
            this.button_save_to_exel.Size = new System.Drawing.Size(112, 28);
            this.button_save_to_exel.TabIndex = 75;
            this.button_save_to_exel.Text = "сохранить в excel";
            this.button_save_to_exel.UseVisualStyleBackColor = true;
            this.button_save_to_exel.Click += new System.EventHandler(this.save_to_exel_Click);
            // 
            // button_save_as_bitmap
            // 
            this.button_save_as_bitmap.Location = new System.Drawing.Point(677, 410);
            this.button_save_as_bitmap.Name = "button_save_as_bitmap";
            this.button_save_as_bitmap.Size = new System.Drawing.Size(112, 28);
            this.button_save_as_bitmap.TabIndex = 76;
            this.button_save_as_bitmap.Text = "сохранить график";
            this.button_save_as_bitmap.UseVisualStyleBackColor = true;
            this.button_save_as_bitmap.Click += new System.EventHandler(this.button_save_as_bitmap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 460);
            this.Controls.Add(this.button_save_as_bitmap);
            this.Controls.Add(this.button_save_to_exel);
            this.Controls.Add(this.coordLabel);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_w);
            this.Controls.Add(this.label_dt);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.radioButton_path);
            this.Controls.Add(this.radioButton_speed);
            this.Controls.Add(this.textBox_f);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_x0);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_T);
            this.Controls.Add(this.textBox_v0);
            this.Controls.Add(this.textBox_tmax);
            this.Controls.Add(this.textBox_dl);
            this.Controls.Add(this.textBox_tmin);
            this.Controls.Add(this.textBox_k);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_m);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "Колебания пружинного маятника с учетом сопротивления среды.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_f;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_x0;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_T;
        private System.Windows.Forms.TextBox textBox_v0;
        private System.Windows.Forms.TextBox textBox_tmax;
        private System.Windows.Forms.TextBox textBox_dl;
        private System.Windows.Forms.TextBox textBox_tmin;
        private System.Windows.Forms.TextBox textBox_k;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_speed;
        private System.Windows.Forms.RadioButton radioButton_path;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_dt;
        private System.Windows.Forms.Label label_w;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label coordLabel;
        private System.Windows.Forms.Button button_save_to_exel;
        private System.Windows.Forms.Button button_save_as_bitmap;
    }
}

