using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using I.Utility.Helper;
using I.Utility.Extensions;

using Newtonsoft.Json;

namespace home.insurance.cn.Data
{
    public class Repository
    {
        public Order_BaseInfo GetOrderByID(int id)
        {
            var order = new Order_BaseInfo();
            if (id <= 0)
                return order;

            try
            {
                using (var context = new EntityMember())
                {
                    var query = from f in context.Order_BaseInfo
                                where
                                    f.ID == id
                                select f;

                    order = query.FirstOrDefault();
                }
            }
            catch (Exception error)
            {
                LogHelper.AppError(error.Message);
            }

            return order;
        }

        public List<Order_BaseInfo> GetOrderList(int userId)
        {
            var list = new List<Order_BaseInfo>();

            try
            {
                using (var context = new EntityMember())
                {
                    var query = from f in context.Order_BaseInfo
                                where
                                    f.CreateMemberID == userId
                                orderby f.CreateTime descending
                                select f;

                    list = query.ToList();
                }
            }
            catch (Exception error)
            {
                LogHelper.AppError(error.Message);
            }

            return list;
        }

        public void AddOrder(Order_BaseInfo order)
        {
            if (order != null)
                return;

            try
            {
                using (var context = new EntityMember())
                {
                    context.Order_BaseInfo.Add(order);

                    foreach (var item in order.Order_ItemInfo)
                        context.Order_ItemInfo.Add(item);

                    context.SaveChanges();
                }

                this.AddLog(JsonConvert.SerializeObject(order), "增加订单", 20, order.CreateMemberID.Value);
            }
            catch (Exception error)
            {
                LogHelper.AppError(error.Message);
            }
        }




        public void AddLog(string info, string memo, byte type, int createMemberId)
        {
            try
            {
                using (var context = new EntityMember())
                {
                    var log = new SYS_LogInfo
                    {
                        ActionMemo = memo,
                        ActionType = type,
                        CreateMemberID = createMemberId,
                        ActionMsg = info
                    };

                    context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                LogHelper.AppError(error.Message);
            }
        }





        public void AddUserInfo(BaseInfo_UserInfo userInfo)
        {
            if (userInfo != null)
                return;

            try
            {
                using (var context = new EntityMember())
                {
                    context.BaseInfo_UserInfo.Add(userInfo);

                    context.SaveChanges();
                }

                this.AddLog(JsonConvert.SerializeObject(userInfo), "增加用户", 10, userInfo.ID);
            }
            catch (Exception error)
            {
                LogHelper.AppError(error.Message);
            }
        }

        public int GetUserInfoByMobile(string mobile,string ip)
        {
            var returnValue = 0;
            if (mobile.IsNull())
                return returnValue;

            try
            {
                using (var context = new EntityMember())
                {
                    returnValue = (from x in context.BaseInfo_UserInfo
                                   where
                                     x.Mobile == mobile
                                   select x).Count();
                }

                this.AddLog(mobile, "ip :" + ip + " ,通过手机检查用户是否存在", 11, 0);
            }
            catch (Exception error)
            {
                LogHelper.AppError(error.Message);
            }

            return returnValue;
        }

        public int Login(BaseInfo_UserInfo userInfo)
        {
            var returnValue = 0;
            if (userInfo != null)
                return returnValue;

            try
            {
                using (var context = new EntityMember())
                {
                    returnValue = (from x in context.BaseInfo_UserInfo
                                   where
                                        x.Mobile == userInfo.Mobile &&
                                        x.Password == userInfo.Password
                                   select x).Count();
                }

                this.AddLog(
                    userInfo.Mobile,
                    returnValue > 0 ? string.Format("用户{0}登录成功，时间{1}", userInfo.Mobile, DateTime.Now) :
                                    string.Format("用户{0}登录失败，时间{1}", userInfo.Mobile, DateTime.Now), 15, 0);
            }
            catch (Exception error)
            {
                LogHelper.AppError(error.Message);
            }

            return returnValue;
        }
    }
}
