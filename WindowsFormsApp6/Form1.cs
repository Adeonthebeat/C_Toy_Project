using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        const string 계좌평가현황요청_화면 = "5001";
        const string 실시간미체결요청_화면 = "5002";
        const string 조건검색_화면 = "5003";
        const string 조건종목요청_화면 = "5004";
        const string 주식기본정보요청_화면 = "5005";
        const string 주식매수요청_화면 = "5006";
        const string 주식매도요청_화면 = "5007";
        const string 실시간데이터요청_화면 = "5008";
        const string 매도주문_화면 = "5009";
        const string 일자별실현손익_화면 = "5010";

        List<ConditionObject> conditionList;

        bool isTrading = false;


        public Form1()
        {
            InitializeComponent();

            tradingStartButton.Click += ButtonClicked;
            tradingStopButton.Click += ButtonClicked;
            conditionDataGridView.SelectionChanged += SelectionChanged;

            axKHOpenAPI1.OnReceiveChejanData += OnReceiveChejanData;
            axKHOpenAPI1.OnReceiveRealCondition += OnReceiveRealCondition;
            axKHOpenAPI1.OnReceiveTrCondition += OnReceiveTrCondition;
            axKHOpenAPI1.OnReceiveConditionVer += OnReceiveConditionVer;
            axKHOpenAPI1.OnReceiveRealData += OnReceiveRealData;
            axKHOpenAPI1.OnReceiveTrData += OnReceiveTrData;
            axKHOpenAPI1.OnEventConnect += OnEventConnect;


            axKHOpenAPI1.CommConnect();

        }
        public void OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            /************************************************
            Console.WriteLine("e.sRealData "+ e.sRealData);
            Console.WriteLine("e.sRealKey " + e.sRealKey);
            Console.WriteLine("e.sRealType " + e.sRealType);
            Console.WriteLine("주식체결");
            *************************************************/
            if (e.sRealType.Equals("주식체결"))
            {
                try
                {
                    string 종목코드 = e.sRealKey;
                    for (int i = 0; i < balanceDataGridView.RowCount; i++)
                    {
                        Delay(50);
                        deleteListBox.Items.Add(" ::::: 주식체결 Delay(50) :::::");

                        if (balanceDataGridView["잔고_종목코드", i].Value.ToString().Equals(종목코드))
                        {
                            long 현재가 = long.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 10)); if (현재가 < 0) { 현재가 = -현재가; }
                            long 보유수량 = long.Parse(balanceDataGridView["잔고_보유수량", i].Value.ToString().Replace(",", ""));
                            long 매입금액 = long.Parse(balanceDataGridView["잔고_매입금액", i].Value.ToString().Replace(",", ""));
                            long 평가금액 = 보유수량 * 현재가;
                            long 손익금액 = 평가금액 - 매입금액;
                            double 수수료 = 매입금액 * 0.007;
                            double 매입수수료 = (double)매입금액 + 수수료;
                            //double 손익율 = (100 * (평가금액 - 매입금액) / (double)매입금액);
                            double 손익율 = (100 * (평가금액 - 매입수수료) / (double)매입수수료);


                            /* 주식체결 GRID */
                            balanceDataGridView["잔고_현재가", i].Value = String.Format("{0:###,#}", 현재가);
                            balanceDataGridView["잔고_평가금액", i].Value = String.Format("{0:###,#}", 평가금액);
                            balanceDataGridView["잔고_손익금액", i].Value = String.Format("{0:###,#}", 손익금액);
                            balanceDataGridView["잔고_손익율", i].Value = String.Format("{0:F2}", 손익율) + "%";


                            if (isTrading)
                            {
                                if (benefitCheckBox.Checked)
                                {
                                    double takeBenefit = (double)benefitNumericUpDown.Value;

                                    if (손익율 >= takeBenefit)
                                    {
                                        int orderResult = axKHOpenAPI1.SendOrder("매도주문", 매도주문_화면, accountComboBox.Text, 2, 종목코드, (int)보유수량, 0, "03", "");
                                        if (orderResult == 0)
                                        {
                                            insertListBox.Items.Add("[매도 주문요청 성공] 조건명 : takeBenefit ||  " + axKHOpenAPI1.GetMasterCodeName(종목코드));
                                        }
                                        else
                                        {
                                            insertListBox.Items.Add("[매도 주문요청 실패] 조건명 : takeBenefit ||  " + axKHOpenAPI1.GetMasterCodeName(종목코드));
                                        }
                                    }
                                }
                                if (lossCutCheckBox.Checked)
                                {
                                    double takeLoss = (double)lossCutnumericUpDown.Value;

                                    if (손익율 <= takeLoss)
                                    {
                                        int orderResult = axKHOpenAPI1.SendOrder("매도주문", 매도주문_화면, accountComboBox.Text, 2, 종목코드, (int)보유수량, 0, "03", "");
                                        if (orderResult == 0)
                                        {
                                            insertListBox.Items.Add(" :::::: [매도 주문요청 성공] 조건명 : takeLoss ::::: " + axKHOpenAPI1.GetMasterCodeName(종목코드));
                                        }
                                        else
                                        {
                                            insertListBox.Items.Add(" ::::: [매도 주문요청 실패] 조건명  : takeLoss :::::" + axKHOpenAPI1.GetMasterCodeName(종목코드));
                                        }
                                    }
                                }
                                if (sellCheckBox.Checked)
                                {
                                    insertListBox.Items.Add(" ::::: [일괄매도 주문요청 시작] :::::");

                                    int orderResult = axKHOpenAPI1.SendOrder("매도주문", 매도주문_화면, accountComboBox.Text, 2, 종목코드, (int)보유수량, 0, "03", "");
                                    if (orderResult == 0)
                                    {
                                        insertListBox.Items.Add(" ::::: [일괄매도 주문요청 성공] 조건명 : sellCheckBox ::::: " + axKHOpenAPI1.GetMasterCodeName(종목코드));
                                    }

                                    else
                                    {
                                        insertListBox.Items.Add(" ::::: [일괄매도 주문요청 실패] 조건명 : sellCheckBox ::::: " + axKHOpenAPI1.GetMasterCodeName(종목코드));
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
                catch (Exception exception)
                {
                    //Console.WriteLine("매도주문 에러");
                    Console.WriteLine(exception.Message.ToString());
                }
            }
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            if (sender.Equals(tradingStartButton))
            {
                isTrading = true;
                tradingStopButton.Enabled = true;
                tradingStartButton.Enabled = false;
            }
            else if (sender.Equals(tradingStopButton))
            {
                isTrading = false;
                tradingStopButton.Enabled = false;
                tradingStartButton.Enabled = true;
            }
        }

        public void OnReceiveChejanData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEvent e)
        {
            /* 접수 및 체결 */
            if (e.sGubun.Equals("0"))
            {
                deleteListBox.Items.Add("::::: 접수 및 체결 ::::: " + e.sGubun + " :: " + e.nItemCnt + " :: " + e.sFIdList);
            }
            /* 잔고 */
            else if (e.sGubun.Equals("1"))
            {
                deleteListBox.Items.Add("::::: 잔고 ::::: " + e.sGubun + " :: " + e.nItemCnt + " :: " + e.sFIdList);

                string totalBuyingPrice = axKHOpenAPI1.GetChejanData(932); /* 총매입가 */

                deleteListBox.Items.Add("::::: totalBuyingPrice ::::: " + totalBuyingPrice);

                requestAccountEstimation();
                requestOutstandingData();
            }
        }

        public void OnReceiveRealCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealConditionEvent e)
        {
            /* 종목코드 */
            string 종목코드 = e.sTrCode;

            /*  이벤트 종류, "I":종목편입, "D", 종목이탈 */
            int 조건번호 = int.Parse(e.strConditionIndex);

            /* 조건식 이름 */
            string 조건명 = e.strConditionName;

            ConditionObject conditionObject = conditionList.Find(o => o.조건번호 == 조건번호);

            if (conditionObject != null)
            {
                /* 종목편입 */
                if (e.strType.Equals("I"))
                {
                    axKHOpenAPI1.SetInputValue("종목코드", 종목코드);
                    axKHOpenAPI1.CommRqData("주식기본정보요청;" + 조건번호, "opt10001", 0, 주식기본정보요청_화면);
                    //insertListBox.Items.Add("[종목편입] 조건명 : " + 조건명 + " 종목코드 : " + 종목코드);
                }
                /* 종목이탈 */
                else if (e.strType.Equals("D"))
                {
                    StockItemObject stockItem = conditionObject.stockItemObjectList.Find(o => o.종목코드 == 종목코드);
                    if (stockItem != null)
                    {
                        //deleteListBox.Items.Add("[종목이탈] 조건명 : " + 조건명 + " 종목코드 : " + 종목코드);
                        conditionObject.stockItemObjectList.Remove(stockItem);
                    }
                }
            }

        }
        /* 조건검색 요청으로 검색된 종목코드 리스트를 전달 */
        public void OnReceiveTrCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {
            int 조건번호 = e.nIndex;
            string 조건명 = e.strConditionName;
            string codeList = e.strCodeList;

            if (codeList.Length < 1) { return; }
            if (codeList[codeList.Length - 1] == ';')
            {
                codeList = codeList.Remove(codeList.Length - 1);
            }

            int codeCount = codeList.Split(';').Length;


            // ; 주의!
            axKHOpenAPI1.CommKwRqData(codeList, 0, codeCount, 0, "조건종목요청;" + 조건번호, 조건종목요청_화면);

        }

        public void SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender.Equals(conditionDataGridView))
                {
                    if (conditionDataGridView.SelectedCells.Count > 0)
                    {
                        int rowIndex = conditionDataGridView.SelectedCells[0].RowIndex;

                        if (rowIndex > -1 && rowIndex < conditionDataGridView.Rows.Count)
                        {
                            int 조건번호 = int.Parse(conditionDataGridView["조건_조건번호", rowIndex].Value.ToString());
                            string 조건명 = conditionDataGridView["조건_조건명", rowIndex].Value.ToString();

                            int result = axKHOpenAPI1.SendCondition(조건검색_화면, 조건명, 조건번호, 1);

                            if (result == 1)
                            {
                                Console.WriteLine("조건검색 성공");
                            }
                            else
                            {
                                //Console.WriteLine("조건검색 실패");

                                ConditionObject conditionObject = conditionList.Find(o => o.조건번호 == 조건번호);
                                if (conditionObject != null)
                                {
                                    conditionItemdataGridView.Rows.Clear();
                                    for (int i = 0; i < conditionObject.stockItemObjectList.Count; i++)
                                    {
                                        StockItemObject stockItem = conditionObject.stockItemObjectList[i];

                                        conditionItemdataGridView.Rows.Add();
                                        conditionItemdataGridView["조건종목_종목코드", i].Value = stockItem.종목코드;
                                        conditionItemdataGridView["조건종목_종목명", i].Value = stockItem.종목명;
                                        conditionItemdataGridView["조건종목_현재가", i].Value = String.Format("{0:###,#}", stockItem.현재가);
                                        conditionItemdataGridView["조건종목_등락율", i].Value = String.Format("{0:F2}", stockItem.등락율) + "%";
                                        conditionItemdataGridView["조건종목_전일대비", i].Value = String.Format("{0:###,#}", stockItem.전일대비);
                                        conditionItemdataGridView["조건종목_거래량", i].Value = String.Format("{0:###,#}", stockItem.거래량);

                                        if (stockItem.전일대비 > 0)
                                        {
                                            conditionItemdataGridView["조건종목_전일대비", i].Style.ForeColor = Color.Red;
                                            conditionItemdataGridView["조건종목_등락율", i].Style.ForeColor = Color.Red;
                                        }
                                        else if (stockItem.전일대비 < 0)
                                        {
                                            conditionItemdataGridView["조건종목_전일대비", i].Style.ForeColor = Color.Blue;
                                            conditionItemdataGridView["조건종목_등락율", i].Style.ForeColor = Color.Blue;
                                        }
                                        else
                                        {
                                            conditionItemdataGridView["조건종목_전일대비", i].Style.ForeColor = Color.Black;
                                            conditionItemdataGridView["조건종목_등락율", i].Style.ForeColor = Color.Black;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                //Console.WriteLine("SelectionChanged 에러");
                Console.WriteLine(exception.Message.ToString());
            }

        }

        public void OnReceiveConditionVer(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {
            conditionList = new List<ConditionObject>();
            string conditionNameList = axKHOpenAPI1.GetConditionNameList();

            string[] conditionNameArray = conditionNameList.Split(';');
            for (int i = 0; i < conditionNameArray.Length; i++)
            {
                string[] condition = conditionNameArray[i].Split('^');

                if (condition.Length == 2)
                {
                    try
                    {
                        int 조건인덱스 = int.Parse(condition[0].Trim());    // 조건인덱스
                        string 조건명 = condition[1].Trim();                // 조건명

                        conditionDataGridView.Rows.Add();
                        conditionDataGridView["조건_조건번호", i].Value = 조건인덱스;
                        conditionDataGridView["조건_조건명", i].Value = 조건명;

                        /* 조건정보 저장 리스트 */
                        conditionList.Add(new ConditionObject(조건인덱스, 조건명));
                        //Console.WriteLine("조건정보 저장 리스트 Save");

                        /* 조건정보 DataSource & Read Only */
                        conditionDataGridView.ReadOnly = true;

                        buyComboBox.Items.Add(조건명);
                        sellComboBox.Items.Add(조건명);
                        buyComboBox.SelectedIndex = 1;
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message.ToString());
                        Console.WriteLine("조건정보 저장 에러");
                    }
                }
            }
        }

        public void OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            /* 계좌평가현황요청 */
            if (e.sRQName.Equals("계좌평가현황요청"))
            {
                //Delay(100);
                //Console.WriteLine("계좌평가현황요청 시작");
                try
                {
                    //Console.WriteLine("계좌 데이터 확인");
                    long 예수금 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "예수금"));
                    long 총매입금액 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총매입금액"));
                    long 추정예수금 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "D+2추정예수금"));
                    long 예탁자산평가액 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "예탁자산평가액"));
                    long 당일투자손익 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당일투자손익"));
                    double 당일손익율 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당일손익율"));

                    /* 계좌 */
                    balanceAssetLabel.Text = String.Format("{0:###,#}", 예수금);
                    totalBuyPriceLabel.Text = String.Format("{0:###,#}", 총매입금액);
                    assetPriceLabel.Text = String.Format("{0:###,#}", 예탁자산평가액);
                    todayLossPriceLabel.Text = String.Format("{0:###,#}", 당일투자손익);
                    todayLossRatioLabel.Text = String.Format("{0:F2}", 당일손익율) + "%";



                    /* 잔고 */
                    //Console.WriteLine("잔고 확인");

                    int n = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                    balanceDataGridView.Rows.Clear();
                    for (int i = 0; i < n; i++)
                    {
                        Delay(50);
                        string 종목코드 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim().Replace("A", "");
                        string 종목명 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                        long 보유수량 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량").Trim());
                        double 평균단가 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "평균단가").Trim());
                        long 현재가 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim());
                        long 평가금액 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "평가금액").Trim());
                        long 손익금액 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익금액").Trim());
                        //double 손익율 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익율").Trim());
                        long 매입금액 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입금액").Trim());
                        double 수수료 = 매입금액 * 0.007;
                        double 매입수수료 = (double)매입금액 + 수수료;
                        double 손익율 = (100 * (평가금액 - 매입수수료) / (double)매입수수료);


                        balanceDataGridView.Rows.Add();
                        balanceDataGridView["잔고_종목코드", i].Value = 종목코드;
                        balanceDataGridView["잔고_종목명", i].Value = 종목명;
                        balanceDataGridView["잔고_보유수량", i].Value = String.Format("{0:###,#}", 보유수량);
                        balanceDataGridView["잔고_평균단가", i].Value = String.Format("{0:###,#}", 평균단가);
                        balanceDataGridView["잔고_현재가", i].Value = String.Format("{0:###,#}", 현재가);
                        balanceDataGridView["잔고_평가금액", i].Value = String.Format("{0:###,#}", 평가금액);
                        balanceDataGridView["잔고_손익금액", i].Value = String.Format("{0:###,#}", 손익금액);
                        balanceDataGridView["잔고_손익율", i].Value = String.Format("{0:F2}", 손익율) + "%";
                        balanceDataGridView["잔고_매입금액", i].Value = String.Format("{0:###,#}", 매입금액);
                        //Console.WriteLine("잔고 확인 완료");

                        if (손익율 > 0)
                        {
                            balanceDataGridView["잔고_손익금액", i].Style.ForeColor = Color.Red;
                            balanceDataGridView["잔고_손익율", i].Style.ForeColor = Color.Red;
                        }
                        else if (손익율 < 0)
                        {
                            balanceDataGridView["잔고_손익금액", i].Style.ForeColor = Color.Blue;
                            balanceDataGridView["잔고_손익율", i].Style.ForeColor = Color.Blue;
                        }
                        else
                        {
                            balanceDataGridView["잔고_손익금액", i].Style.ForeColor = Color.Black;
                            balanceDataGridView["잔고_손익율", i].Style.ForeColor = Color.Black;
                        }
                        /* 실시간데이터요청 */
                        axKHOpenAPI1.SetRealReg(실시간데이터요청_화면, 종목코드, "10; 11; 12; 15;", "1");
                        //Console.WriteLine("실시간데이터요청(실시간데이터요청_화면)");

                    }

                }
                catch (Exception exception)
                {
                    //Console.WriteLine("계좌평가현황요청 에러");
                    Console.WriteLine(exception.Message.ToString());
                }

            }
            /* 실시간미체결요청 */
            else if (e.sRQName.Equals("실시간미체결요청"))
            {
                try
                {
                    /* 미체결 잔고 */
                    int n = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                    //Console.WriteLine("실시간미체결요청 개수 : " + n);

                    outStandingDataGridView.Rows.Clear();
                    for (int i = 0; i < n; i++)
                    {
                        Delay(50);
                        //Console.WriteLine("실시간미체결요청 GRID");
                        string 주문번호 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문번호").Trim();
                        string 종목코드 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim().Replace("A", "");
                        string 종목명 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                        long 주문수량 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문수량").Trim());
                        long 주문가격 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문가격").Trim());
                        long 미체결수량 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "미체결수량").Trim());
                        string 주문구분 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문구분").Trim();
                        long 체결가 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "체결가").Trim());
                        long 현재가 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim());
                        string 시간 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "시간").Trim();

                        /* outStandingDataGridView */
                        outStandingDataGridView.Rows.Add();
                        outStandingDataGridView["미체결_주문번호", i].Value = 주문번호;
                        outStandingDataGridView["미체결_종목코드", i].Value = 종목코드;
                        outStandingDataGridView["미체결_종목명", i].Value = 종목명;
                        outStandingDataGridView["미체결_주문수량", i].Value = String.Format("{0:###,#}", 주문수량);
                        outStandingDataGridView["미체결_주문가격", i].Value = String.Format("{0:###,#}", 주문가격);
                        outStandingDataGridView["미체결_미체결수량", i].Value = String.Format("{0:###,#}", 미체결수량);
                        outStandingDataGridView["미체결_주문구분", i].Value = 주문구분;
                        outStandingDataGridView["미체결_체결가", i].Value = String.Format("{0:###,#}", 체결가);
                        outStandingDataGridView["미체결_현재가", i].Value = String.Format("{0:###,#}", 현재가);
                        outStandingDataGridView["미체결_시간", i].Value = 시간;
                    }

                }
                catch (Exception exception)
                {
                    //Console.WriteLine("실시간미체결요청 에러");
                    Console.WriteLine(exception.Message.ToString());
                }

            }
            /* 조건종목 요청 */
            else if (e.sRQName.Contains("조건종목요청"))
            {
                //Console.WriteLine("조건종목요청 시작");
                if (e.sRQName.Split(';').Length == 2)
                {
                    try
                    {
                        int 조건번호 = int.Parse(e.sRQName.Split(';')[1]);
                        //종목코드 종목명 현재가 전일대비 등락율 거래량
                        int n = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                        int rowIndex = -1;
                        if (conditionDataGridView.SelectedCells.Count > 0)
                        {
                            rowIndex = conditionDataGridView.SelectedCells[0].RowIndex;
                            conditionList[rowIndex].stockItemObjectList.Clear();
                        }

                        conditionItemdataGridView.Rows.Clear();
                        for (int i = 0; i < n; i++)
                        {
                            Delay(50);
                            deleteListBox.Items.Add(" :::: conditionItemdataGridView Delay(50) :::: ");

                            string 종목코드 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim().Replace("A", "");
                            string 종목명 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                            long 현재가 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim());
                            long 전일대비 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "전일대비").Trim());
                            double 등락율 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "등락율").Trim());
                            long 거래량 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "거래량").Trim());

                            conditionItemdataGridView.Rows.Add();
                            conditionItemdataGridView["조건종목_종목코드", i].Value = 종목코드;
                            conditionItemdataGridView["조건종목_종목명", i].Value = 종목명;
                            conditionItemdataGridView["조건종목_현재가", i].Value = String.Format("{0:###,#}", 현재가);
                            conditionItemdataGridView["조건종목_등락율", i].Value = String.Format("{0:F2}", 등락율) + "%";
                            conditionItemdataGridView["조건종목_전일대비", i].Value = String.Format("{0:###,#}", 전일대비);
                            conditionItemdataGridView["조건종목_거래량", i].Value = String.Format("{0:###,#}", 거래량);

                            //Console.WriteLine("조건종목요청 정보 입력 완료");

                            if (전일대비 > 0)
                            {
                                conditionItemdataGridView["조건종목_전일대비", i].Style.ForeColor = Color.Red;
                                conditionItemdataGridView["조건종목_등락율", i].Style.ForeColor = Color.Red;
                            }
                            else if (전일대비 < 0)
                            {
                                conditionItemdataGridView["조건종목_전일대비", i].Style.ForeColor = Color.Blue;
                                conditionItemdataGridView["조건종목_등락율", i].Style.ForeColor = Color.Blue;
                            }
                            else
                            {
                                conditionItemdataGridView["조건종목_전일대비", i].Style.ForeColor = Color.Black;
                                conditionItemdataGridView["조건종목_등락율", i].Style.ForeColor = Color.Black;
                            }

                            ConditionObject conditionObject = conditionList.Find(o => o.조건번호 == 조건번호);
                            if (conditionObject != null)
                            {
                                conditionObject.stockItemObjectList.Add(new StockItemObject(종목코드, 종목명, 현재가, 전일대비, 등락율, 거래량));
                                //Console.WriteLine("저장완료 " + 조건번호 + " 종목코드 : " + 종목코드);
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message.ToString());
                        //Console.WriteLine("조건종목요청 에러");
                    }
                }
            }
            else if (e.sRQName.Contains("주식기본정보요청"))
            {
                insertListBox.Items.Add("::::: 주식기본정보요청 IN :::::");

                if (e.sRQName.Split(';').Length == 2)
                {
                    try
                    {
                        int 조건번호 = int.Parse(e.sRQName.Split(';')[1]);

                        string 종목코드 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드").Trim().Replace("A", "");
                        string 종목명 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim();
                        long 현재가 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim());
                        long 전일대비 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비").Trim());
                        double 등락율 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim());
                        long 거래량 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량").Trim());

                        //Console.WriteLine("주식기본정보요청 그리드 데이터 수신 성공");
                        StockItemObject stockItem = new StockItemObject(종목코드, 종목명, 현재가, 전일대비, 등락율, 거래량);

                        ConditionObject conditionObject = conditionList.Find(o => o.조건번호 == 조건번호);

                        if (conditionObject != null)
                        {
                            insertListBox.Items.Add("[종목편입] 조건명 : " + conditionObject.조건명 + " 종목명 : " + 종목명);

                            /* 종목편입종목 저장 */
                            conditionObject.stockItemObjectList.Add(stockItem);

                            int rowIndex = -1;
                            if (conditionDataGridView.SelectedCells.Count > 0)
                            {
                                rowIndex = conditionDataGridView.SelectedCells[0].RowIndex;

                                if (int.Parse(conditionDataGridView["조건_조건번호", rowIndex].Value.ToString()) == 조건번호)
                                {
                                    //conditionDataGridView.Rows.Insert(0);
                                    conditionDataGridView.Rows.Add();

                                    conditionItemdataGridView["조건종목_종목코드", 0].Value = 종목코드;
                                    conditionItemdataGridView["조건종목_종목명", 0].Value = 종목명;
                                    conditionItemdataGridView["조건종목_현재가", 0].Value = String.Format("{0:###,#}", 현재가);
                                    conditionItemdataGridView["조건종목_등락율", 0].Value = String.Format("{0:F2}", 등락율) + "%";
                                    conditionItemdataGridView["조건종목_전일대비", 0].Value = String.Format("{0:###,#}", 전일대비);
                                    conditionItemdataGridView["조건종목_거래량", 0].Value = String.Format("{0:###,#}", 거래량);

                                    //Console.WriteLine("conditionItemdataGridView 저장 완료");
                                }

                            }
                            /* 만약 현재 매수조건식으로 등록된 조건번호에 의해 전달된 종목코드는 자동매수 */
                            if (isTrading)
                            {
                                deleteListBox.Items.Add("::::: 주식 매수 Delay 시작 :::::");
                                Delay(100);
                                deleteListBox.Items.Add("::::: 주식 매수 Delay 끝   :::::");

                                /* 자동매수요청 주식매수요청_화면 */
                                if (buyCheckBox.Checked)
                                {
                                    if (buyComboBox.Text.Equals(conditionObject.조건명))
                                    {
                                        if (accountComboBox.Text.Length > 0)
                                        {
                                            int 총1회매수금액 = (int)totalAmountNumericUpDown.Value;
                                            int 종목개수 = (int)stockCountUpDown.Value;
                                            //Console.WriteLine("총1회매수금액 : " + 총1회매수금액);
                                            //Console.WriteLine("종목개수 : " + 종목개수);

                                            insertListBox.Items.Add("::::: Trading 시작 :::::");

                                            if (총1회매수금액 > 0 && 현재가 != 0)
                                            {
                                                int 매수량 = 총1회매수금액 / (int)현재가;
                                                //Console.WriteLine("매수량 : " + 매수량);

                                                int 총매수금액 = 매수량 * 총1회매수금액;
                                                //Console.WriteLine("총매수금액 : " + 총매수금액);

                                                /* 자동 주문 */

                                                if (매수량 > 0)
                                                {
                                                    int orderResult = axKHOpenAPI1.SendOrder("주식매수요청", 주식매수요청_화면, accountComboBox.Text, 1, 종목코드, 매수량, 0, "03", "");
                                                    //Console.WriteLine("주식매수요청 | 0 = 성공 | 1 = 실패 : " + orderResult);
                                                    if (orderResult == 0)
                                                    {
                                                        insertListBox.Items.Add("::::: 주문요청성공 ::::: 조건명  : " + conditionObject.조건명 + "::::: 종목명 ::::: " + 종목명);
                                                        //Console.WriteLine("[주문요청성공] 조건명  : " + conditionObject.조건명 + " 종목명 : " + 종목명);
                                                    }
                                                    else
                                                    {
                                                        insertListBox.Items.Add("::::: 주문요청실패 ::::: 조건명 ::::: " + conditionObject.조건명 + "::::: 종목명 ::::: " + 종목명);
                                                        //Console.WriteLine("[주문요청실패] 조건명 : " + conditionObject.조건명 + " 종목명 : " + 종목명);
                                                    }
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        //Console.WriteLine("주식기본정보요청 에러");
                        Console.WriteLine(exception.Message.ToString());
                    }
                }
            }
            else if (e.sRQName.Equals("일자별실현손익"))
            {
                //Console.WriteLine("일자별실현손익 시작");
                try
                {
                    long 실현손익 = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "실현손익").Trim());
                    realizationProfitLabel.Text = String.Format("{0:###,#}", 실현손익);

                    if (실현손익 > 0)
                    {
                        realizationProfitLabel.ForeColor = Color.Red;
                    }
                    else if (실현손익 < 0)
                    {
                        realizationProfitLabel.ForeColor = Color.Blue;
                    }
                    else
                    {
                        realizationProfitLabel.ForeColor = Color.Black;
                    }
                }
                catch (Exception exception)
                {
                    //Console.WriteLine("일자별실현손익 에러");
                    Console.WriteLine(exception.Message.ToString());
                }
            }


        }

        /* 이벤트 */
        public void OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                //Console.WriteLine("로그인 성공");

                string[] accountArray = axKHOpenAPI1.GetLoginInfo("ACCNO").Split(';');
                for (int i = 0; i < accountArray.Length; i++)
                {
                    accountComboBox.Items.Add(accountArray[i]);
                }
                /* 첫번째 계좌 가져오기 */
                if (accountComboBox.Items.Count > 0)
                    accountComboBox.SelectedIndex = 0;




                userNameLable.Text = axKHOpenAPI1.GetLoginInfo("USER_NAME");

                /* 잔고내역 요청 */
                requestAccountEstimation();

                /* 실현손익 요청 */
                requestRelizationProfit();

                /* 미체결데이터 요청 */
                requestOutstandingData();

                /* 조건 Load */
                axKHOpenAPI1.GetConditionLoad();
            }
            else if (e.nErrCode == 100)
            {
                //Console.WriteLine("사용자 정보교환 실패");
            }
            else if (e.nErrCode == 101)
            {
                //Console.WriteLine("서버접속 실패");
            }
            else if (e.nErrCode == 102)
            {
                //Console.WriteLine("버전처리 실패");
            }
        }


        /* 실현손익 요청 */
        public void requestRelizationProfit()
        {
            if (accountComboBox.Text.Length > 0)
            {
                axKHOpenAPI1.SetInputValue("계좌번호", accountComboBox.Text);
                axKHOpenAPI1.SetInputValue("시작일자", DateTime.Now.ToString("yyyyMMdd"));
                axKHOpenAPI1.SetInputValue("종료일자", DateTime.Now.ToString("yyyyMMdd"));

                axKHOpenAPI1.CommRqData("일자별실현손익", "opt10074", 0, 일자별실현손익_화면);
            }
        }
        /* 잔고내역 요청 */
        public void requestAccountEstimation()
        {
            if (accountComboBox.Text.Length > 0)
            {
                axKHOpenAPI1.SetInputValue("계좌번호", accountComboBox.Text);
                axKHOpenAPI1.SetInputValue("비밀번호", "");
                axKHOpenAPI1.SetInputValue("상장폐지조회구분", "0");
                axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");

                axKHOpenAPI1.CommRqData("계좌평가현황요청", "OPW00004", 0, 계좌평가현황요청_화면);
            }
        }
        /* 미체결데이터 요청 */
        public void requestOutstandingData()
        {
            if (accountComboBox.Text.Length > 0)
            {
                axKHOpenAPI1.SetInputValue("계좌번호", accountComboBox.Text);
                axKHOpenAPI1.SetInputValue("체결구분", "1"); //0:체결+미체결조회, 1:미체결조회, 2:체결조회
                axKHOpenAPI1.SetInputValue("매매구분", "0"); //0:전체, 1:매도, 2:매수

                axKHOpenAPI1.CommRqData("실시간미체결요청", "opt10075", 0, 실시간미체결요청_화면);
            }
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }
    }
    /* 전략 정보 */
    class ConditionObject
    {
        public int 조건번호;
        public string 조건명;

        public List<StockItemObject> stockItemObjectList;

        public ConditionObject(int 조건번호, string 조건명)
        {
            this.조건번호 = 조건번호;
            this.조건명 = 조건명;

            /* 주식종목 정보 리스트 */
            stockItemObjectList = new List<StockItemObject>();
        }
    }
    /* 주식종목 정보 */
    class StockItemObject
    {
        public string 종목코드;
        public string 종목명;
        public long 현재가;
        public long 전일대비;
        public double 등락율;
        public long 거래량;

        public StockItemObject(string 종목코드, string 종목명, long 현재가, long 전일대비, double 등락율, long 거래량)
        {
            this.종목코드 = 종목코드;
            this.종목명 = 종목명;
            this.현재가 = 현재가;
            this.등락율 = 등락율;
            this.전일대비 = 전일대비;
            this.거래량 = 거래량;
        }
    }
}

