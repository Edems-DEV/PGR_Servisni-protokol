namespace Servisni_protokol
{
    partial class Form_edit_info
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
            tb_Id = new TextBox();
            label2 = new Label();
            btn_ok = new Button();
            btn_cancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            dtp_meaDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Číslo protokolu:";
            label1.Click += label1_Click;
            // 
            // tb_Id
            // 
            tb_Id.Location = new Point(125, 22);
            tb_Id.Name = "tb_Id";
            tb_Id.Size = new Size(222, 23);
            tb_Id.TabIndex = 1;
            tb_Id.Validating += Required;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 0;
            label2.Text = "Datum měření:";
            label2.Click += label1_Click;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(191, 91);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 2;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(272, 91);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 2;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // dtp_meaDate
            // 
            dtp_meaDate.Location = new Point(125, 51);
            dtp_meaDate.Name = "dtp_meaDate";
            dtp_meaDate.Size = new Size(222, 23);
            dtp_meaDate.TabIndex = 3;
            dtp_meaDate.Validating += Required;
            // 
            // Form_edit_info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 126);
            Controls.Add(dtp_meaDate);
            Controls.Add(btn_cancel);
            Controls.Add(btn_ok);
            Controls.Add(label2);
            Controls.Add(tb_Id);
            Controls.Add(label1);
            Name = "Form_edit_info";
            Text = "Základní informace";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_Id;
        private Label label2;
        private Button btn_ok;
        private Button btn_cancel;
        private ErrorProvider errorProvider1;
        private DateTimePicker dtp_meaDate;
    }
}