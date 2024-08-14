using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASRFLY.Properties;

namespace ASRFLY.Code
{
    public static class MessageCollections
    {
        //Message
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption,
              MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //DIALOGE
    }
}
