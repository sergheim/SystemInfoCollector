namespace SystemInfoCollector
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("File");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Running Processes");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Loaded Modules");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Process&Module", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("PendingRenameOp");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("StartProgram", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Environment Variable");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Services");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Uninstall Info");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Network Connections");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("ActiveX");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Browser Extensions");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Other Extensions");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Start / Search Page");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("IE", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Lsp");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Device");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Printer");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("SystemInfo", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Refresh = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Category = new System.Windows.Forms.TreeView();
            this.DataView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Refresh);
            this.splitContainer1.Panel1.Controls.Add(this.Save);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(711, 436);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.TabIndex = 4;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(93, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Category);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DataView);
            this.splitContainer2.Size = new System.Drawing.Size(711, 383);
            this.splitContainer2.SplitterDistance = 237;
            this.splitContainer2.TabIndex = 0;
            // 
            // Category
            // 
            this.Category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Category.Location = new System.Drawing.Point(0, 0);
            this.Category.Name = "Category";
            treeNode1.Name = "User";
            treeNode1.Text = "User";
            treeNode2.Name = "File";
            treeNode2.Text = "File";
            treeNode3.Name = "Running Processes";
            treeNode3.Text = "Running Processes";
            treeNode4.Name = "Loaded Modules";
            treeNode4.Text = "Loaded Modules";
            treeNode5.Name = "Process&Module";
            treeNode5.Text = "Process&Module";
            treeNode6.Name = "PendingRenameOp";
            treeNode6.Text = "PendingRenameOp";
            treeNode7.Name = "StartProgram";
            treeNode7.Text = "StartProgram";
            treeNode8.Name = "Environment Variable";
            treeNode8.Text = "Environment Variable";
            treeNode9.Name = "Services";
            treeNode9.Text = "Services";
            treeNode10.Name = "Uninstall Info";
            treeNode10.Text = "Uninstall Info";
            treeNode11.Name = "Network Connections";
            treeNode11.Text = "Network Connections";
            treeNode12.Name = "ActiveX";
            treeNode12.Text = "ActiveX";
            treeNode13.Name = "Browser Extensions";
            treeNode13.Text = "Browser Extensions";
            treeNode14.Name = "Other Extensions";
            treeNode14.Text = "Other Extensions";
            treeNode15.Name = "Start / Search Page";
            treeNode15.Text = "Start / Search Page";
            treeNode16.Name = "IE";
            treeNode16.Text = "IE";
            treeNode17.Name = "Lsp";
            treeNode17.Text = "Lsp";
            treeNode18.Name = "Device";
            treeNode18.Text = "Device";
            treeNode19.Name = "Printer";
            treeNode19.Text = "Printer";
            treeNode20.Checked = true;
            treeNode20.Name = "SystemInfo";
            treeNode20.Text = "SystemInfo";
            this.Category.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.Category.Size = new System.Drawing.Size(237, 383);
            this.Category.TabIndex = 3;
            this.Category.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Category_AfterSelect);
            // 
            // DataView
            // 
            this.DataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataView.Location = new System.Drawing.Point(0, 0);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(470, 383);
            this.DataView.TabIndex = 4;
            this.DataView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 436);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "SystemInfoCollector";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView Category;
        private System.Windows.Forms.ListView DataView;


    }
}

