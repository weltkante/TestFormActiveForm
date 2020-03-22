namespace TestFormActiveForm
{
    using TestFormActiveForm.Controls;

    public partial class Form1 : ThemedForm
    {
        public Form1()
            => this.InitializeComponent();

        private void Button1_Click(object sender, System.EventArgs e)
        {
            var tmp = new Form1();
            _ = tmp.ShowDialog(this);
            tmp.Dispose();
            // throw new System.NotImplementedException();
        }
    }
}
