using System.Windows.Forms;
using System.Drawing;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private readonly PasswordGenerator _generator = new();
        private readonly HistoryManager _historyManager = new();
        private string _currentPassword = string.Empty;

        public Form1()
        {
            InitializeComponent();
            LoadHistory();
            GeneratePassword();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        private void GeneratePassword()
        {
            if (!chkUppercase.Checked && !chkLowercase.Checked && !chkDigits.Checked && !chkSpecial.Checked)
            {
                MessageBox.Show("请至少选择一种字符类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int length = (int)numLength.Value;
                _currentPassword = _generator.Generate(
                    length,
                    chkUppercase.Checked,
                    chkLowercase.Checked,
                    chkDigits.Checked,
                    chkSpecial.Checked
                );
                txtPassword.Text = _currentPassword;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"生成密码时出错: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPassword.Text);
                
                // Visual feedback
                var originalColor = btnCopy.BackColor;
                btnCopy.BackColor = Color.FromArgb(16, 185, 129);
                btnCopy.Text = "已复制!";
                
                var timer = new System.Windows.Forms.Timer { Interval = 1000 };
                timer.Tick += (s, args) =>
                {
                    btnCopy.BackColor = originalColor;
                    btnCopy.Text = "复制";
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("请先生成密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SavePassword();
        }

        private void SavePassword()
        {
            var record = new PasswordRecord
            {
                Timestamp = DateTime.Now,
                Password = _currentPassword,
                Length = _currentPassword.Length,
                Rules = PasswordGenerator.GetRulesDescription(
                    chkUppercase.Checked,
                    chkLowercase.Checked,
                    chkDigits.Checked,
                    chkSpecial.Checked
                )
            };

            _historyManager.Add(record);
            LoadHistory();
            
            // Visual feedback
            var originalColor = btnSave.BackColor;
            btnSave.BackColor = Color.FromArgb(16, 185, 129);
            btnSave.Text = "已保存!";
            
            var timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += (s, args) =>
            {
                btnSave.BackColor = originalColor;
                btnSave.Text = "保存密码";
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void LoadHistory()
        {
            lstHistory.Items.Clear();
            var records = _historyManager.GetAll();
            
            foreach (var record in records)
            {
                var item = new ListViewItem(record.Timestamp.ToString("yyyy-MM-dd HH:mm:ss"));
                item.SubItems.Add(MaskPassword(record.Password));
                item.SubItems.Add(record.Length.ToString());
                item.SubItems.Add(record.Rules);
                item.Tag = record;
                lstHistory.Items.Add(item);
            }
        }

        private string MaskPassword(string password)
        {
            if (password.Length <= 4)
                return password;
            return password.Substring(0, 2) + "**" + password.Substring(password.Length - 2);
        }

        private void lstHistory_DoubleClick(object sender, EventArgs e)
        {
            if (lstHistory.SelectedItems.Count > 0)
            {
                var record = lstHistory.SelectedItems[0].Tag as PasswordRecord;
                if (record != null)
                {
                    Clipboard.SetText(record.Password);
                    MessageBox.Show("密码已复制到剪贴板！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstHistory.SelectedItems.Count > 0)
            {
                var record = lstHistory.SelectedItems[0].Tag as PasswordRecord;
                if (record != null)
                {
                    _historyManager.Remove(record);
                    LoadHistory();
                }
            }
            else
            {
                MessageBox.Show("请先选择要删除的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确定要清空所有历史记录吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _historyManager.Clear();
                LoadHistory();
            }
        }

        private void sliderLength_Scroll(object sender, EventArgs e)
        {
            numLength.Value = sliderLength.Value;
        }

        private void numLength_ValueChanged(object sender, EventArgs e)
        {
            sliderLength.Value = (int)numLength.Value;
        }
    }
}
