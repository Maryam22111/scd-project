namespace Fee_Invoice__
{
    public partial class Invoice : Form
    {
        public Invoice() => InitializeComponent();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
            txtresult.Text += "***********************************\n";
            txtresult.Text += "*****   Fees Receipt System   *****\n";
            txtresult.Text += "***********************************\n";
            txtresult.Text += "Date :" + DateTime.Now + "\n\n";

            txtresult.Text += "Student Name: " + txtStudentName.Text + "\n\n";
            txtresult.Text += "Father Name : " + txtFatherName.Text + "\n\n";
            txtresult.Text += "Batch       : " + txtBatch.Text + "\n\n";
            txtresult.Text += "Mobile Number : " + txtNumber.Text + "\n\n";
            txtresult.Text += "Fees        : " + txtFees.Text + "\n\n";

            txtresult.Text += "\n        Signature";

        }

       

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtStudentName.Text = "";
            txtFatherName.Text = "";
            txtBatch.Text = "";
            txtNumber.Text = "";
            txtFees.Text = ""; 
            txtresult.Text = "";
        }

        

       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;

        private void btnprint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp=new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg=Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

    }
}