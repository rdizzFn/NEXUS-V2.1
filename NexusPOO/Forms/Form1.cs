namespace NexusForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Paisaje cósmico con planetas y montañas.png")
            );

            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}