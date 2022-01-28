namespace WindowsFormsApp6
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.conditionItemdataGridView = new System.Windows.Forms.DataGridView();
            this.조건종목_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건종목_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건종목_현재가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건종목_등락율 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건종목_전일대비 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건종목_거래량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.conditionDataGridView = new System.Windows.Forms.DataGridView();
            this.조건_조건번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건_조건명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertListBox = new System.Windows.Forms.ListBox();
            this.deleteListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.balanceDataGridView = new System.Windows.Forms.DataGridView();
            this.잔고_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_보유수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_평균단가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_현재가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_평가금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_손익금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_손익율 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_매입금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outStandingDataGridView = new System.Windows.Forms.DataGridView();
            this.미체결_주문번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_주문수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_주문가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_미체결수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_주문구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_체결가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_현재가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.balanceAssetLabel = new System.Windows.Forms.Label();
            this.totalBuyPriceLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.assetPriceLabel = new System.Windows.Forms.Label();
            this.todayLossPriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.todayLossRatioLabel = new System.Windows.Forms.Label();
            this.realizationProfitLabel = new System.Windows.Forms.Label();
            this.userNameLable = new System.Windows.Forms.Label();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.buyComboBox = new System.Windows.Forms.ComboBox();
            this.buyCheckBox = new System.Windows.Forms.CheckBox();
            this.benefitCheckBox = new System.Windows.Forms.CheckBox();
            this.benefitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lossCutnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lossCutCheckBox = new System.Windows.Forms.CheckBox();
            this.totalAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.stockCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.tradingStartButton = new System.Windows.Forms.Button();
            this.tradingStopButton = new System.Windows.Forms.Button();
            this.sellCheckBox = new System.Windows.Forms.CheckBox();
            this.sellComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.conditionItemdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabpage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outStandingDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benefitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lossCutnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // conditionItemdataGridView
            // 
            this.conditionItemdataGridView.AllowUserToAddRows = false;
            this.conditionItemdataGridView.AllowUserToDeleteRows = false;
            this.conditionItemdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionItemdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.conditionItemdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.conditionItemdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conditionItemdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.조건종목_종목코드,
            this.조건종목_종목명,
            this.조건종목_현재가,
            this.조건종목_등락율,
            this.조건종목_전일대비,
            this.조건종목_거래량});
            this.conditionItemdataGridView.Location = new System.Drawing.Point(12, 102);
            this.conditionItemdataGridView.MultiSelect = false;
            this.conditionItemdataGridView.Name = "conditionItemdataGridView";
            this.conditionItemdataGridView.RowHeadersVisible = false;
            this.conditionItemdataGridView.RowTemplate.Height = 23;
            this.conditionItemdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.conditionItemdataGridView.Size = new System.Drawing.Size(582, 256);
            this.conditionItemdataGridView.TabIndex = 2;
            // 
            // 조건종목_종목코드
            // 
            this.조건종목_종목코드.HeaderText = "종목코드";
            this.조건종목_종목코드.Name = "조건종목_종목코드";
            this.조건종목_종목코드.ReadOnly = true;
            // 
            // 조건종목_종목명
            // 
            this.조건종목_종목명.HeaderText = "종목명";
            this.조건종목_종목명.Name = "조건종목_종목명";
            this.조건종목_종목명.ReadOnly = true;
            // 
            // 조건종목_현재가
            // 
            this.조건종목_현재가.HeaderText = "현재가";
            this.조건종목_현재가.Name = "조건종목_현재가";
            this.조건종목_현재가.ReadOnly = true;
            // 
            // 조건종목_등락율
            // 
            this.조건종목_등락율.HeaderText = "등락율";
            this.조건종목_등락율.Name = "조건종목_등락율";
            this.조건종목_등락율.ReadOnly = true;
            // 
            // 조건종목_전일대비
            // 
            this.조건종목_전일대비.HeaderText = "전일대비";
            this.조건종목_전일대비.Name = "조건종목_전일대비";
            this.조건종목_전일대비.ReadOnly = true;
            // 
            // 조건종목_거래량
            // 
            this.조건종목_거래량.HeaderText = "거래량";
            this.조건종목_거래량.Name = "조건종목_거래량";
            this.조건종목_거래량.ReadOnly = true;
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(699, 388);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 3;
            // 
            // conditionDataGridView
            // 
            this.conditionDataGridView.AllowUserToAddRows = false;
            this.conditionDataGridView.AllowUserToDeleteRows = false;
            this.conditionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.conditionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.conditionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conditionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.조건_조건번호,
            this.조건_조건명});
            this.conditionDataGridView.Location = new System.Drawing.Point(603, 50);
            this.conditionDataGridView.MultiSelect = false;
            this.conditionDataGridView.Name = "conditionDataGridView";
            this.conditionDataGridView.RowHeadersVisible = false;
            this.conditionDataGridView.RowTemplate.Height = 23;
            this.conditionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.conditionDataGridView.Size = new System.Drawing.Size(329, 232);
            this.conditionDataGridView.TabIndex = 4;
            // 
            // 조건_조건번호
            // 
            this.조건_조건번호.FillWeight = 65.98985F;
            this.조건_조건번호.HeaderText = "조건번호";
            this.조건_조건번호.Name = "조건_조건번호";
            this.조건_조건번호.ReadOnly = true;
            this.조건_조건번호.Width = 108;
            // 
            // 조건_조건명
            // 
            this.조건_조건명.FillWeight = 134.0102F;
            this.조건_조건명.HeaderText = "조건명";
            this.조건_조건명.Name = "조건_조건명";
            this.조건_조건명.ReadOnly = true;
            this.조건_조건명.Width = 218;
            // 
            // insertListBox
            // 
            this.insertListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertListBox.FormattingEnabled = true;
            this.insertListBox.ItemHeight = 12;
            this.insertListBox.Location = new System.Drawing.Point(12, 364);
            this.insertListBox.Name = "insertListBox";
            this.insertListBox.Size = new System.Drawing.Size(582, 124);
            this.insertListBox.TabIndex = 5;
            // 
            // deleteListBox
            // 
            this.deleteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteListBox.FormattingEnabled = true;
            this.deleteListBox.ItemHeight = 12;
            this.deleteListBox.Location = new System.Drawing.Point(12, 494);
            this.deleteListBox.Name = "deleteListBox";
            this.deleteListBox.Size = new System.Drawing.Size(582, 64);
            this.deleteListBox.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(600, 288);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.30216F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.69785F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(335, 278);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabpage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 211);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpage1
            // 
            this.tabpage1.Controls.Add(this.balanceDataGridView);
            this.tabpage1.Location = new System.Drawing.Point(4, 22);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(321, 185);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "잔고";
            this.tabpage1.UseVisualStyleBackColor = true;
            // 
            // balanceDataGridView
            // 
            this.balanceDataGridView.AllowUserToAddRows = false;
            this.balanceDataGridView.AllowUserToDeleteRows = false;
            this.balanceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.잔고_종목코드,
            this.잔고_종목명,
            this.잔고_보유수량,
            this.잔고_평균단가,
            this.잔고_현재가,
            this.잔고_평가금액,
            this.잔고_손익금액,
            this.잔고_손익율,
            this.잔고_매입금액});
            this.balanceDataGridView.Location = new System.Drawing.Point(0, 0);
            this.balanceDataGridView.MultiSelect = false;
            this.balanceDataGridView.Name = "balanceDataGridView";
            this.balanceDataGridView.RowHeadersVisible = false;
            this.balanceDataGridView.RowTemplate.Height = 23;
            this.balanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.balanceDataGridView.Size = new System.Drawing.Size(325, 184);
            this.balanceDataGridView.TabIndex = 0;
            // 
            // 잔고_종목코드
            // 
            this.잔고_종목코드.HeaderText = "종목코드";
            this.잔고_종목코드.Name = "잔고_종목코드";
            this.잔고_종목코드.ReadOnly = true;
            // 
            // 잔고_종목명
            // 
            this.잔고_종목명.HeaderText = "종목명";
            this.잔고_종목명.Name = "잔고_종목명";
            this.잔고_종목명.ReadOnly = true;
            // 
            // 잔고_보유수량
            // 
            this.잔고_보유수량.HeaderText = "보유수량";
            this.잔고_보유수량.Name = "잔고_보유수량";
            this.잔고_보유수량.ReadOnly = true;
            // 
            // 잔고_평균단가
            // 
            this.잔고_평균단가.HeaderText = "평균단가";
            this.잔고_평균단가.Name = "잔고_평균단가";
            this.잔고_평균단가.ReadOnly = true;
            // 
            // 잔고_현재가
            // 
            this.잔고_현재가.HeaderText = "현재가";
            this.잔고_현재가.Name = "잔고_현재가";
            this.잔고_현재가.ReadOnly = true;
            // 
            // 잔고_평가금액
            // 
            this.잔고_평가금액.HeaderText = "평가금액";
            this.잔고_평가금액.Name = "잔고_평가금액";
            this.잔고_평가금액.ReadOnly = true;
            // 
            // 잔고_손익금액
            // 
            this.잔고_손익금액.HeaderText = "손익금액";
            this.잔고_손익금액.Name = "잔고_손익금액";
            // 
            // 잔고_손익율
            // 
            this.잔고_손익율.HeaderText = "손익율";
            this.잔고_손익율.Name = "잔고_손익율";
            // 
            // 잔고_매입금액
            // 
            this.잔고_매입금액.HeaderText = "매입금액";
            this.잔고_매입금액.Name = "잔고_매입금액";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.outStandingDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(321, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "미체결";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // outStandingDataGridView
            // 
            this.outStandingDataGridView.AllowUserToAddRows = false;
            this.outStandingDataGridView.AllowUserToDeleteRows = false;
            this.outStandingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outStandingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outStandingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.미체결_주문번호,
            this.미체결_종목코드,
            this.미체결_종목명,
            this.미체결_주문수량,
            this.미체결_주문가격,
            this.미체결_미체결수량,
            this.미체결_주문구분,
            this.미체결_체결가,
            this.미체결_현재가,
            this.미체결_시간});
            this.outStandingDataGridView.Location = new System.Drawing.Point(0, 0);
            this.outStandingDataGridView.MultiSelect = false;
            this.outStandingDataGridView.Name = "outStandingDataGridView";
            this.outStandingDataGridView.RowHeadersVisible = false;
            this.outStandingDataGridView.RowTemplate.Height = 23;
            this.outStandingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outStandingDataGridView.Size = new System.Drawing.Size(324, 185);
            this.outStandingDataGridView.TabIndex = 0;
            // 
            // 미체결_주문번호
            // 
            this.미체결_주문번호.HeaderText = "주문번호";
            this.미체결_주문번호.Name = "미체결_주문번호";
            // 
            // 미체결_종목코드
            // 
            this.미체결_종목코드.HeaderText = "종목코드";
            this.미체결_종목코드.Name = "미체결_종목코드";
            // 
            // 미체결_종목명
            // 
            this.미체결_종목명.HeaderText = "종목명";
            this.미체결_종목명.Name = "미체결_종목명";
            // 
            // 미체결_주문수량
            // 
            this.미체결_주문수량.HeaderText = "주문수량";
            this.미체결_주문수량.Name = "미체결_주문수량";
            this.미체결_주문수량.ReadOnly = true;
            // 
            // 미체결_주문가격
            // 
            this.미체결_주문가격.HeaderText = "주문가격";
            this.미체결_주문가격.Name = "미체결_주문가격";
            this.미체결_주문가격.ReadOnly = true;
            // 
            // 미체결_미체결수량
            // 
            this.미체결_미체결수량.HeaderText = "미체결수량";
            this.미체결_미체결수량.Name = "미체결_미체결수량";
            this.미체결_미체결수량.ReadOnly = true;
            // 
            // 미체결_주문구분
            // 
            this.미체결_주문구분.HeaderText = "주문구분";
            this.미체결_주문구분.Name = "미체결_주문구분";
            this.미체결_주문구분.ReadOnly = true;
            // 
            // 미체결_체결가
            // 
            this.미체결_체결가.HeaderText = "체결가";
            this.미체결_체결가.Name = "미체결_체결가";
            this.미체결_체결가.ReadOnly = true;
            // 
            // 미체결_현재가
            // 
            this.미체결_현재가.HeaderText = "현재가";
            this.미체결_현재가.Name = "미체결_현재가";
            this.미체결_현재가.ReadOnly = true;
            // 
            // 미체결_시간
            // 
            this.미체결_시간.HeaderText = "시간";
            this.미체결_시간.Name = "미체결_시간";
            this.미체결_시간.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.30159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.77778F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.balanceAssetLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalBuyPriceLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.assetPriceLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.todayLossPriceLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.todayLossRatioLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.realizationProfitLabel, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 54);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(1, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "당일손익률";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "예수금";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label14.Location = new System.Drawing.Point(1, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "총매입금액";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balanceAssetLabel
            // 
            this.balanceAssetLabel.Location = new System.Drawing.Point(79, 1);
            this.balanceAssetLabel.Name = "balanceAssetLabel";
            this.balanceAssetLabel.Size = new System.Drawing.Size(83, 14);
            this.balanceAssetLabel.TabIndex = 2;
            this.balanceAssetLabel.Text = "0";
            this.balanceAssetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalBuyPriceLabel
            // 
            this.totalBuyPriceLabel.Location = new System.Drawing.Point(79, 18);
            this.totalBuyPriceLabel.Name = "totalBuyPriceLabel";
            this.totalBuyPriceLabel.Size = new System.Drawing.Size(83, 14);
            this.totalBuyPriceLabel.TabIndex = 3;
            this.totalBuyPriceLabel.Text = "0";
            this.totalBuyPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(166, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "예탁자산평가액";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(166, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "당일손익금액";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assetPriceLabel
            // 
            this.assetPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assetPriceLabel.Location = new System.Drawing.Point(272, 1);
            this.assetPriceLabel.Name = "assetPriceLabel";
            this.assetPriceLabel.Size = new System.Drawing.Size(53, 16);
            this.assetPriceLabel.TabIndex = 6;
            this.assetPriceLabel.Text = "0";
            this.assetPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayLossPriceLabel
            // 
            this.todayLossPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todayLossPriceLabel.Location = new System.Drawing.Point(272, 18);
            this.todayLossPriceLabel.Name = "todayLossPriceLabel";
            this.todayLossPriceLabel.Size = new System.Drawing.Size(53, 16);
            this.todayLossPriceLabel.TabIndex = 7;
            this.todayLossPriceLabel.Text = "0";
            this.todayLossPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(166, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "실현손익";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayLossRatioLabel
            // 
            this.todayLossRatioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todayLossRatioLabel.Location = new System.Drawing.Point(79, 35);
            this.todayLossRatioLabel.Name = "todayLossRatioLabel";
            this.todayLossRatioLabel.Size = new System.Drawing.Size(83, 18);
            this.todayLossRatioLabel.TabIndex = 10;
            this.todayLossRatioLabel.Text = "0";
            this.todayLossRatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // realizationProfitLabel
            // 
            this.realizationProfitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.realizationProfitLabel.Location = new System.Drawing.Point(272, 35);
            this.realizationProfitLabel.Name = "realizationProfitLabel";
            this.realizationProfitLabel.Size = new System.Drawing.Size(53, 18);
            this.realizationProfitLabel.TabIndex = 11;
            this.realizationProfitLabel.Text = "0";
            this.realizationProfitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameLable
            // 
            this.userNameLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLable.Location = new System.Drawing.Point(680, 13);
            this.userNameLable.Name = "userNameLable";
            this.userNameLable.Size = new System.Drawing.Size(119, 12);
            this.userNameLable.TabIndex = 12;
            this.userNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(810, 10);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(121, 20);
            this.accountComboBox.TabIndex = 11;
            // 
            // buyComboBox
            // 
            this.buyComboBox.FormattingEnabled = true;
            this.buyComboBox.Location = new System.Drawing.Point(90, 13);
            this.buyComboBox.Name = "buyComboBox";
            this.buyComboBox.Size = new System.Drawing.Size(121, 20);
            this.buyComboBox.TabIndex = 13;
            // 
            // buyCheckBox
            // 
            this.buyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buyCheckBox.AutoSize = true;
            this.buyCheckBox.Checked = true;
            this.buyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buyCheckBox.Location = new System.Drawing.Point(2, 15);
            this.buyCheckBox.Name = "buyCheckBox";
            this.buyCheckBox.Size = new System.Drawing.Size(84, 16);
            this.buyCheckBox.TabIndex = 17;
            this.buyCheckBox.Text = "매수조건식";
            this.buyCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buyCheckBox.UseVisualStyleBackColor = true;
            // 
            // benefitCheckBox
            // 
            this.benefitCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.benefitCheckBox.Location = new System.Drawing.Point(2, 48);
            this.benefitCheckBox.Name = "benefitCheckBox";
            this.benefitCheckBox.Size = new System.Drawing.Size(82, 16);
            this.benefitCheckBox.TabIndex = 20;
            this.benefitCheckBox.Text = "수익률";
            this.benefitCheckBox.UseVisualStyleBackColor = true;
            // 
            // benefitNumericUpDown
            // 
            this.benefitNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.benefitNumericUpDown.DecimalPlaces = 1;
            this.benefitNumericUpDown.Location = new System.Drawing.Point(90, 48);
            this.benefitNumericUpDown.Name = "benefitNumericUpDown";
            this.benefitNumericUpDown.Size = new System.Drawing.Size(121, 21);
            this.benefitNumericUpDown.TabIndex = 21;
            this.benefitNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // lossCutnumericUpDown
            // 
            this.lossCutnumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lossCutnumericUpDown.DecimalPlaces = 1;
            this.lossCutnumericUpDown.Location = new System.Drawing.Point(315, 48);
            this.lossCutnumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lossCutnumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.lossCutnumericUpDown.Name = "lossCutnumericUpDown";
            this.lossCutnumericUpDown.Size = new System.Drawing.Size(120, 21);
            this.lossCutnumericUpDown.TabIndex = 23;
            this.lossCutnumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            // 
            // lossCutCheckBox
            // 
            this.lossCutCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lossCutCheckBox.Checked = true;
            this.lossCutCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lossCutCheckBox.Location = new System.Drawing.Point(227, 48);
            this.lossCutCheckBox.Name = "lossCutCheckBox";
            this.lossCutCheckBox.Size = new System.Drawing.Size(82, 16);
            this.lossCutCheckBox.TabIndex = 22;
            this.lossCutCheckBox.Text = "손절";
            this.lossCutCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalAmountNumericUpDown
            // 
            this.totalAmountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalAmountNumericUpDown.Location = new System.Drawing.Point(505, 13);
            this.totalAmountNumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.totalAmountNumericUpDown.Name = "totalAmountNumericUpDown";
            this.totalAmountNumericUpDown.Size = new System.Drawing.Size(89, 21);
            this.totalAmountNumericUpDown.TabIndex = 24;
            this.totalAmountNumericUpDown.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(441, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "1회 매수";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Location = new System.Drawing.Point(441, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "종목개수";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockCountUpDown
            // 
            this.stockCountUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockCountUpDown.Location = new System.Drawing.Point(505, 48);
            this.stockCountUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.stockCountUpDown.Name = "stockCountUpDown";
            this.stockCountUpDown.Size = new System.Drawing.Size(89, 21);
            this.stockCountUpDown.TabIndex = 26;
            // 
            // tradingStartButton
            // 
            this.tradingStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tradingStartButton.Location = new System.Drawing.Point(12, 73);
            this.tradingStartButton.Name = "tradingStartButton";
            this.tradingStartButton.Size = new System.Drawing.Size(199, 23);
            this.tradingStartButton.TabIndex = 28;
            this.tradingStartButton.Text = "시작";
            this.tradingStartButton.UseVisualStyleBackColor = true;
            // 
            // tradingStopButton
            // 
            this.tradingStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tradingStopButton.Location = new System.Drawing.Point(227, 73);
            this.tradingStopButton.Name = "tradingStopButton";
            this.tradingStopButton.Size = new System.Drawing.Size(199, 23);
            this.tradingStopButton.TabIndex = 29;
            this.tradingStopButton.Text = "중지";
            this.tradingStopButton.UseVisualStyleBackColor = true;
            // 
            // sellCheckBox
            // 
            this.sellCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellCheckBox.Location = new System.Drawing.Point(227, 15);
            this.sellCheckBox.Name = "sellCheckBox";
            this.sellCheckBox.Size = new System.Drawing.Size(82, 16);
            this.sellCheckBox.TabIndex = 30;
            this.sellCheckBox.Text = "전체매도";
            this.sellCheckBox.UseVisualStyleBackColor = true;
            // 
            // sellComboBox
            // 
            this.sellComboBox.FormattingEnabled = true;
            this.sellComboBox.Location = new System.Drawing.Point(315, 13);
            this.sellComboBox.Name = "sellComboBox";
            this.sellComboBox.Size = new System.Drawing.Size(121, 20);
            this.sellComboBox.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 569);
            this.Controls.Add(this.sellComboBox);
            this.Controls.Add(this.sellCheckBox);
            this.Controls.Add(this.tradingStopButton);
            this.Controls.Add(this.tradingStartButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.stockCountUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalAmountNumericUpDown);
            this.Controls.Add(this.lossCutnumericUpDown);
            this.Controls.Add(this.lossCutCheckBox);
            this.Controls.Add(this.benefitNumericUpDown);
            this.Controls.Add(this.benefitCheckBox);
            this.Controls.Add(this.buyCheckBox);
            this.Controls.Add(this.buyComboBox);
            this.Controls.Add(this.userNameLable);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.insertListBox);
            this.Controls.Add(this.deleteListBox);
            this.Controls.Add(this.conditionDataGridView);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Controls.Add(this.conditionItemdataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.conditionItemdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outStandingDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.benefitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lossCutnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView conditionItemdataGridView;
        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.DataGridView conditionDataGridView;
        private System.Windows.Forms.ListBox insertListBox;
        private System.Windows.Forms.ListBox deleteListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.DataGridView balanceDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView outStandingDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label balanceAssetLabel;
        private System.Windows.Forms.Label totalBuyPriceLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label assetPriceLabel;
        private System.Windows.Forms.Label userNameLable;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_보유수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_평균단가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_현재가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_평가금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_손익금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_손익율;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_매입금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_주문번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_주문수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_주문가격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_미체결수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_주문구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_체결가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_현재가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_시간;
        private System.Windows.Forms.ComboBox buyComboBox;
        private System.Windows.Forms.CheckBox buyCheckBox;
        private System.Windows.Forms.CheckBox benefitCheckBox;
        private System.Windows.Forms.NumericUpDown benefitNumericUpDown;
        private System.Windows.Forms.NumericUpDown lossCutnumericUpDown;
        private System.Windows.Forms.CheckBox lossCutCheckBox;
        private System.Windows.Forms.NumericUpDown totalAmountNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown stockCountUpDown;
        private System.Windows.Forms.Button tradingStartButton;
        private System.Windows.Forms.Button tradingStopButton;
        private System.Windows.Forms.Label todayLossPriceLabel;
        private System.Windows.Forms.Label todayLossRatioLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건종목_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건종목_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건종목_현재가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건종목_등락율;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건종목_전일대비;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건종목_거래량;
        private System.Windows.Forms.Label realizationProfitLabel;
        private System.Windows.Forms.CheckBox sellCheckBox;
        private System.Windows.Forms.ComboBox sellComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건_조건번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건_조건명;
    }
}

