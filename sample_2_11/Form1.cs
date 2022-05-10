using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sample_2_11 {
  public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
    public Form1() {
      InitializeComponent();
    }

    private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e) {
      Close();
    }
  }
}
