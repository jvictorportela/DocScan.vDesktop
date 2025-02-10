namespace DocScan.Presentation;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
    }

    private void btnAnalyze_Click(object sender, EventArgs e)
    {
        var formAnalyze = new FormAnalyze();

        this.Hide();
        formAnalyze.Show();
    }
}
