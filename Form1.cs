/*
 * icon attribute: https://www.flaticon.com/free-icon/sha_1468174?term=sha+256&page=1&position=19&origin=tag&related_id=1468174
 */

using static Check_SHA256_Of_A_File.DebugHelper;
using System.Security.Cryptography;
namespace Check_SHA256_Of_A_File
{
    public partial class Form1 : Form
    {
        const string TrueMessage = "Two hashes are identical";
        const string FalseMessage = "Two hashes are different";
        string TheSHA;
        string FileName;
        public Form1()
        {
            InitializeComponent();
            DebugHelper.InitializeDebugHelperTools(ref Prompter);
        }
        void hashesAreSame()
        {
            ResultLabel.Text = TrueMessage;
            ResultLabel.ForeColor = Color.Green;
            cm("Hash: " + TheSHA + " For the file: " + FileName);
        }
        void hashesAreDifferent()
        {
            ResultLabel.Text = FalseMessage;
            ResultLabel.ForeColor = Color.Red;
            cm("Hash: " + TheSHA + " For the file: " + FileName);
        }
        void noCompare()
        {
            ResultLabel.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (GivenHash.Text != "" && TheSHA != null)
            {
                if (GivenHash.Text == TheSHA)
                    hashesAreSame();
                else
                    hashesAreDifferent();
            }
            else
            {
                cm("error! There is no a file dropped or empty hash text box.");
                noCompare();
            }
                
        }

        private void All_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] FileNames = e.Data.GetData(DataFormats.FileDrop) as string[];
                FileName = Path.GetFileName(FileNames[0]);
                cm("File Added: " + FileName);
                
                using (SHA256 SHA256 = SHA256Managed.Create())
                {
                    using (FileStream fileStream = File.OpenRead(FileNames[0]))
                        TheSHA = BitConverter.ToString(SHA256.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
                }
                cm("SHA256 = " + TheSHA);
            }
            catch
            {
                cm("File couldn't add. Try again.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void All_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}