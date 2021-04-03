
namespace VizheneraApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.encodeInput = new System.Windows.Forms.TextBox();
            this.encodeSecretWord = new System.Windows.Forms.TextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.encodeResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.decodeResult = new System.Windows.Forms.TextBox();
            this.decodeButton = new System.Windows.Forms.Button();
            this.decodeSecretWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isBinaryView = new System.Windows.Forms.CheckBox();
            this.alphabetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст для шифровки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кодовое слово";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат шифровки";
            // 
            // encodeInput
            // 
            this.encodeInput.Location = new System.Drawing.Point(14, 85);
            this.encodeInput.Margin = new System.Windows.Forms.Padding(5);
            this.encodeInput.Multiline = true;
            this.encodeInput.Name = "encodeInput";
            this.encodeInput.Size = new System.Drawing.Size(651, 107);
            this.encodeInput.TabIndex = 3;
            this.encodeInput.TextChanged += new System.EventHandler(this.TextInputToLower);
            // 
            // encodeSecretWord
            // 
            this.encodeSecretWord.Location = new System.Drawing.Point(717, 104);
            this.encodeSecretWord.Margin = new System.Windows.Forms.Padding(5);
            this.encodeSecretWord.Name = "encodeSecretWord";
            this.encodeSecretWord.Size = new System.Drawing.Size(567, 27);
            this.encodeSecretWord.TabIndex = 4;
            this.encodeSecretWord.TextChanged += new System.EventHandler(this.TextInputToLower);
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(717, 144);
            this.encodeButton.Margin = new System.Windows.Forms.Padding(5);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(570, 35);
            this.encodeButton.TabIndex = 5;
            this.encodeButton.Text = "Зашифровать";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // encodeResult
            // 
            this.encodeResult.Location = new System.Drawing.Point(14, 254);
            this.encodeResult.Margin = new System.Windows.Forms.Padding(5);
            this.encodeResult.Multiline = true;
            this.encodeResult.Name = "encodeResult";
            this.encodeResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encodeResult.Size = new System.Drawing.Size(651, 107);
            this.encodeResult.TabIndex = 6;
            this.encodeResult.TextChanged += new System.EventHandler(this.TextInputToLower);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результат дешифровки";
            // 
            // decodeResult
            // 
            this.decodeResult.Location = new System.Drawing.Point(14, 432);
            this.decodeResult.Margin = new System.Windows.Forms.Padding(5);
            this.decodeResult.Multiline = true;
            this.decodeResult.Name = "decodeResult";
            this.decodeResult.Size = new System.Drawing.Size(1271, 107);
            this.decodeResult.TabIndex = 8;
            this.decodeResult.TextChanged += new System.EventHandler(this.TextInputToLower);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(717, 306);
            this.decodeButton.Margin = new System.Windows.Forms.Padding(5);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(570, 35);
            this.decodeButton.TabIndex = 11;
            this.decodeButton.Text = "Дешифровка";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // decodeSecretWord
            // 
            this.decodeSecretWord.Location = new System.Drawing.Point(717, 266);
            this.decodeSecretWord.Margin = new System.Windows.Forms.Padding(5);
            this.decodeSecretWord.Name = "decodeSecretWord";
            this.decodeSecretWord.Size = new System.Drawing.Size(567, 27);
            this.decodeSecretWord.TabIndex = 10;
            this.decodeSecretWord.TextChanged += new System.EventHandler(this.TextInputToLower);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(712, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кодовое слово";
            // 
            // isBinaryView
            // 
            this.isBinaryView.AutoSize = true;
            this.isBinaryView.Location = new System.Drawing.Point(504, 214);
            this.isBinaryView.Margin = new System.Windows.Forms.Padding(5);
            this.isBinaryView.Name = "isBinaryView";
            this.isBinaryView.Size = new System.Drawing.Size(149, 24);
            this.isBinaryView.TabIndex = 12;
            this.isBinaryView.Text = "Бинарный вид";
            this.isBinaryView.UseVisualStyleBackColor = true;
            this.isBinaryView.CheckedChanged += new System.EventHandler(this.isBinaryView_CheckedChanged);
            // 
            // alphabetLabel
            // 
            this.alphabetLabel.AutoSize = true;
            this.alphabetLabel.Location = new System.Drawing.Point(17, 20);
            this.alphabetLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.alphabetLabel.Name = "alphabetLabel";
            this.alphabetLabel.Size = new System.Drawing.Size(102, 20);
            this.alphabetLabel.TabIndex = 13;
            this.alphabetLabel.Text = "Алфавит : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 564);
            this.Controls.Add(this.alphabetLabel);
            this.Controls.Add(this.isBinaryView);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.decodeSecretWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decodeResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.encodeResult);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.encodeSecretWord);
            this.Controls.Add(this.encodeInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Шифр Виженера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encodeInput;
        private System.Windows.Forms.TextBox encodeSecretWord;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.TextBox encodeResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decodeResult;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.TextBox decodeSecretWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox isBinaryView;
        private System.Windows.Forms.Label alphabetLabel;
    }
}

