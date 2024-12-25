using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quang97291
{
    public partial class FrmPhongBan : Form
    {
        public FrmPhongBan()
        {
            InitializeComponent();
            LoadDgv();
        }

        private void LoadDgv()
        {
            dgv_load_pb.DataSource = Database.Query("select * from PhongBan_2");
            btn_sua.Enabled = btn_xoa.Enabled = dgv_load_pb.Rows.Count > 0;
        }

        private bool Check()
        {
            bool check = true;
            erp_loi.Clear();
            if(txt_id.Text.Trim() == "")
            {
                erp_loi.SetError(txt_id, "ID không được để trống");
                check = false;
            }
            if(txt_name.Text.Trim() == "")
            {
                erp_loi.SetError(txt_name, "Tên không được để trống");
                check = false;
            }
            if(txt_date.Text.Trim() == "")
            {
                erp_loi.SetError(txt_date, "Ngày thành lập không được để trống");
                check = false;
            }
            if(txt_pc.Text.Trim() == "")
            {
                erp_loi.SetError(txt_pc, "Phó chủ tịch không được để trống");
                check = false;
            }
            return check;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(Check() == false)
            {
                return;
            }
            string sql =
                "EXEC ThemPhongBan @MaPhongBan, @TenPhongBan, @NgayThanhLap, @PhuCap";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaPhongBan", txt_id.Text);
            dictionary.Add("@TenPhongBan", txt_name.Text);
            dictionary.Add("@NgayThanhLap", txt_date.Text);
            dictionary.Add("@PhuCap", txt_pc.Text);
            try
            {
                Database.Execute(sql, dictionary);
                LoadDgv();
                txt_id.Text = txt_name.Text = txt_date.Text = txt_pc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(Check() == false)
            {
                return;
            }
            string sql =
                "EXEC SuaPhongBan @MaPhongBan, @TenPhongBan, @NgayThanhLap, @PhuCap";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaPhongBan", txt_id.Text);
            dictionary.Add("@TenPhongBan", txt_name.Text);
            dictionary.Add("@NgayThanhLap", txt_date.Text);
            dictionary.Add("@PhuCap", txt_pc.Text);
            try
            {
                Database.Execute(sql, dictionary);
                LoadDgv();
                txt_id.Text = txt_name.Text = txt_date.Text = txt_pc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "EXEC XoaPhongBan @MaPhongBan";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaPhongBan", txt_id.Text);
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Database.Execute(sql, dictionary);
                    LoadDgv();
                    txt_id.Text = txt_name.Text = txt_date.Text = txt_pc.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_load_pb_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_load_pb.Rows[e.RowIndex].Cells["colMaPhongBan"].Value.ToString();
            txt_name.Text = dgv_load_pb.Rows[e.RowIndex].Cells["colTenPhongBan"].Value.ToString();
            txt_date.Text = dgv_load_pb.Rows[e.RowIndex].Cells["colNgayThanhLap"].Value.ToString();
            txt_pc.Text = dgv_load_pb.Rows[e.RowIndex].Cells["colPhuCap"].Value.ToString();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TimKiemPhongBan(@MaPhongBan, @TenPhongBan, @NgayThanhLap, @PhuCap)";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if(cb_find_id.Checked)
            {
                dictionary.Add("@MaPhongBan", txt_find_id.Text);
            }
            else
            {
                dictionary.Add("@MaPhongBan", DBNull.Value);
            }
            if (cb_find_name.Checked)
            {
                dictionary.Add("@TenPhongBan", txt_find_name.Text);
            }
            else
            {
                dictionary.Add("@TenPhongBan", DBNull.Value);
            }
            if(cb_find_date.Checked)
            {
                dictionary.Add("@NgayThanhLap", txt_find_date.Text);
            }
            else
            {
                dictionary.Add("@NgayThanhLap", DBNull.Value);
            }
            if(cb_find_pc.Checked)
            {
                dictionary.Add("@PhuCap", txt_find_pc.Text);
            }
            else
            {
                dictionary.Add("@PhuCap", DBNull.Value);
            }
            dgv_load_pb.DataSource = Database.Query(sql, dictionary);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            LoadDgv();
            txt_find_id.Text = txt_find_name.Text = txt_find_date.Text = txt_find_pc.Text = "";
            cb_find_id.Checked = cb_find_name.Checked = cb_find_date.Checked = cb_find_pc.Checked = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || txt_id.Text.Length >= 3)
            {
                e.Handled = true;
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || txt_name.Text.Length >= 50)
            {
                e.Handled = true;
            }
        }

        private void txt_date_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txt_pc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
