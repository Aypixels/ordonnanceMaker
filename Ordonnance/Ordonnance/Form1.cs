using Aspose.Pdf.Text;
using System.ComponentModel;

namespace Ordonnance
{
    public partial class Form1 : Form
    {
        private BackgroundWorker backgroundWorker;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();

            var cabinetNameText = cabinetName.Text;
            var medicNameText = textBox1.Text;
            var patientNameText = textBox2.Text;
            var patientBornText = textBox3.Text;
            var pathText = textBox4.Text;
            if (pathText == "") pathText = System.IO.Directory.GetCurrentDirectory();
            var prescriptionsText = richTextBox1.Text.ToUpper();
            var numberOfPrescriptionsText = numericUpDown1.Value.ToString();

            var genderText = textBox5.Text;
            var ageText = numericUpDown2.Value.ToString();

            var locationText = textBox6.Text;
            var dateText = DateTime.Now.Date.ToString("dd/MM/yyyy");

            Aspose.Pdf.Document document = new Aspose.Pdf.Document();
            Aspose.Pdf.Page page = document.Pages.Add();

            var header = new TextFragment($"Cabinet Médical\n{cabinetNameText}");
            header.TextState.Font = FontRepository.FindFont("Arial");
            header.TextState.FontSize = 14;
            header.TextState.FontStyle = FontStyles.Bold;
            header.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            header.Position = new Position(80, 800);
            page.Paragraphs.Add(header);

            var Dr = new TextFragment("Dr " + medicNameText);
            Dr.TextState.Font = FontRepository.FindFont("Arial");
            Dr.TextState.FontSize = 14;
            Dr.TextState.FontStyle = FontStyles.Bold;
            Dr.Position = new Position(50, 700);
            page.Paragraphs.Add(Dr);
            var DrDescription = new TextFragment("Spécialiste en médecine générale\nDiplômé de la Faculté de Nantes");
            DrDescription.TextState.FontSize = 10;
            DrDescription.Position = new Position(50, 690);
            page.Paragraphs.Add(DrDescription);

            var patientName = new TextFragment(patientNameText);
            patientName.TextState.Font = FontRepository.FindFont("Arial");
            patientName.TextState.FontSize = 14;
            patientName.Position = new Position(350, 700);
            page.Paragraphs.Add(patientName);
            var patientBorn = new TextFragment(patientBornText);
            patientBorn.TextState.Font = FontRepository.FindFont("Arial");
            patientBorn.TextState.FontSize = 14;
            patientBorn.Position = new Position(350, 675);
            page.Paragraphs.Add(patientBorn);
            var locationAndDate = new TextFragment($"{locationText}, le {dateText}");
            locationAndDate.TextState.Font = FontRepository.FindFont("Arial");
            locationAndDate.TextState.FontSize = 12;
            locationAndDate.Position = new Position(350, 630);
            page.Paragraphs.Add(locationAndDate);

            var prescriptions = new TextFragment(prescriptionsText);
            prescriptions.TextState.Font = FontRepository.FindFont("Arial");
            prescriptions.TextState.FontSize = 11;
            prescriptions.TextState.FontStyle = FontStyles.Bold;
            prescriptions.TextState.LineSpacing = 5;
            prescriptions.Position = new Position(50, 590);
            page.Paragraphs.Add(prescriptions);
            var line = new TextFragment("----------------------------------------------------------------------------------------------------------------------------");
            line.TextState.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(line);
            var products = new TextFragment($"Nombre de produits : ***{numberOfPrescriptionsText}***");
            products.TextState.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(products);
            var patientInfos = new TextFragment($"Patient : {genderText}, {ageText} ans");
            page.Paragraphs.Add(patientInfos);

            document.Save(System.IO.Path.Combine(pathText, "Ordonnance pour " + patientNameText + ".pdf"));
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int totalProgress = 100;
            for (int progress = 0; progress <= totalProgress; progress++)
            {
                backgroundWorker.ReportProgress(progress);

                System.Threading.Thread.Sleep(50);
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Le téléchargement est terminé");
        }
    }
}