using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyMemoEdit : MemoEdit
    {
        public MyMemoEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 250;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
