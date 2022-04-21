using System.Numerics;

namespace _3PD_Saugumas
{
    public partial class MainForm : Form
    {
        private string messageInput = "", finalResult = "";
        private int prime1, prime2;
        private List<BigInteger> messageValues = new List<BigInteger>();
        private MainCalculator calculator = new MainCalculator();
        private RSA_Algorithm algorithm = new RSA_Algorithm();

        public MainForm()
        {
            InitializeComponent();
            DecryptorPanel.Visible = false;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            int modulusN = calculator.CalculateModulusN(prime1, prime2);
            int phiTotientFunction = calculator.CalculatePhiTotientExponent(prime1, prime2);
            int eExponent = calculator.CalculateEncryptionExponent(phiTotientFunction);

            EncryptedOutputDecimal.Text = algorithm.EncryptMessage(messageInput, eExponent, modulusN);
            ModulusNOutput.Text = modulusN.ToString();
            PhiOutput.Text = phiTotientFunction.ToString();
            EncryptionEOutput.Text = eExponent.ToString();
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {
            messageInput = InputText.Text;
        }

        private void FirstPrimeInput_TextChanged(object sender, EventArgs e)
        {
            prime1 = int.Parse(FirstPrimeInput.Text);
        }

        private void EncryptorSelect_Click(object sender, EventArgs e)
        {
            EncryptorPanel.Visible = true;
            DecryptorPanel.Visible = false;
            finalResult = "";
            EncryptorSelect.FlatAppearance.BorderSize = 3;
            DecryptorSelect.FlatAppearance.BorderSize = 0;
        }

        private void DecryptorSelect_Click(object sender, EventArgs e)
        {
            DecryptorPanel.Visible = true;
            EncryptorPanel.Visible = false;
            finalResult = "";
            EncryptorSelect.FlatAppearance.BorderSize = 0;
            DecryptorSelect.FlatAppearance.BorderSize = 3;
        }

        private void DecyptSelect_Click(object sender, EventArgs e)
        {
            GetInputCipherValues();

            int modulusN = Convert.ToInt32(ModulusNInput.Text);
            List<int> nFactors = calculator.CalculateFactorsOfNumber(modulusN);
            int phiTotientFunction = calculator.CalculatePhiTotientExponent(nFactors[0], nFactors[1]);
            int eExponent = calculator.CalculateEncryptionExponent(phiTotientFunction);
            int privateExponent = calculator.CrackPrivateKey(eExponent, phiTotientFunction);

            FirstPrimeNumber.Text = nFactors[0].ToString();
            SecondPrimeNumbr.Text = nFactors[1].ToString();
            phiFunctionInput.Text = phiTotientFunction.ToString();
            publicExponentInput.Text = eExponent.ToString();
            PrivateExponentInput.Text = privateExponent.ToString();

            BigInteger[] output = algorithm.DecryptMessage(messageValues.ToArray(), modulusN, privateExponent);
            DecryptOutputChar.Text = algorithm.convertASCIIValuesToString(output);

            foreach (BigInteger value in output)
            {
                finalResult += value.ToString() + ",";
            }

            DecryptOutputDecimal.Text = finalResult;
            messageValues.Clear();
        }

        private void MessageInput_TextChanged(object sender, EventArgs e)
        {
            messageInput = MessageInput.Text;
        }

        private void SaveEncryptedData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(openFileDialog.FileName, EncryptedOutputDecimal.Lines[EncryptedOutputDecimal.Lines.Length - 1]);
            }

            if (!openFileDialog.FileName.Equals(""))
            {
                MessageBox.Show("Data was loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Failed to load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SavePublicKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(openFileDialog.FileName, EncryptionEOutput.Text);
            }

            if (!openFileDialog.FileName.Equals(""))
            {
                MessageBox.Show("Data was loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Failed to load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadEncryptedData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageInput.Text = "";
                MessageInput.Text = File.ReadAllText(openFileDialog.FileName);

                if (!MessageInput.Text.Equals(""))
                {
                    MessageBox.Show("Selected file was successfully loaded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Selected file failed to load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SecondPrimeInput_TextChanged(object sender, EventArgs e)
        {
            prime2 = int.Parse(SecondPrimeInput.Text);
        }

        private void GetInputCipherValues()
        {
            char[] messageChars = messageInput.ToCharArray();

            string digit = "";
            foreach (char c in messageChars)
            {
                if (char.IsDigit(c))
                {
                    digit += c.ToString();
                }

                if (digit == "," || c == messageChars[messageChars.Length - 1])
                {
                    messageValues.Add(Convert.ToInt32(digit));
                    digit = " ";
                }
            }
        }
    }
}