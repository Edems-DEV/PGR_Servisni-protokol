namespace Servisni_protokol
{
    partial class Form_edit_customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tb_Name = new TextBox();
            label2 = new Label();
            tb_Address = new TextBox();
            label3 = new Label();
            tb_psc = new TextBox();
            label4 = new Label();
            tb_ic = new TextBox();
            btn_Cancel = new Button();
            btn_ok = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Název:";
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(86, 22);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(265, 23);
            tb_Name.TabIndex = 1;
            tb_Name.Validating += Required;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Adresa:";
            // 
            // tb_Address
            // 
            tb_Address.Location = new Point(86, 51);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(265, 23);
            tb_Address.TabIndex = 2;
            tb_Address.Validating += Required;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "PSČ:";
            // 
            // tb_psc
            // 
            tb_psc.Location = new Point(86, 80);
            tb_psc.Name = "tb_psc";
            tb_psc.Size = new Size(265, 23);
            tb_psc.TabIndex = 3;
            tb_psc.Validating += Validate_Psc;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 0;
            label4.Text = "IČ:";
            // 
            // tb_ic
            // 
            tb_ic.Location = new Point(86, 109);
            tb_ic.Name = "tb_ic";
            tb_ic.Size = new Size(265, 23);
            tb_ic.TabIndex = 4;
            tb_ic.Validating += Validate_Ic;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(276, 145);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 6;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(195, 145);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 5;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Form_edit_customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 180);
            Controls.Add(btn_ok);
            Controls.Add(btn_Cancel);
            Controls.Add(tb_ic);
            Controls.Add(label4);
            Controls.Add(tb_psc);
            Controls.Add(label3);
            Controls.Add(tb_Address);
            Controls.Add(label2);
            Controls.Add(tb_Name);
            Controls.Add(label1);
            MaximumSize = new Size(390, 219);
            MinimumSize = new Size(390, 219);
            Name = "Form_edit_customer";
            Text = "Zákazník";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_Name;
        private Label label2;
        private TextBox tb_Address;
        private Label label3;
        private TextBox tb_psc;
        private Label label4;
        private TextBox tb_ic;
        private Button btn_Cancel;
        private Button btn_ok;
        private ErrorProvider errorProvider1;
    }
}