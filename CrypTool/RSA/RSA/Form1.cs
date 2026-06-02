using RSAVirtualization;
using System;
using System.Windows.Forms;
using System.Numerics;

namespace RSA
{
    public partial class Form1 : Form
    {
        private static readonly Random rnd = new Random();
        RSACore rsaAlgorithm = new RSACore();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa kết quả cũ trước khi tính toán mới
                txtCipher.Clear();
                txtDecrypted.Clear();

                rsaAlgorithm.InitializeKeys(txtP.Text, txtQ.Text, txtE.Text);

                txtN.Text = rsaAlgorithm.N.ToString();
                txtPhi.Text = rsaAlgorithm.PhiN.ToString();
                txtD.Text = rsaAlgorithm.D.ToString();

                MessageBox.Show("Tính N, Phi(N) và Khóa bí mật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào các ô p, q và e!\nChi tiết lỗi: " + ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string plainText = txtMessage.Text;
                if (string.IsNullOrEmpty(plainText)) return;

                txtDecrypted.Clear();
                string cipherTextResult = "";

                // 1. Xóa sạch màn hình log cũ và in tiêu đề
                rtbSteps.Clear();
                rtbSteps.AppendText("=== BẮT ĐẦU QUÁ TRÌNH MÃ HÓA ===\n\n");

                foreach (char character in plainText)
                {
                    BigInteger m = new BigInteger((int)character);

                    if (m >= rsaAlgorithm.N)
                    {
                        MessageBox.Show("Khóa N quá nhỏ để mã hóa ký tự này. Hãy sinh P và Q lớn hơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Gọi hàm mã hóa
                    BigInteger c = rsaAlgorithm.Encrypt(m);
                    cipherTextResult += c.ToString() + " ";

                    // 2. Ghi log từng bước ra màn hình
                    rtbSteps.AppendText($"• Ký tự: '{character}' -> Chuyển thành số (M) = {m}\n");
                    rtbSteps.AppendText($"  Công thức áp dụng: C = M^E mod N\n");
                    rtbSteps.AppendText($"  Tính toán: C = {m}^{rsaAlgorithm.E} mod {rsaAlgorithm.N}\n");
                    rtbSteps.AppendText($"  => Bản mã (C) = {c}\n");
                    rtbSteps.AppendText(new string('-', 40) + "\n"); // Dòng kẻ phân cách
                }

                txtCipher.Text = cipherTextResult.Trim();
                rtbSteps.AppendText("\n>>> HOÀN TẤT MÃ HÓA! <<<\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mã hóa. Đảm bảo bạn đã tính toán bộ khóa trước!\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string cipherText = txtCipher.Text;
                if (string.IsNullOrEmpty(cipherText)) return;

                string decryptedTextResult = "";
                string[] numberStrings = cipherText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // 1. Xóa sạch màn hình log cũ và in tiêu đề
                rtbSteps.Clear();
                rtbSteps.AppendText("=== BẮT ĐẦU QUÁ TRÌNH GIẢI MÃ ===\n\n");

                foreach (string numStr in numberStrings)
                {
                    BigInteger c = BigInteger.Parse(numStr);

                    // Gọi hàm giải mã
                    BigInteger m = rsaAlgorithm.Decrypt(c);
                    char character = (char)(int)m;
                    decryptedTextResult += character;

                    // 2. Ghi log từng bước ra màn hình
                    rtbSteps.AppendText($"• Nhận bản mã (C) = {c}\n");
                    rtbSteps.AppendText($"  Công thức áp dụng: M = C^D mod N\n");
                    rtbSteps.AppendText($"  Tính toán: M = {c}^{rsaAlgorithm.D} mod {rsaAlgorithm.N}\n");
                    rtbSteps.AppendText($"  => Phục hồi số (M) = {m} -> Ký tự: '{character}'\n");
                    rtbSteps.AppendText(new string('-', 40) + "\n");
                }

                txtDecrypted.Text = decryptedTextResult;
                rtbSteps.AppendText("\n>>> HOÀN TẤT GIẢI MÃ! <<<\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi giải mã: Bản mã không đúng định dạng!\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetRandomPrime(int min, int max)
        {
            int primeCandidate;
            do
            {
                primeCandidate = rnd.Next(min, max);
            }
            // Gọi hàm IsPrime từ RSACore thay vì viết lại
            while (!rsaAlgorithm.IsPrime(primeCandidate));

            return primeCandidate;
        }

        private void btnGeneratePrimes_Click(object sender, EventArgs e)
        {
            // Reset toàn bộ UI để tránh người dùng quên bấm nút Tính toán khóa
            txtN.Clear();
            txtPhi.Clear();
            txtD.Clear();
            txtCipher.Clear();
            txtDecrypted.Clear();

            int p = GetRandomPrime(300, 999);
            int q = GetRandomPrime(300, 999);
            while (p == q)
            {
                q = GetRandomPrime(300, 999);
            }

            txtP.Text = p.ToString();
            txtQ.Text = q.ToString();

            BigInteger phi = BigInteger.Multiply(p - 1, q - 1);
            BigInteger e_val = 3;

            while (rsaAlgorithm.CalculateGCD(e_val, phi) != 1)
            {
                e_val += 2;
            }
            txtE.Text = e_val.ToString();
        }
    }
}