using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace AcceptComment
{
    public partial class rbnAcceptComment
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnAccept_Click(object sender, RibbonControlEventArgs e)
        {
            AcceptComment();
        }

        public void AcceptComment()
        {
            Excel.Range selection = Globals.ThisAddIn.Application.Selection;
            String comment;

            foreach (Excel.Range cell in selection)
            {
                if (cell.Comment != null)
                {
                    comment = cell.Comment.Text();
                    cell.Value = comment.Substring(tBoxStart.Text.Length, comment.Length - tBoxStart.Text.Length - tBoxEnd.Text.Length);
                    if (chBoxDelete.Checked)
                    {
                        cell.Comment.Delete();
                    }
                }
            }
        }
    }
}
