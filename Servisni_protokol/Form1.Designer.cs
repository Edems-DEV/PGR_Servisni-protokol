namespace Servisni_protokol
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_edit_info = new Button();
            label_protocol_date = new Label();
            label_protocol_number = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_edit_customer = new Button();
            label_customer_ic = new Label();
            label_customer_psc = new Label();
            label_customer_address = new Label();
            label_customer_Name = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btn_edit_device = new Button();
            label_device_id = new Label();
            label_device_model = new Label();
            label_device_producer = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox4 = new GroupBox();
            btn_mea_add = new Button();
            btn_mea_edit = new Button();
            btn_mea_delete = new Button();
            dg_1 = new DataGridView();
            btn_o_save = new Button();
            btn_o_load = new Button();
            btn_i_preview = new Button();
            btn_i_export = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_edit_info);
            groupBox1.Controls.Add(label_protocol_date);
            groupBox1.Controls.Add(label_protocol_number);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 91);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Základní informace";
            // 
            // btn_edit_info
            // 
            btn_edit_info.Location = new Point(523, 22);
            btn_edit_info.Name = "btn_edit_info";
            btn_edit_info.Size = new Size(75, 49);
            btn_edit_info.TabIndex = 1;
            btn_edit_info.Text = "Upravit";
            btn_edit_info.UseVisualStyleBackColor = true;
            btn_edit_info.Click += btn_edit_info_Click;
            // 
            // label_protocol_date
            // 
            label_protocol_date.AutoSize = true;
            label_protocol_date.Location = new Point(108, 53);
            label_protocol_date.Name = "label_protocol_date";
            label_protocol_date.Size = new Size(12, 15);
            label_protocol_date.TabIndex = 1;
            label_protocol_date.Text = "?";
            // 
            // label_protocol_number
            // 
            label_protocol_number.AutoSize = true;
            label_protocol_number.Location = new Point(108, 27);
            label_protocol_number.Name = "label_protocol_number";
            label_protocol_number.Size = new Size(12, 15);
            label_protocol_number.TabIndex = 1;
            label_protocol_number.Text = "?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 53);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 0;
            label2.Text = "Datum měření:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 27);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Číslo protokolu:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_edit_customer);
            groupBox2.Controls.Add(label_customer_ic);
            groupBox2.Controls.Add(label_customer_psc);
            groupBox2.Controls.Add(label_customer_address);
            groupBox2.Controls.Add(label_customer_Name);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 164);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Zákazník";
            // 
            // btn_edit_customer
            // 
            btn_edit_customer.Location = new Point(206, 135);
            btn_edit_customer.Name = "btn_edit_customer";
            btn_edit_customer.Size = new Size(75, 23);
            btn_edit_customer.TabIndex = 2;
            btn_edit_customer.Text = "Upravit";
            btn_edit_customer.UseVisualStyleBackColor = true;
            btn_edit_customer.Click += btn_edit_customer_Click;
            // 
            // label_customer_ic
            // 
            label_customer_ic.AutoSize = true;
            label_customer_ic.Location = new Point(108, 110);
            label_customer_ic.Name = "label_customer_ic";
            label_customer_ic.Size = new Size(12, 15);
            label_customer_ic.TabIndex = 1;
            label_customer_ic.Text = "?";
            // 
            // label_customer_psc
            // 
            label_customer_psc.AutoSize = true;
            label_customer_psc.Location = new Point(108, 84);
            label_customer_psc.Name = "label_customer_psc";
            label_customer_psc.Size = new Size(12, 15);
            label_customer_psc.TabIndex = 1;
            label_customer_psc.Text = "?";
            // 
            // label_customer_address
            // 
            label_customer_address.AutoSize = true;
            label_customer_address.Location = new Point(108, 56);
            label_customer_address.Name = "label_customer_address";
            label_customer_address.Size = new Size(12, 15);
            label_customer_address.TabIndex = 1;
            label_customer_address.Text = "?";
            // 
            // label_customer_Name
            // 
            label_customer_Name.AutoSize = true;
            label_customer_Name.Location = new Point(108, 31);
            label_customer_Name.Name = "label_customer_Name";
            label_customer_Name.Size = new Size(12, 15);
            label_customer_Name.TabIndex = 1;
            label_customer_Name.Text = "?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 110);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 0;
            label8.Text = "IČ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 84);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 0;
            label6.Text = "PSČ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 56);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 0;
            label4.Text = "Adresa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 31);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Název:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_edit_device);
            groupBox3.Controls.Add(label_device_id);
            groupBox3.Controls.Add(label_device_model);
            groupBox3.Controls.Add(label_device_producer);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(329, 109);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(287, 164);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Zařízení";
            // 
            // btn_edit_device
            // 
            btn_edit_device.Location = new Point(206, 135);
            btn_edit_device.Name = "btn_edit_device";
            btn_edit_device.Size = new Size(75, 23);
            btn_edit_device.TabIndex = 3;
            btn_edit_device.Text = "Upravit";
            btn_edit_device.UseVisualStyleBackColor = true;
            btn_edit_device.Click += btn_edit_device_Click;
            // 
            // label_device_id
            // 
            label_device_id.AutoSize = true;
            label_device_id.Location = new Point(108, 84);
            label_device_id.Name = "label_device_id";
            label_device_id.Size = new Size(12, 15);
            label_device_id.TabIndex = 1;
            label_device_id.Text = "?";
            // 
            // label_device_model
            // 
            label_device_model.AutoSize = true;
            label_device_model.Location = new Point(108, 56);
            label_device_model.Name = "label_device_model";
            label_device_model.Size = new Size(12, 15);
            label_device_model.TabIndex = 1;
            label_device_model.Text = "?";
            // 
            // label_device_producer
            // 
            label_device_producer.AutoSize = true;
            label_device_producer.Location = new Point(108, 31);
            label_device_producer.Name = "label_device_producer";
            label_device_producer.Size = new Size(12, 15);
            label_device_producer.TabIndex = 1;
            label_device_producer.Text = "?";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 84);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 0;
            label12.Text = "Sériové číslo:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 56);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 0;
            label13.Text = "Model:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 31);
            label14.Name = "label14";
            label14.Size = new Size(53, 15);
            label14.TabIndex = 0;
            label14.Text = "Výrobce:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_mea_add);
            groupBox4.Controls.Add(btn_mea_edit);
            groupBox4.Controls.Add(btn_mea_delete);
            groupBox4.Controls.Add(dg_1);
            groupBox4.Location = new Point(12, 279);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(604, 236);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Měření";
            // 
            // btn_mea_add
            // 
            btn_mea_add.Location = new Point(347, 200);
            btn_mea_add.Name = "btn_mea_add";
            btn_mea_add.Size = new Size(75, 23);
            btn_mea_add.TabIndex = 4;
            btn_mea_add.Text = "Přidat";
            btn_mea_add.UseVisualStyleBackColor = true;
            btn_mea_add.Click += btn_mea_add_Click;
            // 
            // btn_mea_edit
            // 
            btn_mea_edit.Location = new Point(428, 200);
            btn_mea_edit.Name = "btn_mea_edit";
            btn_mea_edit.Size = new Size(75, 23);
            btn_mea_edit.TabIndex = 5;
            btn_mea_edit.Text = "Upravit";
            btn_mea_edit.UseVisualStyleBackColor = true;
            btn_mea_edit.Click += btn_mea_edit_Click;
            // 
            // btn_mea_delete
            // 
            btn_mea_delete.Location = new Point(509, 200);
            btn_mea_delete.Name = "btn_mea_delete";
            btn_mea_delete.Size = new Size(75, 23);
            btn_mea_delete.TabIndex = 6;
            btn_mea_delete.Text = "Smazat";
            btn_mea_delete.UseVisualStyleBackColor = true;
            btn_mea_delete.Click += btn_mea_delete_Click;
            // 
            // dg_1
            // 
            dg_1.AllowUserToAddRows = false;
            dg_1.AllowUserToDeleteRows = false;
            dg_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_1.Location = new Point(20, 22);
            dg_1.Name = "dg_1";
            dg_1.ReadOnly = true;
            dg_1.Size = new Size(564, 172);
            dg_1.TabIndex = 0;
            // 
            // btn_o_save
            // 
            btn_o_save.Location = new Point(12, 532);
            btn_o_save.Name = "btn_o_save";
            btn_o_save.Size = new Size(75, 23);
            btn_o_save.TabIndex = 7;
            btn_o_save.Text = "Uložit";
            btn_o_save.UseVisualStyleBackColor = true;
            btn_o_save.Click += btn_o_save_Click;
            // 
            // btn_o_load
            // 
            btn_o_load.Location = new Point(93, 532);
            btn_o_load.Name = "btn_o_load";
            btn_o_load.Size = new Size(75, 23);
            btn_o_load.TabIndex = 8;
            btn_o_load.Text = "Načíst";
            btn_o_load.UseVisualStyleBackColor = true;
            btn_o_load.Click += btn_o_load_Click;
            // 
            // btn_i_preview
            // 
            btn_i_preview.Location = new Point(541, 537);
            btn_i_preview.Name = "btn_i_preview";
            btn_i_preview.Size = new Size(75, 23);
            btn_i_preview.TabIndex = 10;
            btn_i_preview.Text = "Náhled";
            btn_i_preview.UseVisualStyleBackColor = true;
            btn_i_preview.Click += btn_i_preview_Click;
            // 
            // btn_i_export
            // 
            btn_i_export.Location = new Point(460, 537);
            btn_i_export.Name = "btn_i_export";
            btn_i_export.Size = new Size(75, 23);
            btn_i_export.TabIndex = 9;
            btn_i_export.Text = "Export";
            btn_i_export.UseVisualStyleBackColor = true;
            btn_i_export.Click += btn_i_export_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 572);
            Controls.Add(btn_i_export);
            Controls.Add(btn_i_preview);
            Controls.Add(btn_o_load);
            Controls.Add(btn_o_save);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Servisní protokol";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label_protocol_number;
        private Label label2;
        private Label label1;
        private Button btn_edit_info;
        private Label label_protocol_date;
        private GroupBox groupBox2;
        private Label label_customer_ic;
        private Label label_customer_psc;
        private Label label_customer_address;
        private Label label_customer_Name;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button btn_edit_customer;
        private GroupBox groupBox3;
        private Button btn_edit_device;
        private Label label_device_id;
        private Label label_device_model;
        private Label label_device_producer;
        private Label label12;
        private Label label13;
        private Label label14;
        private GroupBox groupBox4;
        private DataGridView dg_1;
        private Button btn_mea_add;
        private Button btn_mea_edit;
        private Button btn_mea_delete;
        private Button btn_o_save;
        private Button btn_o_load;
        private Button btn_i_preview;
        private Button btn_i_export;
    }
}
