namespace CSVmanager
{
    partial class Form1
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
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            OpenButton = new Button();
            Add = new Button();
            Modify_button = new Button();
            modify_draw_date_textbox = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            modify_new_value_textbox = new TextBox();
            label3 = new Label();
            modify_target = new ComboBox();
            label2 = new Label();
            fields_num_button = new Button();
            max_field_button = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView
            // 
            listView.BackColor = SystemColors.InactiveBorder;
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView.GridLines = true;
            listView.Location = new Point(434, 12);
            listView.Name = "listView";
            listView.Size = new Size(364, 387);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DrawDate";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "WinNumbers";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "MegaBall";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Multiplier";
            columnHeader4.Width = 90;
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(713, 415);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(75, 23);
            OpenButton.TabIndex = 1;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // Add
            // 
            Add.Location = new Point(605, 415);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 2;
            Add.Text = "Load";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Modify_button
            // 
            Modify_button.Location = new Point(6, 45);
            Modify_button.Name = "Modify_button";
            Modify_button.Size = new Size(75, 23);
            Modify_button.TabIndex = 3;
            Modify_button.Text = "Modify";
            Modify_button.UseVisualStyleBackColor = true;
            Modify_button.Click += Modify_button_Click;
            // 
            // modify_draw_date_textbox
            // 
            modify_draw_date_textbox.Location = new Point(96, 46);
            modify_draw_date_textbox.Name = "modify_draw_date_textbox";
            modify_draw_date_textbox.Size = new Size(90, 23);
            modify_draw_date_textbox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 28);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Draw date";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(modify_new_value_textbox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(modify_target);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(modify_draw_date_textbox);
            groupBox1.Controls.Add(Modify_button);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 394);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "functions";
            // 
            // modify_new_value_textbox
            // 
            modify_new_value_textbox.Location = new Point(306, 46);
            modify_new_value_textbox.Name = "modify_new_value_textbox";
            modify_new_value_textbox.Size = new Size(90, 23);
            modify_new_value_textbox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 28);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 9;
            label3.Text = "New Value";
            // 
            // modify_target
            // 
            modify_target.FormattingEnabled = true;
            modify_target.Items.AddRange(new object[] { "WinNumbers", "MegaBall", "Multiplier" });
            modify_target.Location = new Point(191, 45);
            modify_target.Name = "modify_target";
            modify_target.Size = new Size(106, 23);
            modify_target.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 28);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Target";
            // 
            // fields_num_button
            // 
            fields_num_button.Location = new Point(18, 415);
            fields_num_button.Name = "fields_num_button";
            fields_num_button.Size = new Size(106, 23);
            fields_num_button.TabIndex = 10;
            fields_num_button.Text = "Fields Number";
            fields_num_button.UseVisualStyleBackColor = true;
            fields_num_button.Click += fields_num_button_Click;
            // 
            // max_field_button
            // 
            max_field_button.Location = new Point(145, 415);
            max_field_button.Name = "max_field_button";
            max_field_button.Size = new Size(109, 23);
            max_field_button.TabIndex = 11;
            max_field_button.Text = "Max field lenght";
            max_field_button.UseVisualStyleBackColor = true;
            max_field_button.Click += max_field_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 457);
            Controls.Add(max_field_button);
            Controls.Add(fields_num_button);
            Controls.Add(groupBox1);
            Controls.Add(Add);
            Controls.Add(OpenButton);
            Controls.Add(listView);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "CSVmanager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button OpenButton;
        private Button Add;
        private Button Modify_button;
        private TextBox modify_draw_date_textbox;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox modify_target;
        private TextBox modify_new_value_textbox;
        private Label label3;
        private Button fields_num_button;
        private Button max_field_button;
    }
}