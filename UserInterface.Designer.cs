namespace QPSK_GOLD
{
    partial class UserInterface
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
            this.trackBarNoise = new System.Windows.Forms.TrackBar();
            this.lblMessageOut = new System.Windows.Forms.Label();
            this.txtBoxMessageOut = new System.Windows.Forms.TextBox();
            this.txtBoxOutputBits = new System.Windows.Forms.TextBox();
            this.lblBinSeqOut = new System.Windows.Forms.Label();
            this.lblNoise = new System.Windows.Forms.Label();
            this.groupBoxDecode = new System.Windows.Forms.GroupBox();
            this.btnGenText = new System.Windows.Forms.Button();
            this.lblMessageInp = new System.Windows.Forms.Label();
            this.txtBoxInputBits = new System.Windows.Forms.TextBox();
            this.pbSignal = new System.Windows.Forms.PictureBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.lblBinSeqInp = new System.Windows.Forms.Label();
            this.groupBoxEncode = new System.Windows.Forms.GroupBox();
            this.txtBoxMessageInp = new System.Windows.Forms.TextBox();
            this.groupBoxNoise = new System.Windows.Forms.GroupBox();
            this.pbConstellation = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNoise)).BeginInit();
            this.groupBoxDecode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignal)).BeginInit();
            this.groupBoxEncode.SuspendLayout();
            this.groupBoxNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConstellation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarNoise
            // 
            this.trackBarNoise.Location = new System.Drawing.Point(34, 16);
            this.trackBarNoise.Maximum = 100;
            this.trackBarNoise.Name = "trackBarNoise";
            this.trackBarNoise.Size = new System.Drawing.Size(189, 45);
            this.trackBarNoise.TabIndex = 24;
            this.trackBarNoise.Value = 50;
            this.trackBarNoise.Scroll += new System.EventHandler(this.trackBarNoise_Scroll);
            // 
            // lblMessageOut
            // 
            this.lblMessageOut.AutoSize = true;
            this.lblMessageOut.Location = new System.Drawing.Point(6, 24);
            this.lblMessageOut.Name = "lblMessageOut";
            this.lblMessageOut.Size = new System.Drawing.Size(68, 13);
            this.lblMessageOut.TabIndex = 10;
            this.lblMessageOut.Text = "Сообщение:";
            // 
            // txtBoxMessageOut
            // 
            this.txtBoxMessageOut.Location = new System.Drawing.Point(215, 19);
            this.txtBoxMessageOut.Name = "txtBoxMessageOut";
            this.txtBoxMessageOut.ReadOnly = true;
            this.txtBoxMessageOut.Size = new System.Drawing.Size(281, 20);
            this.txtBoxMessageOut.TabIndex = 7;
            this.txtBoxMessageOut.TextChanged += new System.EventHandler(this.txtBoxMessageOut_TextChanged);
            this.txtBoxMessageOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMessageOut_KeyPress);
            // 
            // txtBoxOutputBits
            // 
            this.txtBoxOutputBits.Location = new System.Drawing.Point(215, 47);
            this.txtBoxOutputBits.Name = "txtBoxOutputBits";
            this.txtBoxOutputBits.ReadOnly = true;
            this.txtBoxOutputBits.Size = new System.Drawing.Size(281, 20);
            this.txtBoxOutputBits.TabIndex = 9;
            // 
            // lblBinSeqOut
            // 
            this.lblBinSeqOut.AutoSize = true;
            this.lblBinSeqOut.Location = new System.Drawing.Point(6, 50);
            this.lblBinSeqOut.Name = "lblBinSeqOut";
            this.lblBinSeqOut.Size = new System.Drawing.Size(213, 13);
            this.lblBinSeqOut.TabIndex = 8;
            this.lblBinSeqOut.Text = "Выходная битовая последовательность:";
            // 
            // lblNoise
            // 
            this.lblNoise.AutoSize = true;
            this.lblNoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNoise.Location = new System.Drawing.Point(2, 16);
            this.lblNoise.Name = "lblNoise";
            this.lblNoise.Size = new System.Drawing.Size(18, 20);
            this.lblNoise.TabIndex = 25;
            this.lblNoise.Text = "0";
            // 
            // groupBoxDecode
            // 
            this.groupBoxDecode.Controls.Add(this.lblMessageOut);
            this.groupBoxDecode.Controls.Add(this.txtBoxMessageOut);
            this.groupBoxDecode.Controls.Add(this.txtBoxOutputBits);
            this.groupBoxDecode.Controls.Add(this.lblBinSeqOut);
            this.groupBoxDecode.Location = new System.Drawing.Point(530, 10);
            this.groupBoxDecode.Name = "groupBoxDecode";
            this.groupBoxDecode.Size = new System.Drawing.Size(501, 82);
            this.groupBoxDecode.TabIndex = 22;
            this.groupBoxDecode.TabStop = false;
            this.groupBoxDecode.Text = "Прием";
            // 
            // btnGenText
            // 
            this.btnGenText.Location = new System.Drawing.Point(106, 17);
            this.btnGenText.Name = "btnGenText";
            this.btnGenText.Size = new System.Drawing.Size(95, 23);
            this.btnGenText.TabIndex = 7;
            this.btnGenText.Text = "Сгенерировать";
            this.btnGenText.UseVisualStyleBackColor = true;
            this.btnGenText.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMessageInp
            // 
            this.lblMessageInp.AutoSize = true;
            this.lblMessageInp.Location = new System.Drawing.Point(6, 26);
            this.lblMessageInp.Name = "lblMessageInp";
            this.lblMessageInp.Size = new System.Drawing.Size(68, 13);
            this.lblMessageInp.TabIndex = 6;
            this.lblMessageInp.Text = "Сообщение:";
            // 
            // txtBoxInputBits
            // 
            this.txtBoxInputBits.Location = new System.Drawing.Point(217, 50);
            this.txtBoxInputBits.Name = "txtBoxInputBits";
            this.txtBoxInputBits.ReadOnly = true;
            this.txtBoxInputBits.Size = new System.Drawing.Size(289, 20);
            this.txtBoxInputBits.TabIndex = 2;
            // 
            // pbSignal
            // 
            this.pbSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSignal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbSignal.Location = new System.Drawing.Point(12, 96);
            this.pbSignal.Name = "pbSignal";
            this.pbSignal.Size = new System.Drawing.Size(633, 597);
            this.pbSignal.TabIndex = 21;
            this.pbSignal.TabStop = false;
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logBox.Location = new System.Drawing.Point(651, 446);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(375, 247);
            this.logBox.TabIndex = 23;
            // 
            // btnSendData
            // 
            this.btnSendData.Enabled = false;
            this.btnSendData.Location = new System.Drawing.Point(53, 243);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(149, 27);
            this.btnSendData.TabIndex = 20;
            this.btnSendData.Text = "Модуляция";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // lblBinSeqInp
            // 
            this.lblBinSeqInp.AutoSize = true;
            this.lblBinSeqInp.Location = new System.Drawing.Point(6, 53);
            this.lblBinSeqInp.Name = "lblBinSeqInp";
            this.lblBinSeqInp.Size = new System.Drawing.Size(205, 13);
            this.lblBinSeqInp.TabIndex = 1;
            this.lblBinSeqInp.Text = "Входная битовая последовательность:";
            // 
            // groupBoxEncode
            // 
            this.groupBoxEncode.Controls.Add(this.btnGenText);
            this.groupBoxEncode.Controls.Add(this.lblMessageInp);
            this.groupBoxEncode.Controls.Add(this.txtBoxInputBits);
            this.groupBoxEncode.Controls.Add(this.txtBoxMessageInp);
            this.groupBoxEncode.Controls.Add(this.lblBinSeqInp);
            this.groupBoxEncode.Location = new System.Drawing.Point(12, 10);
            this.groupBoxEncode.Name = "groupBoxEncode";
            this.groupBoxEncode.Size = new System.Drawing.Size(512, 82);
            this.groupBoxEncode.TabIndex = 18;
            this.groupBoxEncode.TabStop = false;
            this.groupBoxEncode.Text = "Передача";
            // 
            // txtBoxMessageInp
            // 
            this.txtBoxMessageInp.Location = new System.Drawing.Point(217, 21);
            this.txtBoxMessageInp.Name = "txtBoxMessageInp";
            this.txtBoxMessageInp.Size = new System.Drawing.Size(289, 20);
            this.txtBoxMessageInp.TabIndex = 1;
            this.txtBoxMessageInp.TextChanged += new System.EventHandler(this.txtBoxMessageInp_TextChanged);
            this.txtBoxMessageInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMessageInp_KeyPress);
            // 
            // groupBoxNoise
            // 
            this.groupBoxNoise.Controls.Add(this.trackBarNoise);
            this.groupBoxNoise.Controls.Add(this.lblNoise);
            this.groupBoxNoise.Location = new System.Drawing.Point(11, 161);
            this.groupBoxNoise.Name = "groupBoxNoise";
            this.groupBoxNoise.Size = new System.Drawing.Size(235, 63);
            this.groupBoxNoise.TabIndex = 27;
            this.groupBoxNoise.TabStop = false;
            this.groupBoxNoise.Text = "SNR";
            // 
            // pbConstellation
            // 
            this.pbConstellation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbConstellation.Location = new System.Drawing.Point(651, 96);
            this.pbConstellation.Name = "pbConstellation";
            this.pbConstellation.Size = new System.Drawing.Size(375, 344);
            this.pbConstellation.TabIndex = 28;
            this.pbConstellation.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Символьная скорость:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBoxNoise);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.btnSendData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1037, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 676);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметеры ФМ-4 модуляции";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Сохранить все графики";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(179, 135);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(44, 20);
            this.textBox5.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Период дескритизации:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(179, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(44, 20);
            this.textBox4.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Длительность одного символа:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(179, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 20);
            this.textBox3.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Несущая:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 20);
            this.textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Частота дискретизации:";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbConstellation);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.groupBoxDecode);
            this.Controls.Add(this.pbSignal);
            this.Controls.Add(this.groupBoxEncode);
            this.Name = "UserInterface";
            this.Text = "Декодирование ФМ4 сигнала, модулированного последовательностью Голда, при помощи " +
    "согласованной фильтрации";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNoise)).EndInit();
            this.groupBoxDecode.ResumeLayout(false);
            this.groupBoxDecode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignal)).EndInit();
            this.groupBoxEncode.ResumeLayout(false);
            this.groupBoxEncode.PerformLayout();
            this.groupBoxNoise.ResumeLayout(false);
            this.groupBoxNoise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConstellation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarNoise;
        private System.Windows.Forms.Label lblMessageOut;
        private System.Windows.Forms.TextBox txtBoxMessageOut;
        private System.Windows.Forms.TextBox txtBoxOutputBits;
        private System.Windows.Forms.Label lblBinSeqOut;
        private System.Windows.Forms.Label lblNoise;
        private System.Windows.Forms.GroupBox groupBoxDecode;
        private System.Windows.Forms.Button btnGenText;
        private System.Windows.Forms.Label lblMessageInp;
        private System.Windows.Forms.TextBox txtBoxInputBits;
        private System.Windows.Forms.PictureBox pbSignal;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label lblBinSeqInp;
        private System.Windows.Forms.GroupBox groupBoxEncode;
        private System.Windows.Forms.TextBox txtBoxMessageInp;
        private System.Windows.Forms.GroupBox groupBoxNoise;
        private System.Windows.Forms.PictureBox pbConstellation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

