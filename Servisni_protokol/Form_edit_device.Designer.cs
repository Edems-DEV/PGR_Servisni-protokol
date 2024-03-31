namespace Servisni_protokol
{
    partial class Form_edit_device
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
            tb_Manufacturer = new TextBox();
            label2 = new Label();
            tb_Model = new TextBox();
            btn_ok = new Button();
            btn_cancel = new Button();
            label3 = new Label();
            tb_SerialNumber = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Výrobce:";
            label1.Click += label1_Click;
            // 
            // tb_Manufacturer
            // 
            tb_Manufacturer.Location = new Point(125, 22);
            tb_Manufacturer.Name = "tb_Manufacturer";
            tb_Manufacturer.Size = new Size(222, 23);
            tb_Manufacturer.TabIndex = 1;
            tb_Manufacturer.Validating += Required;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Model:";
            label2.Click += label1_Click;
            // 
            // tb_Model
            // 
            tb_Model.Location = new Point(125, 51);
            tb_Model.Name = "tb_Model";
            tb_Model.Size = new Size(222, 23);
            tb_Model.TabIndex = 2;
            tb_Model.Validating += Required;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(191, 121);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 4;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(272, 121);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 0;
            label3.Text = "Sériové číslo:";
            label3.Click += label1_Click;
            // 
            // tb_SerialNumber
            // 
            tb_SerialNumber.Location = new Point(125, 80);
            tb_SerialNumber.Name = "tb_SerialNumber";
            tb_SerialNumber.Size = new Size(222, 23);
            tb_SerialNumber.TabIndex = 3;
            tb_SerialNumber.Validating += Required;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form_edit_device
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 155);
            Controls.Add(btn_cancel);
            Controls.Add(btn_ok);
            Controls.Add(tb_SerialNumber);
            Controls.Add(label3);
            Controls.Add(tb_Model);
            Controls.Add(label2);
            Controls.Add(tb_Manufacturer);
            Controls.Add(label1);
            Name = "Form_edit_device";
            Text = "Zařízení";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_Manufacturer;
        private Label label2;
        private TextBox tb_Model;
        private Button btn_ok;
        private Button btn_cancel;
        private Label label3;
        private TextBox tb_SerialNumber;
        private ErrorProvider errorProvider1;
    }
}