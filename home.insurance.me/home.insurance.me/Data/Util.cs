using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

using I.Utility.Helper;

namespace home.insurance.cn.Data
{
    public class Util
    {

        public void SendSMS(string templateId,string mobile,string[] content)
        {
            var ret = string.Empty;
            var api = new CCPRestSDK.CCPRestSDK();
            var isInit = api.init(this.SMS_SiteUrl, this.SMS_SitePort);

            api.setAppId(this.SMS_AppID);
            api.setAccount(this.SMS_Account, this.SMS_AccountPassword);

            try
            {
                if (isInit)
                {
                    Dictionary<string, object> retData = api.SendTemplateSMS(mobile, templateId, content);
                    ret = GetDictionaryData(retData);
                }
                else
                {
                    LogHelper.Info("连接短信服务器失败！");
                }
            }
            catch (Exception error)
            {
                LogHelper.AppError(error.Message);
            }
        }

        public void SendRegisteSMS(string mobile,string[] content)
        {
            this.SendSMS(this.SMS_RegisteTemplateID, mobile, content);
        }

        string GetDictionaryData(Dictionary<string, object> data)
        {
            string ret = null;
            foreach (KeyValuePair<string, object> item in data)
            {
                if (item.Value != null && item.Value.GetType() == typeof(Dictionary<string, object>))
                {
                    ret += item.Key.ToString() + "={";
                    ret += GetDictionaryData((Dictionary<string, object>)item.Value);
                    ret += "};";
                }
                else
                {
                    ret += item.Key.ToString() + "=" + (item.Value == null ? "null" : item.Value.ToString()) + ";";
                }
            }
            return ret;
        }

        string SMS_RegisteTemplateID
        {
            get
            {
                return ConfigurationManager.AppSettings["SMS_RegisteTemplateID"];
            }
        }

        string SMS_Account
        {
            get
            {
                return ConfigurationManager.AppSettings["SMS_Account"];
            }
        }

        string SMS_AccountPassword
        {
            get
            {
                return ConfigurationManager.AppSettings["SMS_AccountPassword"];
            }
        }

