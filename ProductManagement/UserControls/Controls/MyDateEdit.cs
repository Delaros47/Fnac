using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
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
    public class MyDateEdit : DateEdit
    {
        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;

        }

        public override bool EnterMoveNextControl { get; set; } = true;

    }
}
