namespace PC_System_Utility
{
    partial class FormHauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonCpuTesten = new System.Windows.Forms.Button();
            this.ButtonTaskManagerStarten = new System.Windows.Forms.Button();
            this.LabelEntwicklerName = new System.Windows.Forms.Label();
            this.ListboxCpuInfo = new System.Windows.Forms.ListBox();
            this.ListboxRamInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCpuTesten
            // 
            this.ButtonCpuTesten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCpuTesten.Location = new System.Drawing.Point(363, 218);
            this.ButtonCpuTesten.Name = "ButtonCpuTesten";
            this.ButtonCpuTesten.Size = new System.Drawing.Size(106, 32);
            this.ButtonCpuTesten.TabIndex = 2;
            this.ButtonCpuTesten.Text = "CPU testen";
            this.ButtonCpuTesten.UseVisualStyleBackColor = true;
            this.ButtonCpuTesten.Click += new System.EventHandler(this.ButtonCpuTesten_Click);
            // 
            // ButtonTaskManagerStarten
            // 
            this.ButtonTaskManagerStarten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTaskManagerStarten.Location = new System.Drawing.Point(52, 217);
            this.ButtonTaskManagerStarten.Name = "ButtonTaskManagerStarten";
            this.ButtonTaskManagerStarten.Size = new System.Drawing.Size(174, 33);
            this.ButtonTaskManagerStarten.TabIndex = 1;
            this.ButtonTaskManagerStarten.Text = "Task-Manager starten";
            this.ButtonTaskManagerStarten.UseVisualStyleBackColor = true;
            this.ButtonTaskManagerStarten.Click += new System.EventHandler(this.ButtonTaskManagerStarten_Click);
            // 
            // LabelEntwicklerName
            // 
            this.LabelEntwicklerName.AutoSize = true;
            this.LabelEntwicklerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEntwicklerName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LabelEntwicklerName.Location = new System.Drawing.Point(241, 232);
            this.LabelEntwicklerName.Name = "LabelEntwicklerName";
            this.LabelEntwicklerName.Size = new System.Drawing.Size(107, 18);
            this.LabelEntwicklerName.TabIndex = 3;
            this.LabelEntwicklerName.Text = "by Fethi Isfarca";
            // 
            // ListboxCpuInfo
            // 
            this.ListboxCpuInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxCpuInfo.FormattingEnabled = true;
            this.ListboxCpuInfo.ItemHeight = 24;
            this.ListboxCpuInfo.Location = new System.Drawing.Point(12, 46);
            this.ListboxCpuInfo.Name = "ListboxCpuInfo";
            this.ListboxCpuInfo.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListboxCpuInfo.Size = new System.Drawing.Size(543, 76);
            this.ListboxCpuInfo.TabIndex = 4;
            // 
            // ListboxRamInfo
            // 
            this.ListboxRamInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxRamInfo.FormattingEnabled = true;
            this.ListboxRamInfo.ItemHeight = 24;
            this.ListboxRamInfo.Location = new System.Drawing.Point(12, 171);
            this.ListboxRamInfo.Name = "ListboxRamInfo";
            this.ListboxRamInfo.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListboxRamInfo.Size = new System.Drawing.Size(543, 28);
            this.ListboxRamInfo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "RAM:";
            // 
            // FormHauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListboxRamInfo);
            this.Controls.Add(this.ListboxCpuInfo);
            this.Controls.Add(this.LabelEntwicklerName);
            this.Controls.Add(this.ButtonTaskManagerStarten);
            this.Controls.Add(this.ButtonCpuTesten);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(583, 298);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(583, 298);
            this.Name = "FormHauptfenster";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC System Utility";
            this.Load += new System.EventHandler(this.FormHauptfenster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonCpuTesten;
        private System.Windows.Forms.Button ButtonTaskManagerStarten;
        private System.Windows.Forms.Label LabelEntwicklerName;
        private System.Windows.Forms.ListBox ListboxCpuInfo;
        private System.Windows.Forms.ListBox ListboxRamInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