        string SMS_SiteUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["SMS_SiteUrl"];
            }
        }

        string SMS_SitePort
        {
            get
            {
                return ConfigurationManager.AppSettings["SMS_SitePort"];
            }
        }

        string SMS_AppID
        {
            get
            {
                return ConfigurationManager.AppSettings["SMS_AppID"];
            }
        }

        public string ApiUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["ApiUrl"];
            }
        }


        public string ApiKey
        {
            get
            {
                return ConfigurationManager.AppSettings["ApiKey"];
            }
        }


        public string ApiChannelId
        {
            get
            {
                return ConfigurationManager.AppSettings["ApiChannelId"];
            }
        }
    }

    public class EBaoInsuranceInfo
    {
        /// <summary>
        /// 渠道订单号
        /// *
        /// </summary>
        public int DomainOrderId { get; set; }

        /// <summary>
        /// 保单类型
        /// *
        /// 1:个人保单： 4 人及以下4：团体保单： 4 人以上必须使用此类型；
        /// </summary>
        public string PolicyType { get; set; }

        /// <summary>
        /// 产品代码
        /// *
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 方案代码
        /// *
        /// </summary>
        public string PlanId { get; set; }

        /// <summary>
        /// 签单日期
        /// *
        /// yyyy-MM-dd H:mm:ss
        /// </summary>
        public DateTime OperateDate { get; set; }

        /// <summary>
        /// 起保日期
        /// *
        /// yyyy-MM-dd
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 起保时分
        /// *
        /// HH:mm
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 终保日期
        /// *
        /// yyyy-MM-dd
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 终保时分
        /// *
        /// HH:mm
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 投保人数
        /// *
        /// </summary>
        public int ProposalNum { get; set; }

        /// <summary>
        /// 投保人数
        /// *
        /// </summary>
        public int RationCount { get; set; }

        /// <summary>
        /// 每人每份保额
        /// *
        /// </summary>
        public double PersonalAmount { get; set; }

        /// <summary>
        /// 每人每份保费
        /// *
        /// </summary>
        public double PersonalPremium { get; set; }

        /// <summary>
        /// 总保额
        /// *
        /// </summary>
        public double SumAmount { get; set; }

        /// <summary>
        /// 总保费
        /// *
        /// </summary>
        public double SumPremium { get; set; }

        /// <summary>
        /// 投保人姓名
        /// *
        /// </summary>
        public string PolicyholderName { get; set; }

        /// <summary>
        /// 投保人证件类型
        /// *
        ///     01: 身份证 
        ///     02：户口簿 
        ///     03：护照 
        ///     04：军官证 
        ///     05:驾驶执照 
        ///     06：返乡证 
        ///     07：港澳身份证 
        ///     99：其它
        /// </summary>
        public int IdentifyType { get; set; }

        /// <summary>
        /// 投保人证件号码
        /// *
        /// </summary>
        public string IdentifyNumber { get; set; }

        /// <summary>
        /// 投保人性别
        /// *
        /// 1：男； 2：女
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string TelPhone { get; set; }

        /// <summary>
        /// SendSMS
        /// Y:发送 N:不发送
        /// </summary>
        public string SendSMS { get; set; }

        /// <summary>
        /// 投保人手机号
        /// *
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 被保险人信息
        /// </summary>
        public List<InsuredInfo> InsuredInfos { get; set; }

        /// <summary>
        /// 投保人手机号
        /// </summary>
        public string ExtendFirst { get; set; }

        /// <summary>
        /// 投保人手机号
        /// </summary>
        public string ExtendSecond { get; set; }

        /// <summary>
        /// 投保人手机号
        /// </summary>
        public string ExtendThird { get; set; }

        /// <summary>
        /// 乘机日（返程/中转）
        /// </summary>
        public string ExtendFourth { get; set; }

        /// <summary>
        /// 航班号(返程/中转)
        /// </summary>
        public string ExtendFifth { get; set; }

    }

    public class InsuredInfo
    {
        /// <summary>
        /// 被保险人姓名
        /// *
        /// </summary>
        public string InsuredName { get; set; }

        /// <summary>
        /// 证件类型
        /// *
        /// 01:身份证 02：户口簿 03：护照 04：军官证 05:驾驶执照 06：返乡证 07：港澳身份证 99：其它
        /// </summary>
        public string IdentifyType { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        public string IdentifyNumber { get; set; }

        /// <summary>
        /// 被保险人地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string TelPhone { get; set; }

        /// <summary>
        /// 英文名/拼音
        /// </summary>
        public string EName { get; set; }

        /// <summary>
        /// 手机号
        /// *
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 性别 1：男， 2：女
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        public string Bank { get; set; }

        /// <summary>
        /// 银行账户
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }

        /// <summary>
        /// 被保险人紧急联系人姓名
        /// </summary>
        public string LinkerName { get; set; }

        /// <summary>
        /// 被保险人紧急联系人电话
        /// </summary>
        public string LinkerTel { get; set; }

        /// <summary>
        /// 被保险人驾照号
        /// </summary>
        public string LicenseNo { get; set; }

        /// <summary>
        /// 被保险人学校/班级
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// 被保险人户口所在地
        /// </summary>
        public string LocalPolicStation { get; set; }

        /// <summary>
        /// 职业代码/人员分类
        /// </summary>
        public string OccupationCode { get; set; }

        /// <summary>
        /// 职业类型/人员类别
        /// </summary>
        public string CreditLevel { get; set; }

        /// <summary>
        /// 受益人
        /// </summary>
        public List<Beneficiary> Beneficiarys { get; set; }
    }

    public class Beneficiary
    {
        /// <summary>
        /// 受益人姓名
        /// *
        /// </summary>
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// 证件类型
        /// 01:身份证 02：户口簿 03：护照 04：军官证 05:驾驶执照 06：返乡证 07：港澳身份证 99：其它
        /// </summary>
        public string IdentifyType { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        public string IdentifyNumber { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string TelPhone { get; set; }

        /// <summary>
        /// 英文名/拼音
        /// </summary>
        public string EName { get; set; }

        /// <summary>
        /// 手机号
        /// *
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 性别
        /// 1：男， 2：女
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }

        /// <summary>
        /// 如果一个被保险人有多个受益人，则多个受益人的受益份额之和应该等于 1
        /// *
        /// </summary>
        public double BenefitRate { get; set; }
    }

    public class EBaoResult
    {
        /// <summary>
        /// 渠道订单号
        /// </summary>
        public string DomainOrderId { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 保单类型
        /// 1: 个人保单， 4：团体保单
        /// </summary>
        public int PolicyType { get; set; }

        /// <summary>
        /// 产品代码
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 方案代码
        /// </summary>
        public string PlanId { get; set; }

        /// <summary>
        /// 订单状态
        /// -1:投保失败; -33:拒绝投保; 30:核保中; 35:投保成功；
        /// </summary>
        public int OrderState { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// 如果是团体保单， 返回一条记录； 
        /// 如果是个人保单， 则根据被保险人数返回相应记录数
        /// </summary>
        public List<PolicyInfo> PolicyInfos { get; set; }
    }

    public class PolicyInfo
    {
        /// <summary>
        /// 保单号 
        /// 投保成功时返回
        /// </summary>
        public string PolicyNo { get; set; }

        /// <summary>
        /// 被保险人姓名
        /// 仅当 PolicyType=1（ 个人保单）时返回
        /// </summary>
        public string InsuredName { get; set; }

        /// <summary>
        /// 被保险人证件类型
        /// 仅当 PolicyType=1（ 个人保单）时返回
        /// </summary>
        public int IdentifyType { get; set; }

        /// <summary>
        /// 被保险人证件号码
        /// 仅当 PolicyType=1（ 个人保单）时返回
        /// </summary>
        public string IdentifyNumber { get; set; }
    }
}
