using Servisni_protokol.Model;

namespace Servisni_protokol
{
    public partial class Form1 : Form
    {
        public ServiceProtocol Sp { get; set; }
        public Form1()
        {
            InitializeComponent();
            Sp = new ServiceProtocol();
            dg_1.DataSource = Sp.Measurements;

            Sp.Customer = new Customer();
            Sp.Device = new Device();
        }
        #region Open
        #region Edit
        private void btn_edit_info_Click(object sender, EventArgs e)
        {
            var f = new Form_edit_info(Sp);
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.label_protocol_number.Text = Sp.Number;
                this.label_protocol_date.Text = Sp.MeaDate.ToString("d");
            }
        }

        private void btn_edit_customer_Click(object sender, EventArgs e)
        {
            var f = new Form_edit_customer(Sp.Customer);
            if (f.ShowDialog() == DialogResult.OK)
            {
                label_customer_Name.Text = Sp.Customer.Name;
                label_customer_address.Text = Sp.Customer.Address;
                label_customer_psc.Text = Sp.Customer.Psc;
                label_customer_ic.Text = Sp.Customer.Ic;
            }
        }

        private void btn_edit_device_Click(object sender, EventArgs e)
        {
            var f = new Form_edit_device(Sp.Device); //Sp.Device
            if (f.ShowDialog() == DialogResult.OK)
            {
                label_device_producer.Text = Sp.Device.Manufacturer;
                label_device_model.Text = Sp.Device.Model;
                label_device_id.Text = Sp.Device.SerialNumber;
            }
        }

        private void btn_mea_add_Click(object sender, EventArgs e)
        {
            var Mea = new Measurement();
            var f = new Form_edit_measurements(Mea);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Sp.Measurements.Add(Mea);
            }
        }

        private void btn_mea_edit_Click(object sender, EventArgs e)
        {
            if (dg_1.CurrentRow == null)
            {
                MessageBox.Show("Pro upravu nejprve vyberte radek");
                return;
            }
            var Mea = dg_1.CurrentRow.DataBoundItem as Measurement;

            //outside?
            var MeaClone = new Measurement(){ Parametr = Mea.Parametr, Value = Mea.Value, Unit = Mea.Unit, IsValid = Mea.IsValid };
            var f = new Form_edit_measurements(MeaClone);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Mea.Parametr = MeaClone.Parametr;
                Mea.Value = MeaClone.Value;
                Mea.Unit = MeaClone.Unit;
                Mea.IsValid = MeaClone.IsValid;

                dg_1.Refresh();
            }
        }

        private void btn_mea_delete_Click(object sender, EventArgs e)
        {
            if (dg_1.CurrentRow == null)
            { 
                MessageBox.Show("Pro upravu nejprve vyberte radek");
                return;
            }
            var Mea = dg_1.CurrentRow.DataBoundItem as Measurement; //outside?


            Sp.Measurements.Remove(Mea);
        }

        private void btn_i_preview_Click(object sender, EventArgs e)
        {
            var f = new Form2_Preview(Sp);
            f.ShowDialog();
        }
        #endregion
        #region Path

        private void btn_o_save_Click(object sender, EventArgs e)
        {
            string path = "";
            var f = new SaveFileDialog();
            f.DefaultExt = "json";

            if (f.ShowDialog() == DialogResult.OK)
            {
                path = f.FileName;
                Sp.Export(path);
            }
        }

        private void btn_o_load_Click(object sender, EventArgs e)
        {
            string path = "";
            var f = new OpenFileDialog();
            f.DefaultExt = "json";

            if (f.ShowDialog() == DialogResult.OK)
            {
                path = f.FileName;
                Sp.Import(path);
            }

            label_protocol_number.Text = Sp.Number;
            label_protocol_date.Text = Sp.MeaDate.ToString("d");
            label_customer_Name.Text = Sp.Customer.Name;
            label_customer_address.Text = Sp.Customer.Address;
            label_customer_psc.Text = Sp.Customer.Psc;
            label_customer_ic.Text = Sp.Customer.Ic;
            label_device_producer.Text = Sp.Device.Manufacturer;
            label_device_model.Text = Sp.Device.Model;
            label_device_id.Text = Sp.Device.SerialNumber;

            dg_1.Refresh();
        }

        private void btn_i_export_Click(object sender, EventArgs e)
        {
            string path = "";
            var f = new SaveFileDialog();
            f.DefaultExt = "html";
            f.AddExtension = true;//?
            
            if (f.ShowDialog() == DialogResult.OK)
            {
                path = f.FileName;
                Sp.SaveHtml(path);
            }
        }
        #endregion
        #endregion
    }
}
