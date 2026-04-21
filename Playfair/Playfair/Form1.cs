namespace Playfair
{
    public partial class Form1 : Form
    {
        // Trạng thái cho Tab 5x5
        private bool isPaused5 = false;
        private bool isRunning5 = false;

        // Trạng thái cho Tab 6x6
        private bool isPaused6 = false;
        private bool isRunning6 = false;

        public class PlayfairState
        {
            public bool IsPaused { get; set; } = false;
            public bool IsRunning { get; set; } = false;
            public bool RequestStop { get; set; } = false;
        }

        private PlayfairState state5 = new PlayfairState();
        private PlayfairState state6 = new PlayfairState();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitMatrixGrid(tlpMatrix5x5, 5);
            InitMatrixGrid(tlpMatrix6x6, 6);
        }

        private void InitMatrixGrid(TableLayoutPanel tlp, int size)
        {
            tlp.Controls.Clear(); // Xóa các thứ đang có (nếu có)

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Label lbl = new Label();
                    lbl.Name = $"lbl_{row}_{col}"; // Đặt tên theo tọa độ
                    lbl.Text = "";                 // Sẽ gán ký tự ma trận sau
                    lbl.Dock = DockStyle.Fill;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    //lbl.BorderStyle = BorderStyle.None; // Thêm khung cho dễ nhìn
                    lbl.Margin = new Padding(0);   // Khít sát ô
                    lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                    // Thêm vào TableLayoutPanel đúng vị trí cột, hàng
                    tlp.Controls.Add(lbl, col, row);
                }
            }
        }

        private void UpdateStepInfo(string b1, string b2, string p1, string p2)
        {
            tbBKey1.Text = b1;
            tbBKey2.Text = b2;
            tbPKey1.Text = p1;
            tbPKey2.Text = p2;
        }

        // Hàm hiển thị mảng ký tự lên TableLayoutPanel
        private void FillMatrixToGrid(TableLayoutPanel tlp, char[,] matrix, int size)
        {
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    // Tìm đúng Label theo tên đã đặt lúc Init
                    Control ctrl = tlp.Controls.Find($"lbl_{r}_{c}", true).FirstOrDefault();
                    if (ctrl is Label lbl)
                    {
                        lbl.Text = matrix[r, c].ToString();
                        lbl.BackColor = Color.Transparent; // Reset màu về mặc định
                    }
                }
            }
        }

        // Hàm tô màu một ô cụ thể
        private void HighlightCell(TableLayoutPanel tlp, int row, int col, Color color)
        {
            Control ctrl = tlp.Controls.Find($"lbl_{row}_{col}", true).FirstOrDefault();
            if (ctrl is Label lbl)
            {
                lbl.BackColor = color;
            }
        }

        private char[,] GenerateMatrix(string key, int size)
        {
            /*string alphabet = (size == 5) ? "ABCDEFGHIKLMNOPQRSTUVWXYZ" : "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            key = key.ToUpper().Replace("J", "I"); // Playfair 5x5 thường gộp I/J

            string combined = key + alphabet;
            string distinctKey = "";

            // Lấy các ký tự duy nhất
            foreach (char c in combined)
            {
                if (!distinctKey.Contains(c)) distinctKey += c;
            }

            char[,] matrix = new char[size, size];
            for (int i = 0; i < size * size; i++)
            {
                matrix[i / size, i % size] = distinctKey[i];
            }
            return matrix;*/
            string alphabet = "";
            //key = key.ToUpper();
            key = key.Replace(" ", "").ToUpper();

            if (size == 5)
            {
                alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; // Không có J
                key = key.Replace("J", "I");
            }
            else // size == 6
            {
                alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                // 6x6 không cần gộp J thành I, giữ nguyên cả hai
            }

            string combined = key + alphabet;
            string distinctKey = "";

            foreach (char c in combined)
            {
                if (!distinctKey.Contains(c)) distinctKey += c;
            }

            char[,] matrix = new char[size, size];
            for (int i = 0; i < size * size; i++)
            {
                matrix[i / size, i % size] = distinctKey[i];
            }
            return matrix;
        }

        private List<string> SplitIntoPairs(string text, int size)
        {
            /*text = text.ToUpper().Replace("J", "I").Replace(" ", "");
            List<string> pairs = new List<string>();

            for (int i = 0; i < text.Length; i += 2)
            {
                if (i == text.Length - 1)
                {
                    pairs.Add(text[i] + "X");
                }
                else if (text[i] == text[i + 1])
                {
                    pairs.Add(text[i] + "X");
                    i--; // Lùi lại để ký tự bị trùng lặp kết hợp với chữ tiếp theo
                }
                else
                {
                    pairs.Add(text[i].ToString() + text[i + 1].ToString());
                }
            }
            return pairs;*/

            // 1. Lọc dữ liệu: Chỉ giữ lại ký tự hợp lệ
            /*string validChars = "";
            text = text.ToUpper().Replace("J", "I"); // Chuẩn hóa I/J cho Playfair

            foreach (char c in text)
            {
                if (size == 5)
                {
                    // Chỉ lấy chữ cái A-Z
                    if (c >= 'A' && c <= 'Z') validChars += c;
                }
                else // size == 6
                {
                    // Lấy chữ cái A-Z và số 0-9
                    if ((c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')) validChars += c;
                }
            }

            // 2. Chia cặp trên chuỗi đã lọc (giữ nguyên logic cũ của bạn)
            List<string> pairs = new List<string>();
            for (int i = 0; i < validChars.Length; i += 2)
            {
                if (i == validChars.Length - 1)
                    pairs.Add(validChars[i] + "X");
                else if (validChars[i] == validChars[i + 1])
                {
                    pairs.Add(validChars[i] + "X");
                    i--;
                }
                else
                    pairs.Add(validChars[i].ToString() + validChars[i + 1].ToString());
            }
            return pairs;*/
            text = text.ToUpper();
            if (size == 5) text = text.Replace("J", "I");

            // Lọc ký tự hợp lệ
            string validChars = "";
            foreach (char c in text)
            {
                if (size == 5 && c >= 'A' && c <= 'Z') validChars += c;
                else if (size == 6 && ((c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))) validChars += c;
            }

            List<string> pairs = new List<string>();
            for (int i = 0; i < validChars.Length; i += 2)
            {
                if (i == validChars.Length - 1) pairs.Add(validChars[i] + "X");
                else if (validChars[i] == validChars[i + 1])
                {
                    pairs.Add(validChars[i] + "X");
                    i--;
                }
                else pairs.Add(validChars[i].ToString() + validChars[i + 1].ToString());
            }
            return pairs;
        }

        private (int R, int C) FindPos(char[,] matrix, char c, int size)
        {
            for (int r = 0; r < size; r++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[r, col] == c) return (r, col);
                }
            }
            return (-1, -1);
        }

        private (int R1, int C1, int R2, int C2) PlayfairLogic((int R, int C) p1, (int R, int C) p2, int size, bool isEncrypt)
        {
            int r1 = p1.R, c1 = p1.C, r2 = p2.R, c2 = p2.C;
            int offset = isEncrypt ? 1 : -1;

            // Trường hợp 1: Cùng hàng -> Dịch ngang
            if (r1 == r2)
            {
                c1 = (c1 + offset + size) % size;
                c2 = (c2 + offset + size) % size;
            }
            // Trường hợp 2: Cùng cột -> Dịch dọc
            else if (c1 == c2)
            {
                r1 = (r1 + offset + size) % size;
                r2 = (r2 + offset + size) % size;
            }
            // Trường hợp 3: Hình chữ nhật -> Tráo góc
            else
            {
                int tempC1 = c1;
                c1 = c2;
                c2 = tempC1;
            }

            return (r1, c1, r2, c2);
        }

        private async Task ProcessPlayfair(int size, TextBox txtKey, RichTextBox rtbInput, RichTextBox rtbOutput,
            TableLayoutPanel tlp, ComboBox cbOption, TextBox b1, TextBox b2, TextBox p1, TextBox p2, PlayfairState state,
            /*Button btn,*/ Button btnCal, Button btnControl, Button btnStop, bool isFast = false)
        {
            // Khởi tạo trạng thái
            state.IsRunning = true;
            state.IsPaused = false;
            state.RequestStop = false;
            rtbOutput.Clear();
            btnCal.Enabled = false;

            btnCal.Enabled = false;

            char[,] matrix = GenerateMatrix(txtKey.Text, size);
            FillMatrixToGrid(tlp, matrix, size);

            // CHỈ bật các nút điều khiển nếu KHÔNG PHẢI chế độ nhanh
            if (!isFast)
            {
                btnControl.Enabled = true;
                btnControl.Text = "Tạm dừng";
                btnStop.Enabled = true;
            }
            else
            {
                // Chế độ nhanh thì khóa chặt các nút này
                btnControl.Enabled = false;
                btnStop.Enabled = false;
            }

            List<string> pairs = SplitIntoPairs(rtbInput.Text, size);
            bool isEncrypt = (cbOption.SelectedIndex == 0);
            //rtbOutput.Clear();

            foreach (string pair in pairs)
            {
                // Kiểm tra nếu người dùng bấm Hủy
                if (state.RequestStop) break;
                
                var pos1 = FindPos(matrix, pair[0], size);
                var pos2 = FindPos(matrix, pair[1], size);
                var res = PlayfairLogic(pos1, pos2, size, isEncrypt);
                char res1 = matrix[res.R1, res.C1];
                char res2 = matrix[res.R2, res.C2];

                if (isFast)
                {
                    rtbOutput.AppendText($"{res1}{res2} ");
                }
                else
                {
                    //CƠ CHẾ TẠM DỪNG 
                    while (state.IsPaused)
                    {
                        await Task.Delay(100);
                        // Kiểm tra nếu người dùng bấm Hủy
                        if (state.RequestStop) break;
                    }// Thoát nếu bị hủy
                    if (state.RequestStop) break;

                    // Highlight, cập nhật UI Before
                    HighlightCell(tlp, pos1.R, pos1.C, Color.Yellow);
                    HighlightCell(tlp, pos2.R, pos2.C, Color.Yellow);
                    b1.Text = pair[0].ToString(); b2.Text = pair[1].ToString();
                    p1.Clear(); p2.Clear();

                    await Task.Delay(300);

                    HighlightCell(tlp, res.R1, res.C1, Color.LightGreen);
                    HighlightCell(tlp, res.R2, res.C2, Color.LightGreen);
                    p1.Text = res1.ToString(); p2.Text = res2.ToString();
                    rtbOutput.AppendText($"{res1}{res2} ");

                    await Task.Delay(400);

                    // Reset màu ô vừa xử lý
                    HighlightCell(tlp, pos1.R, pos1.C, Color.Transparent);
                    HighlightCell(tlp, pos2.R, pos2.C, Color.Transparent);
                    HighlightCell(tlp, res.R1, res.C1, Color.Transparent);
                    HighlightCell(tlp, res.R2, res.C2, Color.Transparent);
                }
            }
            // Kết thúc tiến trình
            state.IsRunning = false;
            btnControl.Enabled = false;
            btnStop.Enabled = false;
            btnCal.Enabled = true;
        }

        private async void btnCal5x5_Click(object sender, EventArgs e)
        {
            await ProcessPlayfair(5, tbKey5x5, tbInput5x5, tbOutput5x5, tlpMatrix5x5, cbOption5x5, tbBKey1, tbBKey2, tbPKey1, tbPKey2, state5, btnCal5x5, btnProcessControl5, btnCancel5);
        }

        private async void btnCal6x6_Click(object sender, EventArgs e)
        {
            await ProcessPlayfair(6, tbKey6x6, tbInput6x6, tbOutput6x6, tlpMatrix6x6, cbOption6x6, tbBKey3, tbBKey4, tbPKey3, tbPKey4, state6, btnCal6x6, btnProcessControl6, btnCancel6);
        }

        private void tbKey5x5_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = tbKey5x5.SelectionStart; // Lưu vị trí con trỏ
            string originalText = tbKey5x5.Text;

            if (originalText.Contains(" "))
            {
                // Loại bỏ tất cả khoảng trắng
                tbKey5x5.Text = originalText.Replace(" ", "");

                // Trả lại con trỏ về vị trí cũ (tránh bị nhảy về đầu dòng)
                tbKey5x5.SelectionStart = Math.Max(0, cursorPosition - 1);
            }
        }

        private void tbKey6x6_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = tbKey6x6.SelectionStart; // Lưu vị trí con trỏ
            string originalText = tbKey6x6.Text;

            if (originalText.Contains(" "))
            {
                // Loại bỏ tất cả khoảng trắng
                tbKey6x6.Text = originalText.Replace(" ", "");

                // Trả lại con trỏ về vị trí cũ (tránh bị nhảy về đầu dòng)
                tbKey6x6.SelectionStart = Math.Max(0, cursorPosition - 1);
            }
        }

        private void btnProcessControl5_Click(object sender, EventArgs e)
        {
            if (!state5.IsRunning) return; // Chỉ có tác dụng khi đang chạy mã hóa

            state5.IsPaused = !state5.IsPaused; // Đảo trạng thái
            btnProcessControl5.Text = state5.IsPaused ? "Tiếp tục" : "Tạm dừng";
        }

        private void btnProcessControl6_Click(object sender, EventArgs e)
        {
            if (!state6.IsRunning) return; // Chỉ có tác dụng khi đang chạy mã hóa

            state6.IsPaused = !state6.IsPaused; // Đảo trạng thái
            btnProcessControl6.Text = state6.IsPaused ? "Tiếp tục" : "Tạm dừng";
        }

        private void btnCancel5_Click(object sender, EventArgs e)
        {
            if (state5.IsRunning)
            {
                state5.RequestStop = true;
                state5.IsPaused = false; // Giải phóng nếu đang ở trạng thái tạm dừng

                // Xóa toàn bộ nội dung ô Output khi hủy
                tbOutput5x5.Clear();

                // Có thể xóa thêm các ô phụ nếu muốn hoàn toàn "sạch"
                tbBKey1.Clear();
                tbBKey2.Clear();
                tbPKey1.Clear();
                tbPKey2.Clear();
            }
        }

        private void btnCancel6_Click(object sender, EventArgs e)
        {
            if (state6.IsRunning)
            {
                state6.RequestStop = true;
                state6.IsPaused = false;

                tbOutput6x6.Clear();

                tbBKey3.Clear();
                tbBKey4.Clear();
                tbPKey3.Clear();
                tbPKey4.Clear();
            }
        }

        private async void btnResult5_Click(object sender, EventArgs e)
        {
            await ProcessPlayfair(5, tbKey5x5, tbInput5x5, tbOutput5x5, tlpMatrix5x5, cbOption5x5, tbBKey1, tbBKey2, tbPKey1, tbPKey2, state5, btnCal5x5, btnProcessControl5, btnCancel5, true);
        }

        private async void btnResult6_Click(object sender, EventArgs e)
        {
            await ProcessPlayfair(6, tbKey6x6, tbInput6x6, tbOutput6x6, tlpMatrix6x6, cbOption6x6, tbBKey3, tbBKey4, tbPKey3, tbPKey4, state6, btnCal6x6, btnProcessControl6, btnCancel6, true);
        }
    }
}
