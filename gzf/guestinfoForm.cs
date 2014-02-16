using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace gzf
{
    public partial class guestinfoForm : Form
    {
        private model.Guest guest;
        private string imagePath = "";
        private int result = 100;
        public guestinfoForm(model.Guest guest)
        {
            InitializeComponent();
            this.guest = guest;
            txtName.Text = guest.Name;
            txtIDCard.Text = guest.Idcard;
            txtPhone.Text = guest.Phone;
            txtAdress.Text = guest.Address;
            txtRemark.Text = guest.Remark;
            txtStudent.Text = guest.Student;
            if (guest.Birthday > dateBirthday.MinDate)
            {
                dateBirthday.Value = guest.Birthday;
            }
            comboBoxCompany.DataSource = common.getCompany();
            comboBoxCompany.DisplayMember = "name";
            comboBoxCompany.SelectedItem = null;
            comboBoxSex.SelectedIndex = guest.Sex;
            comboBoxJob.Text = guest.Job;
            comboBoxCompany.Text = guest.Company;
            if (guest.Pic != null)
            {
                pictureBox1.Image = guest.Pic;
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string path = Path.GetTempFileName() + ".bmp";
            Byte[] bytes = new Byte[0];
            FileStream fs;
            if (result == 100)
            {
                pictureBox1.Image.Save(path);
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            else
            {
                fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            }
            //pictureBox1.Image.Save(path);
            //FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            bytes = new Byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Close();
            string cmd = "update gzf_guest set name='" + txtName.Text + "', idcard='" + txtIDCard.Text + "', birthday='" + dateBirthday.Value + "', sex=" + comboBoxSex.SelectedIndex + ", phone='" + txtPhone.Text + "', address='" + txtAdress.Text + "', remark='" + txtRemark.Text + "', job='" + comboBoxJob.Text + "', company='" + comboBoxCompany.Text + "', student='" + txtStudent.Text + "',pic=@Picture where id=" + guest.Id;
            int dbcount = DB.exec_NonQuery(cmd, bytes);
            if (dbcount > 0)
            {
                MessageBox.Show("保存成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
        }

        private void guestinfoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClipBorad_Click(object sender, EventArgs e)
        {
            Bitmap image = common.getClipBordImage();
            if (image.Width != 1)
            {
                pictureBox1.Image = image;
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            //Card2.PERSONINFOW person = new Card2.PERSONINFOW();
            //int OpenResult = Card2.OpenCardReader(0, 0x04, 115200);
            //if (OpenResult == 0)
            //{
            //    imagePath = Path.GetTempPath() + "images.bmp";
            //    lblStatus.Text = "身份证读卡器已就绪...";
            //    try
            //    {
            //        result = Card2.GetPersonMsgW(ref person, imagePath);
            //    }
            //    catch
            //    {
            //        lblStatus.Text = "身份证读取失败,请重新尝试";
            //        Card2.CloseCardReader();
            //    }
            //    if (result == 0)
            //    {
            //        txtName.Text = person.name;
            //        txtIDCard.Text = person.cardId;
            //        txtAdress.Text = person.address;
            //        if (person.sex == "男")
            //        {
            //            comboBoxSex.SelectedIndex = 0;
            //        }
            //        else
            //        {
            //            comboBoxSex.SelectedIndex = 1;
            //        }
            //        dateBirthday.Value = Convert.ToDateTime(common.ConvertDate(person.birthday));
            //        FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //        StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
            //        sr.Read();
            //        pictureBox1.Image = new Bitmap(fs);
            //        sr.Close();
            //        lblStatus.Text = "读卡成功！";
            //        Card2.CloseCardReader();
            //    }

            //}
            //else
            //{
            //    lblStatus.Text = "身份证读卡器连接失败！";
            //}

            Card2.PERSONINFOW person = new Card2.PERSONINFOW();
            int OpenResult = Card2.OpenCardReader(0, 0x04, 115200);
            if (OpenResult == 0)
            {
                imagePath = Path.GetTempPath() + "images.bmp";
                lblStatus.Text = "身份证读卡器已就绪...";
                try
                {
                    result = Card2.GetPersonMsgW(ref person, imagePath);
                }
                catch
                {
                    lblStatus.Text = "身份证读取失败,请重新尝试";
                    Card2.CloseCardReader();
                }
                if (result == 0)
                {
                    txtName.Text = person.name;
                    txtIDCard.Text = person.cardId;
                    txtAdress.Text = person.address;
                    if (person.sex == "男")
                    {
                        comboBoxSex.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBoxSex.SelectedIndex = 1;
                    }
                    dateBirthday.Value = Convert.ToDateTime(common.ConvertDate(person.birthday));
                    FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
                    sr.Read();
                    pictureBox1.Image = new Bitmap(fs);
                    sr.Close();
                    lblStatus.Text = "读卡成功！";
                    Card2.CloseCardReader();
                }

            }
            else
            {
                lblStatus.Text = "身份证读卡器连接失败！";
            }
        }
    }
}
