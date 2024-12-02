//  20230602_issue599_Sherry 修正issue599：(SIT-2)沒有帶出銀行資料
//  20230710_issue1038_Sherry 修正issue1038：(UAT-2)若承諾費期間有還款明細須拆分
//  20230717_issue1022_Sherry 修正issue1022：(UAT-2)外幣須小數兩位
//  20230808_issue1047_Sherry 修正issue1047：(UAT-2)調整銀行順序
//  20240123_issue193_Sherry 修正issue193：(正式環境)作業須連動設定可多選
//  20240627_1100390_issue607: 調整AP_LOG

//using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace Component.Dto
{
    /// <summary>
    /// 承諾費作業
    /// </summary>
    public class CfeeDto : BaseDto
    {
        /// <summary>
        /// 排序
        /// </summary>
        public int IsOrderBy { get; set; }

        /// <summary>
        /// 聯貸案名稱
        /// </summary>
        public string SYN_NAME { get; set; }
        public string SynId { get; set; }

        /// <summary>
        /// 編輯模式
        /// </summary>
        public string EditMode { get; set; }

        /// <summary>
        /// 交易編號
        /// </summary>
        public string TxnId { get; set; }

        /// <summary>
        /// 版本序號
        /// </summary>
        public short? Seq { get; set; }
        public string FacTxnId { get; set; } = string.Empty;
        public string CcyDecimal { get; set; } = string.Empty;

        /// <summary>
        /// 資料查詢結果
        /// </summary>
        public List<CfeeList> CfeeList { get; set; }

        public CfeeData CfeeData { get; set; }

        public List<CodeList> CalBaseList { get; set; }

        public List<CodeList> ChkUseList { get; set; }

        public List<CodeList> MinUseList { get; set; }

        public List<CodeList> CollTypeList { get; set; }

        public List<CodeList> CcyList { get; set; }
    }

    /// <summary>
    /// 資料查詢結果
    /// </summary>
    public class CfeeList
    {
        public string TxnId { get; set; }
        public short? Seq { get; set; }
        /// <summary>
        /// 聯貸案編號
        /// </summary>
        public string SynId { get; set; }

        /// <summary>
        /// 聯貸案名稱
        /// </summary>
        public string SynName { get; set; }

        /// <summary>
        /// 額度種類
        /// </summary>
        public string FacType { get; set; }

        /// <summary>
        /// 幣別
        /// </summary>
        public string CcyId { get; set; }

        /// <summary>
        /// 收取日期
        /// </summary>
        public string CollDate { get; set; }

        /// <summary>
        /// 完成日期
        /// </summary>
        public string FinishDate { get; set; }

        /// <summary>
        /// 資料狀態
        /// </summary>
        public short? Status { get; set; }

        // <summary>
        /// 審核日期
        /// </summary>
        public DateTime? ExamDate { get; set; }

    }

    public class CfeeData :BaseDto
    {
        /// <summary>
        /// 聯貸案清單
        /// </summary>
        public List<SynList> SynList { get; set; }

        /// <summary>
        /// 額度種類清單
        /// </summary>
        public List<FacTypeList> FacList { get; set; }

        /// <summary>
        /// 聯貸案名稱
        /// </summary>
        public string SynName { get; set; }

        /// <summary>
        /// 額度種類
        /// </summary>
        public string FacType { get; set; }

        /// <summary>
        /// 可用額度
        /// </summary>
        public decimal FacOutstd { get; set; }

        /// <summary>
        /// 承諾費設定
        /// </summary>
        public CfeeSetData CfeeSetData { get; set; }
        public string EditMode { get; set; }

        public string SynId { get; set; } = string.Empty;
        public string TxnId { get; set; } = string.Empty;
        public short Seq { get; set; } = 0;
        public string SetTxnId { get; set; } = string.Empty;
        public short SetSeq { get; set; } = 0;
        public string FacTxnId { get; set; } = string.Empty;
        public string CcyCode { get; set; } = string.Empty;
        public string CcyId { get; set; } = string.Empty;
        public decimal? CollAmt { get; set; }
        public decimal? CollReduceAmt { get; set; }
        public decimal? CollRealAmt { get; set; }
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
        public short? CollDays { get; set; }
        public string CollDate { get; set; } = string.Empty;
        public string Memo { get; set; } = string.Empty;
        public string SignImg { get; set; } = string.Empty;
        public string FinishDate { get; set; } = string.Empty;
        public short? Status { get; set; }
        public string ModifyId { get; set; } = string.Empty;
        public string ModifyName { get; set; } = string.Empty;
        public DateTime? ModifyDate { get; set; }
        public string ExamId { get; set; } = string.Empty;
        public string ExamName { get; set; } = string.Empty;
        public DateTime? ExamDate { get; set; }
        public string Modify1Id { get; set; } = string.Empty;
        public string Modify1Name { get; set; } = string.Empty;
        public DateTime? Modify1Date { get; set; }
        public string Exam1Id { get; set; } = string.Empty;
        public string Exam1Name { get; set; } = string.Empty;
        public DateTime? Exam1Date { get; set; }
        public string CancelReason { get; set; } = string.Empty;

        public List<CfeeSetSchData> CfeeSetSchList { get; set; }
        public List<CfeeSchData> CfeeSchList { get; set; }
        public CfeeSchData CfeeSchData { get; set; }
        //public CfeeDetailData CfeeDetailData { get; set; }
        public List<CfeeBankData> CfeeBankList { get; set; }
        public List<CfeeDetailData> CfeeDetailList { get; set; }
        public List<CfeeFacData> CfeeFacList { get; set; }
    }   

    public class CfeeSchData
    {
        public string SynId { get; set; } = string.Empty;
        public string TxnId { get; set; } = string.Empty;
        public short? Seq { get; set; }
        public string EndDate { get; set; } = string.Empty;

        public List<CfeeDetailData> CfeeDetailList { get; set; }

        public List<CfeeBankData> CfeeBankList { get; set; }

        public decimal? SumChkUseAmt { get; set; }
        public decimal? SumCollAutoAmt { get; set; }
        public decimal? SumCollRealAmt { get; set; }
    }

    public class CfeeDetailData
    {
        public string SynId { get; set; } = string.Empty;
        public string TxnId { get; set; } = string.Empty;
        public short? Seq { get; set; }
        public string SchEndDate { get; set; } = string.Empty;
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
        public string CcyCode { get; set; } = string.Empty;
        public string CcyId { get; set; } = string.Empty;
        public decimal? MinBaseAmt { get; set; }
        public decimal? MinUseRate { get; set; }
        public decimal? MinUseAmt { get; set; }
        public decimal? ChkUseAmt { get; set; }
        public decimal? UseOutstd { get; set; }
        public short? CollDays { get; set; }
        public decimal? CollAmt { get; set; }
    }

    public class CfeeBankData :BaseDto
    {
        public string SynId { get; set; } = string.Empty;
        public string TxnId { get; set; } = string.Empty;
        public short? Seq { get; set; }
        public string BankId { get; set; } = string.Empty;
        public string BankName { get; set; } = string.Empty;
        public string SchEndDate { get; set; } = string.Empty;
        public string CcyCode { get; set; } = string.Empty;
        public string CcyId { get; set; } = string.Empty;
        public decimal? ChkUseAmt { get; set; }
        public decimal? CollAutoAmt { get; set; }
        public decimal? CollRealAmt { get; set; }
        public short? Priority { get; set; }
    }
    public class CfeeFacData
    {
        public string SynId { get; set; } = string.Empty;
        public string TxnId { get; set; } = string.Empty;
        public short? Seq { get; set; }
        public string FacTxnId { get; set; } = string.Empty;
    }

    public class UseOutstdNode
    {
        public decimal Amt { get; set; }
        public decimal RepayAmt { get; set; }
        public DateTime UseDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Type { get; set; }
        public string TxnId { get; set; }
        public decimal ExgRate { get; set; }
        public int UseDays { get; set; }
        public decimal CollAmt { get; set; }
        public decimal UseOutstd { get; set; }
    }
}