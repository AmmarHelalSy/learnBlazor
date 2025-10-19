using System.Windows.Forms;
using Tesseract;

namespace OCRDemo
{
    public partial class Form1 : Form
    {
        private string imagePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }
            }
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            try
            {
                string tessDataPath = AppDomain.CurrentDomain.BaseDirectory + @"tessdata";

                using (var engine = new TesseractEngine(tessDataPath, "deu", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            string text = page.GetText();
                            float confidence = page.GetMeanConfidence();

                            txtResult.Text = text + Environment.NewLine +
                                             $"Confidence: {confidence * 100:0.00}%";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
