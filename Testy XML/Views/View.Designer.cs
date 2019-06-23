namespace Testy_XML {
    partial class View {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_SaveTest = new System.Windows.Forms.Button();
            this.button_LoadTest = new System.Windows.Forms.Button();
            this.button_AddQuestion = new System.Windows.Forms.Button();
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Questions = new System.Windows.Forms.ListBox();
            this.newQuestion1 = new Testy_XML.NewQuestion();
            this.panel1.SuspendLayout();
            this.groupBoxProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newQuestion1);
            this.panel1.Controls.Add(this.button_SaveTest);
            this.panel1.Controls.Add(this.button_LoadTest);
            this.panel1.Controls.Add(this.button_AddQuestion);
            this.panel1.Controls.Add(this.groupBoxProperties);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox_Questions);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 359);
            this.panel1.TabIndex = 0;
            // 
            // button_SaveTest
            // 
            this.button_SaveTest.Location = new System.Drawing.Point(335, 262);
            this.button_SaveTest.Name = "button_SaveTest";
            this.button_SaveTest.Size = new System.Drawing.Size(95, 66);
            this.button_SaveTest.TabIndex = 21;
            this.button_SaveTest.Text = "Save test";
            this.button_SaveTest.UseVisualStyleBackColor = true;
            this.button_SaveTest.Click += new System.EventHandler(this.Button_SaveTest_Click);
            // 
            // button_LoadTest
            // 
            this.button_LoadTest.Location = new System.Drawing.Point(436, 262);
            this.button_LoadTest.Name = "button_LoadTest";
            this.button_LoadTest.Size = new System.Drawing.Size(95, 66);
            this.button_LoadTest.TabIndex = 20;
            this.button_LoadTest.Text = "Load test";
            this.button_LoadTest.UseVisualStyleBackColor = true;
            // 
            // button_AddQuestion
            // 
            this.button_AddQuestion.Location = new System.Drawing.Point(231, 262);
            this.button_AddQuestion.Name = "button_AddQuestion";
            this.button_AddQuestion.Size = new System.Drawing.Size(95, 66);
            this.button_AddQuestion.TabIndex = 19;
            this.button_AddQuestion.Text = "Add question";
            this.button_AddQuestion.UseVisualStyleBackColor = true;
            this.button_AddQuestion.Click += new System.EventHandler(this.Button_AddQuestion_Click);
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Controls.Add(this.labelName);
            this.groupBoxProperties.Controls.Add(this.textBoxName);
            this.groupBoxProperties.Controls.Add(this.labelAuthor);
            this.groupBoxProperties.Controls.Add(this.numericUpDown1);
            this.groupBoxProperties.Controls.Add(this.textBoxAuthor);
            this.groupBoxProperties.Controls.Add(this.labelTime);
            this.groupBoxProperties.Controls.Add(this.labelLevel);
            this.groupBoxProperties.Controls.Add(this.textBoxLevel);
            this.groupBoxProperties.Location = new System.Drawing.Point(11, 14);
            this.groupBoxProperties.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProperties.Size = new System.Drawing.Size(197, 110);
            this.groupBoxProperties.TabIndex = 17;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Test Properties";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(4, 15);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(72, 15);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(114, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(4, 37);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(72, 83);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(113, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(72, 37);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(114, 20);
            this.textBoxAuthor.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(4, 83);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(33, 13);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Time:";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(4, 60);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(36, 13);
            this.labelLevel.TabIndex = 4;
            this.labelLevel.Text = "Level:";
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(72, 60);
            this.textBoxLevel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(114, 20);
            this.textBoxLevel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Questions:";
            // 
            // listBox_Questions
            // 
            this.listBox_Questions.FormattingEnabled = true;
            this.listBox_Questions.Location = new System.Drawing.Point(11, 142);
            this.listBox_Questions.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Questions.Name = "listBox_Questions";
            this.listBox_Questions.Size = new System.Drawing.Size(198, 186);
            this.listBox_Questions.TabIndex = 15;
            this.listBox_Questions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_Questions_MouseDoubleClick);
            // 
            // newQuestion1
            // 
            this.newQuestion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newQuestion1.Location = new System.Drawing.Point(231, 14);
            this.newQuestion1.Margin = new System.Windows.Forms.Padding(2);
            this.newQuestion1.Name = "newQuestion1";
            this.newQuestion1.Size = new System.Drawing.Size(300, 231);
            this.newQuestion1.TabIndex = 22;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 383);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "View";
            this.Text = "Test Creator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxProperties.ResumeLayout(false);
            this.groupBoxProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_SaveTest;
        private System.Windows.Forms.Button button_LoadTest;
        private System.Windows.Forms.Button button_AddQuestion;
        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Questions;
        private NewQuestion newQuestion1;
    }
}

