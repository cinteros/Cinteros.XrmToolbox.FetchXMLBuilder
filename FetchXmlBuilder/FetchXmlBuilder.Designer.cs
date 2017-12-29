namespace Cinteros.Xrm.FetchXmlBuilder
{
    partial class FetchXmlBuilder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FetchXmlBuilder));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbCloseThisTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenCWP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveCWP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveCs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToQureyExpression = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToCSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveJs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToJavascript = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveSql = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToSQLQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUndo = new System.Windows.Forms.ToolStripButton();
            this.tsbRedo = new System.Windows.Forms.ToolStripButton();
            this.tsbExecute = new System.Windows.Forms.ToolStripButton();
            this.tsbView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiShowOData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.resetWindowLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbReturnToCaller = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.tsbOptions = new System.Windows.Forms.ToolStripButton();
            this.panOData = new System.Windows.Forms.Panel();
            this.linkOData = new System.Windows.Forms.LinkLabel();
            this.menuOData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuODataExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.menuODataCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.panODataLabel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.dockContainer = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripMain.SuspendLayout();
            this.panOData.SuspendLayout();
            this.menuOData.SuspendLayout();
            this.panODataLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCloseThisTab,
            this.toolStripSeparator4,
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.toolStripSeparator6,
            this.tsbEdit,
            this.toolStripSeparator2,
            this.tsbUndo,
            this.tsbRedo,
            this.tsbExecute,
            this.tsbView,
            this.tsbReturnToCaller,
            this.toolStripSeparator3,
            this.tsbAbout,
            this.tsbOptions});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1101, 31);
            this.toolStripMain.TabIndex = 22;
            this.toolStripMain.Text = "toolStrip1";
            this.toolStripMain.Click += new System.EventHandler(this.toolStripMain_Click);
            // 
            // tsbCloseThisTab
            // 
            this.tsbCloseThisTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseThisTab.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloseThisTab.Image")));
            this.tsbCloseThisTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseThisTab.Name = "tsbCloseThisTab";
            this.tsbCloseThisTab.Size = new System.Drawing.Size(28, 28);
            this.tsbCloseThisTab.Text = "Close this tab";
            this.tsbCloseThisTab.ToolTipText = "Close FetchXML Builder";
            this.tsbCloseThisTab.Click += new System.EventHandler(this.tsbCloseThisTab_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(59, 28);
            this.tsbNew.Text = "New";
            this.tsbNew.ToolTipText = "New FetchXML (Ctrl+N)";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenFile,
            this.toolStripSeparator1,
            this.tsmiOpenView,
            this.tsmiOpenML,
            this.tsmiOpenCWP});
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(73, 28);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.ToolTipText = "Open FetchXML file";
            // 
            // tsmiOpenFile
            // 
            this.tsmiOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tsmiOpenFile.Image")));
            this.tsmiOpenFile.Name = "tsmiOpenFile";
            this.tsmiOpenFile.ShortcutKeyDisplayString = "Ctrl+O";
            this.tsmiOpenFile.Size = new System.Drawing.Size(240, 22);
            this.tsmiOpenFile.Text = "Open File...";
            this.tsmiOpenFile.Click += new System.EventHandler(this.tsmiOpenFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // tsmiOpenView
            // 
            this.tsmiOpenView.Image = ((System.Drawing.Image)(resources.GetObject("tsmiOpenView.Image")));
            this.tsmiOpenView.Name = "tsmiOpenView";
            this.tsmiOpenView.Size = new System.Drawing.Size(240, 22);
            this.tsmiOpenView.Text = "Open View...";
            this.tsmiOpenView.Click += new System.EventHandler(this.tsmiOpenView_Click);
            // 
            // tsmiOpenML
            // 
            this.tsmiOpenML.Image = ((System.Drawing.Image)(resources.GetObject("tsmiOpenML.Image")));
            this.tsmiOpenML.Name = "tsmiOpenML";
            this.tsmiOpenML.Size = new System.Drawing.Size(240, 22);
            this.tsmiOpenML.Text = "Open Dynamic Marketing List...";
            this.tsmiOpenML.Click += new System.EventHandler(this.tsmiOpenML_Click);
            // 
            // tsmiOpenCWP
            // 
            this.tsmiOpenCWP.Name = "tsmiOpenCWP";
            this.tsmiOpenCWP.Size = new System.Drawing.Size(240, 22);
            this.tsmiOpenCWP.Text = "Open CWP Feed...";
            this.tsmiOpenCWP.Click += new System.EventHandler(this.tsmiOpenCWP_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveFile,
            this.tsmiSaveFileAs,
            this.toolStripSeparator5,
            this.tsmiSaveView,
            this.tsmiSaveML,
            this.tsmiSaveCWP,
            this.toolStripMenuItem2,
            this.tsmiSaveCs,
            this.tsmiSaveJs,
            this.tsmiSaveSql});
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(68, 28);
            this.tsbSave.Text = "Save";
            this.tsbSave.ToolTipText = "Save FetchXML";
            // 
            // tsmiSaveFile
            // 
            this.tsmiSaveFile.Enabled = false;
            this.tsmiSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveFile.Image")));
            this.tsmiSaveFile.Name = "tsmiSaveFile";
            this.tsmiSaveFile.ShortcutKeyDisplayString = "Ctrl+S";
            this.tsmiSaveFile.Size = new System.Drawing.Size(226, 22);
            this.tsmiSaveFile.Text = "Save File";
            this.tsmiSaveFile.Click += new System.EventHandler(this.tsmiSaveFile_Click);
            // 
            // tsmiSaveFileAs
            // 
            this.tsmiSaveFileAs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveFileAs.Image")));
            this.tsmiSaveFileAs.Name = "tsmiSaveFileAs";
            this.tsmiSaveFileAs.ShortcutKeyDisplayString = "F12";
            this.tsmiSaveFileAs.Size = new System.Drawing.Size(226, 22);
            this.tsmiSaveFileAs.Text = "Save File as...";
            this.tsmiSaveFileAs.Click += new System.EventHandler(this.tsmiSaveFileAs_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(223, 6);
            // 
            // tsmiSaveView
            // 
            this.tsmiSaveView.Enabled = false;
            this.tsmiSaveView.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveView.Image")));
            this.tsmiSaveView.Name = "tsmiSaveView";
            this.tsmiSaveView.Size = new System.Drawing.Size(226, 22);
            this.tsmiSaveView.Text = "Save View";
            this.tsmiSaveView.Click += new System.EventHandler(this.tsmiSaveView_Click);
            // 
            // tsmiSaveML
            // 
            this.tsmiSaveML.Enabled = false;
            this.tsmiSaveML.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveML.Image")));
            this.tsmiSaveML.Name = "tsmiSaveML";
            this.tsmiSaveML.Size = new System.Drawing.Size(226, 22);
            this.tsmiSaveML.Text = "Save Dynamic Marketing List";
            this.tsmiSaveML.Click += new System.EventHandler(this.tsmiSaveML_Click);
            // 
            // tsmiSaveCWP
            // 
            this.tsmiSaveCWP.Enabled = false;
            this.tsmiSaveCWP.Name = "tsmiSaveCWP";
            this.tsmiSaveCWP.Size = new System.Drawing.Size(226, 22);
            this.tsmiSaveCWP.Text = "Save as CWP Feed...";
            this.tsmiSaveCWP.Click += new System.EventHandler(this.tsmiSaveCWP_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(223, 6);
            // 
            // tsmiSaveCs
            // 
            this.tsmiSaveCs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToQureyExpression,
            this.tsmiToCSharp});
            this.tsmiSaveCs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveCs.Image")));
            this.tsmiSaveCs.Name = "tsmiSaveCs";
            this.tsmiSaveCs.Size = new System.Drawing.Size(226, 22);
            this.tsmiSaveCs.Text = "C#";
            // 
            // tsmiToQureyExpression
            // 
            this.tsmiToQureyExpression.Enabled = false;
            this.tsmiToQureyExpression.Image = ((System.Drawing.Image)(resources.GetObject("tsmiToQureyExpression.Image")));
            this.tsmiToQureyExpression.Name = "tsmiToQureyExpression";
            this.tsmiToQureyExpression.Size = new System.Drawing.Size(170, 22);
            this.tsmiToQureyExpression.Text = "QueryExpression...";
            this.tsmiToQureyExpression.Click += new System.EventHandler(this.tsmiToQureyExpression_Click);
            // 
            // tsmiToCSharp
            // 
            this.tsmiToCSharp.Enabled = false;
            this.tsmiToCSharp.Name = "tsmiToCSharp";
            this.tsmiToCSharp.Size = new System.Drawing.Size(170, 22);
            this.tsmiToCSharp.Text = "FetchXML...";
            this.tsmiToCSharp.Click += new System.EventHandler(this.tsmiToCSharp_Click);
            // 
            // tsmiSaveJs
            // 
            this.tsmiSaveJs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToJavascript});
            this.tsmiSaveJs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveJs.Image")));
            this.tsmiSaveJs.Name = "tsmiSaveJs";
            this.tsmiSaveJs.Size = new System.Drawing.Size(226, 22);
            this.tsmiSaveJs.Text = "JavaScript";
            // 
            // tsmiToJavascript
            // 
            this.tsmiToJavascript.Enabled = false;
            this.tsmiToJavascript.Name = "tsmiToJavascript";
            this.tsmiToJavascript.Size = new System.Drawing.Size(136, 22);
            this.tsmiToJavascript.Text = "FetchXML...";
            this.tsmiToJavascript.Click += new System.EventHandler(this.tsmiToJavascript_Click);
            // 
            // tsmiSaveSql
            // 
            this.tsmiSaveSql.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToSQLQuery});
            this.tsmiSaveSql.Name = "tsmiSaveSql";
            this.tsmiSaveSql.Size = new System.Drawing.Size(226, 22);
            this.tsmiSaveSql.Text = "SQL";
            // 
            // tsmiToSQLQuery
            // 
            this.tsmiToSQLQuery.Enabled = false;
            this.tsmiToSQLQuery.Name = "tsmiToSQLQuery";
            this.tsmiToSQLQuery.Size = new System.Drawing.Size(115, 22);
            this.tsmiToSQLQuery.Text = "Query...";
            this.tsmiToSQLQuery.Click += new System.EventHandler(this.tsmiToSQLQuery_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(87, 28);
            this.tsbEdit.Text = "View XML";
            this.tsbEdit.ToolTipText = "Edit XML (Ctrl+E)";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbUndo
            // 
            this.tsbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUndo.Enabled = false;
            this.tsbUndo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUndo.Image")));
            this.tsbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUndo.Name = "tsbUndo";
            this.tsbUndo.Size = new System.Drawing.Size(28, 28);
            this.tsbUndo.Text = "Undo";
            this.tsbUndo.ToolTipText = "Undo (Ctrl+Z)";
            this.tsbUndo.Click += new System.EventHandler(this.tsbUndo_Click);
            // 
            // tsbRedo
            // 
            this.tsbRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRedo.Enabled = false;
            this.tsbRedo.Image = ((System.Drawing.Image)(resources.GetObject("tsbRedo.Image")));
            this.tsbRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRedo.Name = "tsbRedo";
            this.tsbRedo.Size = new System.Drawing.Size(28, 28);
            this.tsbRedo.Text = "Redo";
            this.tsbRedo.ToolTipText = "Redo (Ctrl+Y)";
            this.tsbRedo.Click += new System.EventHandler(this.tsbRedo_Click);
            // 
            // tsbExecute
            // 
            this.tsbExecute.Enabled = false;
            this.tsbExecute.Image = ((System.Drawing.Image)(resources.GetObject("tsbExecute.Image")));
            this.tsbExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExecute.Name = "tsbExecute";
            this.tsbExecute.Size = new System.Drawing.Size(98, 28);
            this.tsbExecute.Text = "Execute (F5)";
            this.tsbExecute.ToolTipText = "Execute FetchXML (F5)";
            this.tsbExecute.Click += new System.EventHandler(this.tsbExecute_Click);
            // 
            // tsbView
            // 
            this.tsbView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowOData,
            this.toolStripMenuItem1,
            this.resetWindowLayoutToolStripMenuItem});
            this.tsbView.Image = ((System.Drawing.Image)(resources.GetObject("tsbView.Image")));
            this.tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbView.Name = "tsbView";
            this.tsbView.Size = new System.Drawing.Size(69, 28);
            this.tsbView.Text = "View";
            // 
            // tsmiShowOData
            // 
            this.tsmiShowOData.CheckOnClick = true;
            this.tsmiShowOData.Name = "tsmiShowOData";
            this.tsmiShowOData.Size = new System.Drawing.Size(197, 22);
            this.tsmiShowOData.Text = "Show OData Equivalent";
            this.tsmiShowOData.CheckedChanged += new System.EventHandler(this.tsmiShowOData_CheckedChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 6);
            // 
            // resetWindowLayoutToolStripMenuItem
            // 
            this.resetWindowLayoutToolStripMenuItem.Name = "resetWindowLayoutToolStripMenuItem";
            this.resetWindowLayoutToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.resetWindowLayoutToolStripMenuItem.Text = "Reset window layout";
            this.resetWindowLayoutToolStripMenuItem.Click += new System.EventHandler(this.resetWindowLayoutToolStripMenuItem_Click);
            // 
            // tsbReturnToCaller
            // 
            this.tsbReturnToCaller.Image = ((System.Drawing.Image)(resources.GetObject("tsbReturnToCaller.Image")));
            this.tsbReturnToCaller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReturnToCaller.Name = "tsbReturnToCaller";
            this.tsbReturnToCaller.Size = new System.Drawing.Size(126, 28);
            this.tsbReturnToCaller.Text = "Return FetchXML";
            this.tsbReturnToCaller.Visible = false;
            this.tsbReturnToCaller.Click += new System.EventHandler(this.tsbReturnToCaller_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbAbout
            // 
            this.tsbAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(68, 28);
            this.tsbAbout.Text = "About";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // tsbOptions
            // 
            this.tsbOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsbOptions.Image")));
            this.tsbOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOptions.Name = "tsbOptions";
            this.tsbOptions.Size = new System.Drawing.Size(86, 28);
            this.tsbOptions.Text = "Options...";
            this.tsbOptions.Click += new System.EventHandler(this.tsbOptions_Click);
            // 
            // panOData
            // 
            this.panOData.BackColor = System.Drawing.SystemColors.Window;
            this.panOData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panOData.Controls.Add(this.linkOData);
            this.panOData.Controls.Add(this.panODataLabel);
            this.panOData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panOData.Location = new System.Drawing.Point(0, 576);
            this.panOData.Name = "panOData";
            this.panOData.Padding = new System.Windows.Forms.Padding(4);
            this.panOData.Size = new System.Drawing.Size(1101, 48);
            this.panOData.TabIndex = 27;
            this.panOData.Visible = false;
            // 
            // linkOData
            // 
            this.linkOData.ContextMenuStrip = this.menuOData;
            this.linkOData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkOData.Location = new System.Drawing.Point(46, 4);
            this.linkOData.Name = "linkOData";
            this.linkOData.Padding = new System.Windows.Forms.Padding(2);
            this.linkOData.Size = new System.Drawing.Size(1049, 38);
            this.linkOData.TabIndex = 3;
            this.linkOData.TabStop = true;
            this.linkOData.Text = "linkLabel1";
            this.linkOData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOData_LinkClicked);
            // 
            // menuOData
            // 
            this.menuOData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuODataExecute,
            this.menuODataCopy});
            this.menuOData.Name = "menuOData";
            this.menuOData.Size = new System.Drawing.Size(127, 48);
            // 
            // menuODataExecute
            // 
            this.menuODataExecute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuODataExecute.Name = "menuODataExecute";
            this.menuODataExecute.Size = new System.Drawing.Size(126, 22);
            this.menuODataExecute.Text = "Execute";
            this.menuODataExecute.Click += new System.EventHandler(this.menuODataExecute_Click);
            // 
            // menuODataCopy
            // 
            this.menuODataCopy.Name = "menuODataCopy";
            this.menuODataCopy.Size = new System.Drawing.Size(126, 22);
            this.menuODataCopy.Text = "Copy URL";
            this.menuODataCopy.Click += new System.EventHandler(this.menuODataCopy_Click);
            // 
            // panODataLabel
            // 
            this.panODataLabel.Controls.Add(this.pictureBox1);
            this.panODataLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panODataLabel.Location = new System.Drawing.Point(4, 4);
            this.panODataLabel.Name = "panODataLabel";
            this.panODataLabel.Size = new System.Drawing.Size(42, 38);
            this.panODataLabel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 573);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1101, 3);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // dockContainer
            // 
            this.dockContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockContainer.DefaultFloatWindowSize = new System.Drawing.Size(600, 400);
            this.dockContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockContainer.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockContainer.Location = new System.Drawing.Point(0, 31);
            this.dockContainer.Name = "dockContainer";
            this.dockContainer.Size = new System.Drawing.Size(1101, 542);
            this.dockContainer.TabIndex = 33;
            // 
            // FetchXmlBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dockContainer);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panOData);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FetchXmlBuilder";
            this.Size = new System.Drawing.Size(1101, 624);
            this.TabIcon = ((System.Drawing.Image)(resources.GetObject("$this.TabIcon")));
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.FetchXmlBuilder_ConnectionUpdated);
            this.Load += new System.EventHandler(this.FetchXmlBuilder_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.panOData.ResumeLayout(false);
            this.menuOData.ResumeLayout(false);
            this.panODataLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbCloseThisTab;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        internal System.Windows.Forms.ToolStripDropDownButton tsbOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenView;
        internal System.Windows.Forms.ToolStripDropDownButton tsbSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveFileAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private System.Windows.Forms.ToolStripDropDownButton tsbView;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveCWP;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenCWP;
        private System.Windows.Forms.ToolStripMenuItem tsmiToQureyExpression;
        private System.Windows.Forms.ToolStripButton tsbExecute;
        private System.Windows.Forms.ToolStripButton tsbReturnToCaller;
        private System.Windows.Forms.ToolStripButton tsbUndo;
        private System.Windows.Forms.ToolStripButton tsbRedo;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenML;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveML;
        private System.Windows.Forms.Panel panOData;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowOData;
        private System.Windows.Forms.Panel panODataLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkOData;
        private System.Windows.Forms.ContextMenuStrip menuOData;
        private System.Windows.Forms.ToolStripMenuItem menuODataExecute;
        private System.Windows.Forms.ToolStripMenuItem menuODataCopy;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStripButton tsbOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiToSQLQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiToJavascript;
        private System.Windows.Forms.ToolStripMenuItem tsmiToCSharp;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveJs;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveCs;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveSql;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetWindowLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        internal WeifenLuo.WinFormsUI.Docking.DockPanel dockContainer;
    }
}
