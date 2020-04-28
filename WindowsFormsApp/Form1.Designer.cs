namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BUTTON = new System.Windows.Forms.Button();
            this.CHECKBOX = new System.Windows.Forms.CheckBox();
            this.TEXTBOX = new System.Windows.Forms.TextBox();
            this.LABEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BUTTON
            // 
            this.BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.BUTTON.Location = new System.Drawing.Point(44, 141);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(128, 36);
            this.BUTTON.TabIndex = 0;
            this.BUTTON.Text = "CHANGE ME";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.CHECKBOX_CheckedChanged);
            this.BUTTON.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BUTTON_MouseClick);
            // 
            // CHECKBOX
            // 
            this.CHECKBOX.AutoSize = true;
            this.CHECKBOX.Location = new System.Drawing.Point(44, 106);
            this.CHECKBOX.Name = "CHECKBOX";
            this.CHECKBOX.Size = new System.Drawing.Size(120, 17);
            this.CHECKBOX.TabIndex = 1;
            this.CHECKBOX.Text = "WLACZ / WYLACZ";
            this.CHECKBOX.UseVisualStyleBackColor = true;
            this.CHECKBOX.CheckedChanged += new System.EventHandler(this.CHECKBOX_CheckedChanged);
            // 
            // TEXTBOX
            // 
            this.TEXTBOX.Location = new System.Drawing.Point(12, 58);
            this.TEXTBOX.Name = "TEXTBOX";
            this.TEXTBOX.Size = new System.Drawing.Size(196, 20);
            this.TEXTBOX.TabIndex = 2;
            this.TEXTBOX.TextChanged += new System.EventHandler(this.TEXTBOX_TextChanged);
            // 
            // LABEL
            // 
            this.LABEL.AutoSize = true;
            this.LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LABEL.Location = new System.Drawing.Point(39, 9);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(143, 26);
            this.LABEL.TabIndex = 3;
            this.LABEL.Text = "KWZP KARP";
            this.LABEL.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 200);
            this.Controls.Add(this.LABEL);
            this.Controls.Add(this.TEXTBOX);
            this.Controls.Add(this.CHECKBOX);
            this.Controls.Add(this.BUTTON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUTTON;
        private System.Windows.Forms.CheckBox CHECKBOX;
        private System.Windows.Forms.TextBox TEXTBOX;
        private System.Windows.Forms.Label LABEL;
    }
}

