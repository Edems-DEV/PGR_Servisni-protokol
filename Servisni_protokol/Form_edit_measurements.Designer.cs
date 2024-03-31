namespace Servisni_protokol
{
    partial class Form_edit_measurements
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
            tb_parametr = new TextBox();
            label2 = new Label();
            tb_value = new TextBox();
            btn_ok = new Button();
            btn_cancel = new Button();
            label3 = new Label();
            tb_unit = new TextBox();
            label4 = new Label();
            chb_IsValid = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Parametr:";
            label1.Click += label1_Click;
            // 
            // tb_parametr
            // 
            tb_parametr.Location = new Point(131, 22);
            tb_parametr.Name = "tb_parametr";
            tb_parametr.Size = new Size(216, 23);
            tb_parametr.TabIndex = 1;
            tb_parametr.Validating += Required;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 0;
            label2.Text = "Naměřená hodnota:";
            label2.Click += label1_Click;
            // 
            // tb_value
            // 
            tb_value.Location = new Point(131, 51);
            tb_value.Name = "tb_value";
            tb_value.Size = new Size(216, 23);
            tb_value.TabIndex = 2;
            tb_value.Validating += Validate_Value;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(191, 144);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 5;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(272, 144);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 6;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 0;
            label3.Text = "Jednotka:";
            label3.Click += label1_Click;
            // 
            // tb_unit
            // 
            tb_unit.Location = new Point(131, 80);
            tb_unit.Name = "tb_unit";
            tb_unit.Size = new Size(216, 23);
            tb_unit.TabIndex = 3;
            tb_unit.Validating += Required;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 0;
            label4.Text = "Vyhovuje:";
            label4.Click += label1_Click;
            // 
            // chb_IsValid
            // 
            chb_IsValid.AutoSize = true;
            chb_IsValid.Location = new Point(131, 112);
            chb_IsValid.Name = "chb_IsValid";
            chb_IsValid.Size = new Size(15, 14);
            chb_IsValid.TabIndex = 4;
            chb_IsValid.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form_edit_measurements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 179);
            Controls.Add(chb_IsValid);
            Controls.Add(btn_cancel);
            Controls.Add(btn_ok);
            Controls.Add(label4);
            Controls.Add(tb_unit);
            Controls.Add(label3);
            Controls.Add(tb_value);
            Controls.Add(label2);
            Controls.Add(tb_parametr);
            Controls.Add(label1);
            Name = "Form_edit_measurements";
            Text = "Měření";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_parametr;
        private Label label2;
        private TextBox tb_value;
        private Button btn_ok;
        private Button btn_cancel;
        private Label label3;
        private TextBox tb_unit;
        private Label label4;
        private CheckBox chb_IsValid;
        private ErrorProvider errorProvider1;
    }
}