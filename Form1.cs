namespace 視窗版本的XAXB_遊戲_2._0
{
    public partial class Form1 : Form
    {
        XaXbEngine xaxb = new XaXbEngine();  // 創建 XaXbEngine 物件以處理遊戲邏輯
        int counter = 0; //計算猜測次數

        public Form1() //初始化視窗介面
        {
            InitializeComponent();
            //
            //luckyNumberLabel.Text = xaxb.GetLuckyNumber(); 在表單初始化時，將幸運數字顯示出來
        }

        private void guessButton_Click(object sender, EventArgs e) // 當使用者點擊猜測按鈕時觸發的事件處理函式
        {
            string userNum = userInputTextBox.Text; //使用者輸入數字
            if (xaxb.IsLegal(userNum)) //檢查輸入數字是否合法
            {
                counter++; //如果合法猜測次數+1
                string result = xaxb.GetResult(userNum); //獲得猜測結果
                resultLabel.Text += $"{userNum} : {result}, 猜測次數: {counter}\n"; // 更新標籤顯示猜測結果
                if (result == "3A0B") //如果猜中所有數字
                {
                    MessageBox.Show("恭喜你，猜對了!"); //顯示恭喜訊息框
                }
            }
            else
            {
                MessageBox.Show("輸入的資料重複, 或長度不對!! 請重新輸入!!"); //// 如果輸入的數字不合法，顯示錯誤訊息框
            }
            userInputTextBox.Clear(); //清空使用者輸入數字
        }
        
        

        internal class XaXbEngine //遊戲引擎類別
        {
            string luckynum; //信運數字
            public XaXbEngine() //初始化信運數字
            {
                Random random = new Random();
                int[] tem = new int[3];
                tem[0] = random.Next(0, 9);
                tem[1] = random.Next(0, 9);
                tem[2] = random.Next(0, 9);
                while (tem[0] == tem[1] || tem[1] == tem[2] || tem[0] == tem[2])
                {
                    tem[1] = random.Next(0, 9);
                    tem[2] = random.Next(0, 9);
                }
                luckynum = $"{tem[0]}{tem[1]}{tem[2]}"; //數字轉為字串並組合成幸運數字
            }
            public string GetLuckyNumber() //獲取幸運數字
            {
                return this.luckynum;
            }
            public Boolean IsLegal(String theNumber) //檢查輸入數字是否合法的方法
            {
                char[] tem = theNumber.ToCharArray();
                if (tem.Length == 3)
                {
                    if (tem[0] != tem[1] && tem[1] != tem[2] && tem[0] != tem[2])
                    {
                        return true; //如果三個數字沒有重複則回傳true
                    }
                }
                return false; //否則回傳false
            }
            public string GetResult(String userNumber) //測驗結果
            {
                char[] user = userNumber.ToCharArray();
                char[] ans = this.luckynum.ToCharArray();
                int a = 0;
                int b = 0;
                for (int i = 0; i < user.Length; i++)
                {
                    for (int j = 0; j < ans.Length; j++)
                    {
                        if (user[i] == ans[j])
                        {
                            if (i == j)
                            {
                                a++; //如果數字及位置皆相同則+1
                            }
                            else
                            {
                                b++; //如果數字相同位置不同則+1
                            }
                        }
                    }
                }
                return $"{a}A{b}B"; //回傳最後結果
            }
        }
    }
}