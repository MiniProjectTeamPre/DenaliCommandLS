using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenaliCommandLS {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
            resizeAuto = new ResizeAuto(this);
        }

        #region =============================================== Input ===============================================
        private ResizeAuto resizeAuto;
        #endregion

        #region =============================================== Display ===============================================

        #endregion

        #region =============================================== Cal ===============================================

        #endregion

        #region =============================================== Main ===============================================
        private void FormMain_Load(object sender, EventArgs e) {



            resizeAuto.Initial();
        }
        private void FormMain_Resize(object sender, EventArgs e) {
            resizeAuto.Resize();
            resizeAuto.Resize();
        }
        #endregion


    }
}
