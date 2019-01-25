
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using EricCore.UsbCmder;
using EricCore.Utilitys;

namespace UsbCmder {
    public partial class MainWindow : Window {
        UsbCmderCtrller m_usbCmder = new UsbCmderCtrller();
        Utility m_u = new Utility();

        public MainWindow() {
            InitializeComponent();
            List<TextBox> txtCdb = new List<TextBox>(16);

            txtCdb.Add(m_txtCdb_00);
            txtCdb.Add(m_txtCdb_01);
            txtCdb.Add(m_txtCdb_02);
            txtCdb.Add(m_txtCdb_03);
            txtCdb.Add(m_txtCdb_04);
            txtCdb.Add(m_txtCdb_05);
            txtCdb.Add(m_txtCdb_06);
            txtCdb.Add(m_txtCdb_07);
            txtCdb.Add(m_txtCdb_08);
            txtCdb.Add(m_txtCdb_09);
            txtCdb.Add(m_txtCdb_10);
            txtCdb.Add(m_txtCdb_11);
            txtCdb.Add(m_txtCdb_12);
            txtCdb.Add(m_txtCdb_13);
            txtCdb.Add(m_txtCdb_14);
            txtCdb.Add(m_txtCdb_15);

            UsbCmderView view = new UsbCmderView();
            view.init(txtCdb, m_cboCmdSel, m_txtDataLength, m_rdoDataIn,m_rdoDataOut, m_txtMsg_1st, m_txtMsg_2nd);
            m_usbCmder.init(view);
        }

        private void m_btnExecute_Click(object sender, RoutedEventArgs e) {
            m_usbCmder.execute();
        }

        private void m_cboCmdSel_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            m_usbCmder.m_view.cmd_select_changebind_cmd_sel();
        }

        private void m_btnRefresh_Click(object sender, RoutedEventArgs e) {
            m_usbCmder.refresh();
        }
    }
}
