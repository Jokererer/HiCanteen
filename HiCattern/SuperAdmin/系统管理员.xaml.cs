using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
//using System.Windows.Forms;
//using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HiCattern.Login;
using HiCattern.SuperAdmin;
using Hi食堂.service;


namespace Hi_食堂.SuperAdmin
{
    /// <summary>
    /// 系统管理员.xaml 的交互逻辑
    /// </summary>
    public partial class 系统管理员 : Window
    {
        public 系统管理员()
        {
            this.InitializeComponent();
        }

        private void btn_BackHomepage_Click(object sender, RoutedEventArgs e)
        {
            TheLogin backHomepage = new TheLogin();
            this.Close();
            backHomepage.Show();
        }

        private void btn_AddMerchantAdmin_Click(object sender, RoutedEventArgs e)
        {
            增加商家管理员 addMerchantAdmin = new 增加商家管理员();
            addMerchantAdmin.Show();
        }

        private void MerAdmiLoad(object sender, RoutedEventArgs e)
        {
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showAllMerAdmi();
            dg1.ItemsSource = dt.DefaultView;
        }

        //商家管理员-查询按钮
        private void btn_queryMerAdmi_Click(object sender, RoutedEventArgs e)
        {
            int merAdmiID = int.Parse(Text_MerAdmiID.Text);
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showOneMerAdmi(merAdmiID);
            dg1.ItemsSource = dt.DefaultView;
        }
        //商家管理员-刷新按钮
        private void btn_refresh_Click(object sender, RoutedEventArgs e)
        {
            MerAdmiLoad(sender,e);
        }
        //商家管理-商家加载
        private void MerLoad(object sender, RoutedEventArgs e)
        {
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showAllMer();
            dt.Columns[0].ColumnName = "账号";
            dt.Columns[1].ColumnName = "商家名称";
            dt.Columns[2].ColumnName = "密码";
            dt.Columns[3].ColumnName = "电话号码";
            dt.Columns[4].ColumnName = "食堂地址";
            dg2.ItemsSource = dt.DefaultView;
        }
        //商家管理-账号查询按钮
        private void btn_queryMerID_Click(object sender, RoutedEventArgs e)
        {
            int merID = int.Parse(Text_Mer.Text);
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showOneMerByID(merID);
            dt.Columns[0].ColumnName = "账号";
            dt.Columns[1].ColumnName = "商家名称";
            dt.Columns[2].ColumnName = "密码";
            dt.Columns[3].ColumnName = "电话号码";
            dt.Columns[4].ColumnName = "食堂地址";
            dg2.ItemsSource = dt.DefaultView;
        }
        //商家管理-名称查询按钮
        private void btn_queryMerName_Click(object sender, RoutedEventArgs e)
        {
            string merName = Text_Mer.Text;
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showOneMerByName(merName);
            dt.Columns[0].ColumnName = "账号";
            dt.Columns[1].ColumnName = "商家名称";
            dt.Columns[2].ColumnName = "密码";
            dt.Columns[3].ColumnName = "电话号码";
            dt.Columns[4].ColumnName = "食堂地址";
            dg2.ItemsSource = dt.DefaultView;
        }
        //商家管理-刷新按钮
        private void btn_refreshMer_Click(object sender, RoutedEventArgs e)
        {
            MerLoad(sender, e);
        }
        //顾客管理-显示顾客
        private void CustomerLoad(object sender, RoutedEventArgs e)
        {
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showAllCustoms();
            dg3.ItemsSource = dt.DefaultView;
        }
        //顾客管理-ID查询按钮
        private void btn_queryCusByID_Click(object sender, RoutedEventArgs e)
        {
            int cusID = int.Parse(Text_Cus.Text);
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showOneCustomID(cusID);
            dg3.ItemsSource = dt.DefaultView;
        }
        //顾客管理-手机号查询按钮
        private void btn_queryCusByPh_Click(object sender, RoutedEventArgs e)
        {
            string cusName = Text_Cus.Text;
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showOneCustomPh(cusName);
            dg3.ItemsSource = dt.DefaultView;
        }
        //顾客管理-刷新按钮
        private void btn_refreshCus_Click(object sender, RoutedEventArgs e)
        {
            CustomerLoad(sender, e);
        }
        //订单管理-显示订单
        private void OrderLoad(object sender, RoutedEventArgs e)
        {
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showAllOrders();
            dg4.ItemsSource = dt.DefaultView;
        }

