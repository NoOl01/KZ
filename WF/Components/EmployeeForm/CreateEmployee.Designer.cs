namespace WF.Components
{
    partial class CreateEmployee
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
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            NewPhoneInput = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            NewFioInput = new TextBox();
            NewSaveButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(NewSaveButton, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.Size = new Size(475, 236);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(469, 132);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(NewPhoneInput, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(237, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(229, 126);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(20, 48);
            label2.Margin = new Padding(20, 5, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 0;
            label2.Text = "Номер телефона";
            // 
            // NewPhoneInput
            // 
            NewPhoneInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NewPhoneInput.Location = new Point(20, 73);
            NewPhoneInput.Margin = new Padding(20, 10, 20, 3);
            NewPhoneInput.Name = "NewPhoneInput";
            NewPhoneInput.Size = new Size(189, 23);
            NewPhoneInput.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(NewFioInput, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(228, 126);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(20, 48);
            label1.Margin = new Padding(20, 5, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // NewFioInput
            // 
            NewFioInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NewFioInput.Location = new Point(20, 73);
            NewFioInput.Margin = new Padding(20, 10, 20, 3);
            NewFioInput.Name = "NewFioInput";
            NewFioInput.Size = new Size(188, 23);
            NewFioInput.TabIndex = 1;
            // 
            // NewSaveButton
            // 
            NewSaveButton.Anchor = AnchorStyles.None;
            NewSaveButton.Location = new Point(150, 156);
            NewSaveButton.Name = "NewSaveButton";
            NewSaveButton.Size = new Size(175, 61);
            NewSaveButton.TabIndex = 1;
            NewSaveButton.Text = "Сохранить";
            NewSaveButton.UseVisualStyleBackColor = true;
            NewSaveButton.Click += NewSaveButton_Click;
            // 
            // CreateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 236);
            Controls.Add(tableLayoutPanel1);
            Name = "CreateEmployee";
            Text = "CreateEmployee";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TextBox NewPhoneInput;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TextBox NewFioInput;
        private Button NewSaveButton;
    }
}