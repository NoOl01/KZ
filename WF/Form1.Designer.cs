namespace WF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            OrgTree = new TreeView();
            tableLayoutPanel2 = new TableLayoutPanel();
            EmployeePanel = new FlowLayoutPanel();
            AddEmoployee = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(OrgTree, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.8873253F));
            tableLayoutPanel1.Size = new Size(869, 475);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // OrgTree
            // 
            OrgTree.Dock = DockStyle.Fill;
            OrgTree.Location = new Point(3, 3);
            OrgTree.Name = "OrgTree";
            OrgTree.Size = new Size(428, 469);
            OrgTree.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(EmployeePanel, 0, 0);
            tableLayoutPanel2.Controls.Add(AddEmoployee, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(437, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 86.1407242F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8592749F));
            tableLayoutPanel2.Size = new Size(429, 469);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // EmployeePanel
            // 
            EmployeePanel.Dock = DockStyle.Fill;
            EmployeePanel.Location = new Point(3, 3);
            EmployeePanel.Name = "EmployeePanel";
            EmployeePanel.Size = new Size(423, 398);
            EmployeePanel.TabIndex = 0;
            // 
            // AddEmoployee
            // 
            AddEmoployee.Anchor = AnchorStyles.Right;
            AddEmoployee.Location = new Point(351, 410);
            AddEmoployee.Name = "AddEmoployee";
            AddEmoployee.Size = new Size(75, 53);
            AddEmoployee.TabIndex = 1;
            AddEmoployee.Text = "Добавить";
            AddEmoployee.UseVisualStyleBackColor = true;
            AddEmoployee.Click += AddEmoployee_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 475);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TreeView OrgTree;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel EmployeePanel;
        private Button AddEmoployee;
    }
}