        //订单管理-订单ID查询按钮
        private void btn_queryByOr_Click(object sender, RoutedEventArgs e)
        {
            int orderID = int.Parse(Text_Cus.Text);
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showOneOrder(orderID);
            dg4.ItemsSource = dt.DefaultView;
        }
        //订单管理-商家ID查询按钮
        private void btn_queryByMer_Click(object sender, RoutedEventArgs e)
        {
            int merID = int.Parse(Text_Cus.Text);
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showMerOrders(merID);
            dg4.ItemsSource = dt.DefaultView;
        }
        //订单管理-顾客ID查询按钮
        private void btn_queryByCus_Click(object sender, RoutedEventArgs e)
        {
            int cusID = int.Parse(Text_Cus.Text);
            SysAdmiService sysService = new SysAdmiService();
            DataTable dt = sysService.showCusOrders(cusID);
            dg4.ItemsSource = dt.DefaultView;
        }
        //订单管理-刷新按钮
        private void btn_refreshOr_Click(object sender, RoutedEventArgs e)
        {
            OrderLoad(sender, e);
        }
        //商家管理员——编辑按钮
        private void btn_editMerAdmi(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null)
            {
                int id = Convert.ToInt32(btn.Tag);

                editMerAdmi edit = new editMerAdmi(id);
                edit.Show();
            }

        }
        //商家管理员-删除按钮
        private void btn_deleMerAdmi(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if(btn!=null)
            {
                SysAdmiService sysAdmiService = new SysAdmiService();
                int id = Convert.ToInt32(btn.Tag);
                /*if (MessageBox.Show("是否删除这个用户?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    MessageBox.Show("用户已删除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
                //MessageBoxButtons mess = MessageBoxButtons.OKCancel;
                //DialogResult dr = System.Windows.Forms.MessageBox.Show("是否删除这个用户?", "提示", mess, MessageBoxIcon.Question);
                /*if (dr == DialogResult.OK)
                {
                    return;
                }*/

                bool flag = sysAdmiService.deleteMerAdmi(id);
                if (flag)
                {
                   MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }

            }

        }
        //订单管理-删除按钮
        private void btn_deleOrder(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                int id = Convert.ToInt32(btn.Tag);
                SysAdmiService sysAdmi = new SysAdmiService();
                bool flag = sysAdmi.deleteOrder(id);
                if(flag)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }
        //骑手管理—查看骑手
        private void showRider(object sender, RoutedEventArgs e)
        {
            SysAdmiService sysMer = new SysAdmiService();
            DataTable dt = sysMer.showAllRiders();
            dg5.ItemsSource = dt.DefaultView;
        }
        //骑手管理—删除骑手
        private void btn_deleRider(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null)
            {
                SysAdmiService sysMer = new SysAdmiService();
                bool flag =sysMer.deleteRider(Convert.ToInt32(btn.Tag));
                if(flag)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }
        //骑手管理—ID查询按钮
        private void btn_queryByID_Click(object sender, RoutedEventArgs e)
        {
            SysAdmiService sysMer = new SysAdmiService();
            int riderID = int.Parse(txt_rider.Text);
            DataTable dt = sysMer.showRiderByID(riderID);
            dg5.ItemsSource = dt.DefaultView;
        }
        //骑手管理—电话查询按钮
        private void btn_queryByPh_Click(object sender, RoutedEventArgs e)
        {
            SysAdmiService sysMer = new SysAdmiService();
            string phone = txt_rider.Text;
            DataTable dt = sysMer.showRiderByPh(phone);
            dg5.ItemsSource = dt.DefaultView;
        }
        //骑手管理—刷新按钮
        private void btn_refreshRider_Click(object sender, RoutedEventArgs e)
        {
            showRider(sender, e);

        }
    }
}
