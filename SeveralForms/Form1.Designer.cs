namespace SeveralForms
{
    partial class FormBase
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
            this.buttonCreateFormB = new System.Windows.Forms.Button();
            this.buttonCreateFormC = new System.Windows.Forms.Button();
            this.richTextBoxA = new System.Windows.Forms.RichTextBox();
            this.buttonToFormB = new System.Windows.Forms.Button();
            this.buttonToFormC = new System.Windows.Forms.Button();
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateFormB
            // 
            this.buttonCreateFormB.Location = new System.Drawing.Point(29, 28);
            this.buttonCreateFormB.Name = "buttonCreateFormB";
            this.buttonCreateFormB.Size = new System.Drawing.Size(221, 43);
            this.buttonCreateFormB.TabIndex = 0;
            this.buttonCreateFormB.Text = "Создать форму \"В\"";
            this.buttonCreateFormB.UseVisualStyleBackColor = true;
            this.buttonCreateFormB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCreateFormB_MouseClick);
            // 
            // buttonCreateFormC
            // 
            this.buttonCreateFormC.Location = new System.Drawing.Point(29, 120);
            this.buttonCreateFormC.Name = "buttonCreateFormC";
            this.buttonCreateFormC.Size = new System.Drawing.Size(221, 43);
            this.buttonCreateFormC.TabIndex = 1;
            this.buttonCreateFormC.Text = "Создать форму \"С\"";
            this.buttonCreateFormC.UseVisualStyleBackColor = true;
            this.buttonCreateFormC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCreateFormC_MouseClick);
            // 
            // richTextBoxA
            // 
            this.richTextBoxA.Location = new System.Drawing.Point(29, 212);
            this.richTextBoxA.Name = "richTextBoxA";
            this.richTextBoxA.Size = new System.Drawing.Size(221, 200);
            this.richTextBoxA.TabIndex = 2;
            this.richTextBoxA.Text = "";
            // 
            // buttonToFormB
            // 
            this.buttonToFormB.Location = new System.Drawing.Point(266, 212);
            this.buttonToFormB.Name = "buttonToFormB";
            this.buttonToFormB.Size = new System.Drawing.Size(97, 74);
            this.buttonToFormB.TabIndex = 3;
            this.buttonToFormB.Text = "Передать на форму \"В\"";
            this.buttonToFormB.UseVisualStyleBackColor = true;
            this.buttonToFormB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonToFormB_MouseClick);
            // 
            // buttonToFormC
            // 
            this.buttonToFormC.Location = new System.Drawing.Point(266, 338);
            this.buttonToFormC.Name = "buttonToFormC";
            this.buttonToFormC.Size = new System.Drawing.Size(97, 74);
            this.buttonToFormC.TabIndex = 4;
            this.buttonToFormC.Text = "Передать на форму \"С\" ";
            this.buttonToFormC.UseVisualStyleBackColor = true;
            this.buttonToFormC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonToFormC_MouseClick);
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.Image = global::SeveralForms.Properties.Resources.щенок2;
            this.pictureBoxA.Location = new System.Drawing.Point(266, 58);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(97, 69);
            this.pictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxA.TabIndex = 5;
            this.pictureBoxA.TabStop = false;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.pictureBoxA);
            this.Controls.Add(this.buttonToFormC);
            this.Controls.Add(this.buttonToFormB);
            this.Controls.Add(this.richTextBoxA);
            this.Controls.Add(this.buttonCreateFormC);
            this.Controls.Add(this.buttonCreateFormB);
            this.Name = "FormBase";
            this.Text = "Форма \"А\"";
            this.Load += new System.EventHandler(this.FormBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateFormB;
        private System.Windows.Forms.Button buttonCreateFormC;
        private System.Windows.Forms.RichTextBox richTextBoxA;
        private System.Windows.Forms.Button buttonToFormB;
        private System.Windows.Forms.Button buttonToFormC;
        private System.Windows.Forms.PictureBox pictureBoxA;
    }
}

