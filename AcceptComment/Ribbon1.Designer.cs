namespace AcceptComment
{
    partial class rbnAcceptComment : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public rbnAcceptComment()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.grpAcceptComment = this.Factory.CreateRibbonGroup();
            this.btnAccept = this.Factory.CreateRibbonButton();
            this.tBoxStart = this.Factory.CreateRibbonEditBox();
            this.tBoxEnd = this.Factory.CreateRibbonEditBox();
            this.chBoxDelete = this.Factory.CreateRibbonCheckBox();
            this.tab1.SuspendLayout();
            this.grpAcceptComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.grpAcceptComment);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // grpAcceptComment
            // 
            this.grpAcceptComment.Items.Add(this.btnAccept);
            this.grpAcceptComment.Items.Add(this.tBoxStart);
            this.grpAcceptComment.Items.Add(this.tBoxEnd);
            this.grpAcceptComment.Items.Add(this.chBoxDelete);
            this.grpAcceptComment.Label = "Accept Comment";
            this.grpAcceptComment.Name = "grpAcceptComment";
            // 
            // btnAccept
            // 
            this.btnAccept.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAccept.Label = "Přijmout komentář";
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.ShowImage = true;
            this.btnAccept.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAccept_Click);
            // 
            // tBoxStart
            // 
            this.tBoxStart.Label = "Počáteční řetězec";
            this.tBoxStart.MaxLength = 20;
            this.tBoxStart.Name = "tBoxStart";
            this.tBoxStart.SizeString = "Maxmilián Skočdopole: ";
            this.tBoxStart.Text = "(rev.0: ";
            // 
            // tBoxEnd
            // 
            this.tBoxEnd.Label = "Koncový řetězec";
            this.tBoxEnd.MaxLength = 20;
            this.tBoxEnd.Name = "tBoxEnd";
            this.tBoxEnd.SizeString = "Maxmilián Skočdopole: ";
            this.tBoxEnd.Text = ")";
            // 
            // chBoxDelete
            // 
            this.chBoxDelete.Label = "Po přijetí smazat";
            this.chBoxDelete.Name = "chBoxDelete";
            this.chBoxDelete.ScreenTip = "Po přijetí komentáře ho z buňky smaže";
            // 
            // rbnAcceptComment
            // 
            this.Name = "rbnAcceptComment";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.grpAcceptComment.ResumeLayout(false);
            this.grpAcceptComment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpAcceptComment;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAccept;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox tBoxStart;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox tBoxEnd;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox chBoxDelete;
    }

    partial class ThisRibbonCollection
    {
        internal rbnAcceptComment Ribbon1
        {
            get { return this.GetRibbon<rbnAcceptComment>(); }
        }
    }
}
