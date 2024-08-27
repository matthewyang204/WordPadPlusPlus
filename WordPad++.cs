namespace Wordpad++
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void InitializeComponent()
    {
        SuspendLayout();
        // 
        // Form1
        // 
        ClientSize = new Size(757, 566);
        Name = "Form1";
        Text = "WordPad++";
        Load += Form1_Load_1;
        ResumeLayout(false);
    }

    private void Form1_Load_1(object sender, EventArgs e)
    {

    }
}
}
