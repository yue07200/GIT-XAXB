namespace 視窗版本的XAXB_遊戲_2._0
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 请勿修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            userInputTextBox = new TextBox();
            resultLabel = new Label();
            guessButton = new Button();
            Label1 = new Label();
            SuspendLayout();
            // 
            // userInputTextBox
            // 
            userInputTextBox.Location = new Point(64, 63);
            userInputTextBox.Margin = new Padding(4);
            userInputTextBox.Name = "userInputTextBox";
            userInputTextBox.Size = new Size(127, 27);
            userInputTextBox.TabIndex = 0;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(64, 172);
            resultLabel.Margin = new Padding(4, 0, 4, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 19);
            resultLabel.TabIndex = 1;
            // 
            // guessButton
            // 
            guessButton.Location = new Point(64, 123);
            guessButton.Margin = new Padding(4);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(96, 29);
            guessButton.TabIndex = 2;
            guessButton.Text = "確定";
            guessButton.UseVisualStyleBackColor = true;
            guessButton.Click += guessButton_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(31, 31);
            Label1.Name = "Label1";
            Label1.Size = new Size(129, 19);
            Label1.TabIndex = 3;
            Label1.Text = "輸入三位數數字：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 341);
            Controls.Add(Label1);
            Controls.Add(guessButton);
            Controls.Add(resultLabel);
            Controls.Add(userInputTextBox);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "視窗版本的XAXB 遊戲";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userInputTextBox; //使用這輸入文本框
        private Label resultLabel; //顯示猜結果標籤
        private Button guessButton; //猜測按鈕
        private Label Label1;
        //private Label luckyNumberLabel; 
    }
}