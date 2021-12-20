using caffe.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Gucaffe.DAL;
using caffe.DAL;
using System.Windows.Forms;

namespace caffe.BLL
{
    class BLLQUANLY
    {
        frm_TaoBan taoban;

        public BLLQUANLY(frm_TaoBan b)
        {
            taoban = b;
        }

        public void loadBan()
        {
            quanly.gridViewQLB.DataSource = dalquanly.LoadBan();
        }

        public void checkTenBan()
        {
            string tenban = taoban.txt_tenban.Text;

            {

                if (tenban.Length > 0)
                {
                    bool check = dalquanly.checkTenBan(tenban);
                    MessageBox.Show(" " + tenban + " " + check);

                    if (check == false)
                    {
                        MessageBox.Show("Khong trung");

                        //taoban.lbl_checkTenban.Visible = true;
                        //taoban.lbl_loitenban.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("trung");
                        //taoban.lbl_loitenban.Visible = true;
                        //taoban.lbl_checkTenban.Visible = false;


                    }
                }
                else
                {
                    taoban.lbl_checkTenban.Visible = false;
                    taoban.lbl_loitenban.Visible = false;
                }
            }
        }
    }
}
