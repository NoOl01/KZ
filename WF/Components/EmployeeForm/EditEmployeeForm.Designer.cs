namespace WF.Components.EmployeeForm
{
    partial class EditEmployeeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            PhoneInput = new TextBox();
            FioInput = new TextBox();
            SaveButton = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            AbsSort = new Button();
            AbsNext = new Button();
            AbsCurrent = new Button();
            AbsPrev = new Button();
            AbsencesPanel = new FlowLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            DeleteButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.49495F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.50505F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.05466F));
            tableLayoutPanel1.Size = new Size(873, 489);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 156F));
            tableLayoutPanel2.Size = new Size(426, 483);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(PhoneInput, 0, 1);
            tableLayoutPanel3.Controls.Add(FioInput, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 144F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(420, 321);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // PhoneInput
            // 
            PhoneInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PhoneInput.Location = new Point(20, 221);
            PhoneInput.Margin = new Padding(20, 3, 20, 3);
            PhoneInput.Name = "PhoneInput";
            PhoneInput.Size = new Size(380, 23);
            PhoneInput.TabIndex = 1;
            PhoneInput.TextChanged += PhoneInput_TextChanged;
            // 
            // FioInput
            // 
            FioInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FioInput.Location = new Point(20, 60);
            FioInput.Margin = new Padding(20, 3, 20, 3);
            FioInput.Name = "FioInput";
            FioInput.Size = new Size(380, 23);
            FioInput.TabIndex = 0;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.None;
            SaveButton.Font = new Font("Segoe UI", 14F);
            SaveButton.Location = new Point(228, 31);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(174, 87);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(AbsencesPanel, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(435, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.0092382F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 87.99076F));
            tableLayoutPanel4.Size = new Size(435, 483);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(AbsSort, 3, 0);
            tableLayoutPanel5.Controls.Add(AbsNext, 2, 0);
            tableLayoutPanel5.Controls.Add(AbsCurrent, 1, 0);
            tableLayoutPanel5.Controls.Add(AbsPrev, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(429, 52);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // AbsSort
            // 
            AbsSort.Anchor = AnchorStyles.None;
            AbsSort.Location = new Point(344, 7);
            AbsSort.Name = "AbsSort";
            AbsSort.Size = new Size(62, 37);
            AbsSort.TabIndex = 3;
            AbsSort.Text = "Сорт";
            AbsSort.UseVisualStyleBackColor = true;
            AbsSort.Click += AbsSort_Click;
            // 
            // AbsNext
            // 
            AbsNext.Anchor = AnchorStyles.None;
            AbsNext.Location = new Point(218, 7);
            AbsNext.Name = "AbsNext";
            AbsNext.Size = new Size(100, 37);
            AbsNext.TabIndex = 2;
            AbsNext.Text = "Будущие";
            AbsNext.UseVisualStyleBackColor = true;
            AbsNext.Click += AbsNext_Click;
            // 
            // AbsCurrent
            // 
            AbsCurrent.Anchor = AnchorStyles.None;
            AbsCurrent.Location = new Point(110, 7);
            AbsCurrent.Name = "AbsCurrent";
            AbsCurrent.Size = new Size(100, 37);
            AbsCurrent.TabIndex = 1;
            AbsCurrent.Text = "Текущие";
            AbsCurrent.UseVisualStyleBackColor = true;
            AbsCurrent.Click += AbsCurrent_Click;
            // 
            // AbsPrev
            // 
            AbsPrev.Anchor = AnchorStyles.None;
            AbsPrev.Location = new Point(3, 7);
            AbsPrev.Name = "AbsPrev";
            AbsPrev.Size = new Size(100, 37);
            AbsPrev.TabIndex = 0;
            AbsPrev.Text = "Прошедшие";
            AbsPrev.UseVisualStyleBackColor = true;
            AbsPrev.Click += AbsPrev_Click;
            // 
            // AbsencesPanel
            // 
            AbsencesPanel.AutoScroll = true;
            AbsencesPanel.Dock = DockStyle.Fill;
            AbsencesPanel.FlowDirection = FlowDirection.TopDown;
            AbsencesPanel.Location = new Point(3, 61);
            AbsencesPanel.Name = "AbsencesPanel";
            AbsencesPanel.Size = new Size(429, 419);
            AbsencesPanel.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(DeleteButton, 0, 0);
            tableLayoutPanel6.Controls.Add(SaveButton, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 330);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(420, 150);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.None;
            DeleteButton.Font = new Font("Segoe UI", 14F);
            DeleteButton.Location = new Point(18, 31);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(174, 87);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 489);
            Controls.Add(tableLayoutPanel1);
            Name = "EditEmployeeForm";
            Text = "EditEmployeeForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button SaveButton;
        private TextBox PhoneInput;
        private TextBox FioInput;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button AbsSort;
        private Button AbsNext;
        private Button AbsCurrent;
        private Button AbsPrev;
        private FlowLayoutPanel AbsencesPanel;
        private TableLayoutPanel tableLayoutPanel6;
        private Button DeleteButton;
    }
}