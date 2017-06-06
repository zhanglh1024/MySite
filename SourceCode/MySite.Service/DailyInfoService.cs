using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySite.Core;
using MySite.Model;
using Titan;

namespace MySite.Service
{
    /// <summary>
    /// 个人日记相关服务
    /// </summary>
    public class DailyInfoService : BaseService
    {
        /// <summary>
        /// 添加或修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DailyInfo AddOrUpdate(DailyInfo model)
        {
            if (model.DailyId.IsNull())
            {
                model.DailyId = ExtendUtil.GuidToString();
                model.UpdateTime = DateTime.Now;
                Session.Insert(model);
            }
            else
            {
                model.UpdateTime = DateTime.Now;
                Session.Update(model);
            }
            return model;
        }

        /// <summary>
        /// 删除指定个人日记
        /// </summary>
        /// <param name="dailyId">个人日记标识</param>
        /// <returns></returns>
        public bool Delete(string dailyId)
        {
            var da = new Advert { AdvertId = dailyId };
            return Session.Delete(da) > 0;
        }

        /// <summary>
        /// 获取指定个人日记
        /// </summary>
        /// <param name="dailyId">个人日记标识</param>
        /// <returns></returns>
        public DailyInfo GetDailyInfo(string dailyId)
        {
            var da = new DailyInfo { DailyId = dailyId };
            return Session.Select(da) ? da : null;
        }

        /// <summary>
        /// 获取个人日记列表
        /// </summary>
        /// <param name="pageSize">每页显示数,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="pageIndex">当前页,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        public List<DailyInfo> GetDailyInfoList(int? pageSize, int? pageIndex, ref int totalCount)
        {
            var query = new QueryExpression();
            query.EntityType = typeof(DailyInfo);
            query.PageSize = pageSize;
            query.PageIndex = pageIndex;
            query.ReturnMatchedCount = false;
            query.Selects.Add(DailyInfo_.ALL);

            var daList = new List<DailyInfo>();
            totalCount = Session.SelectCollection(daList, query);

            return daList;
        }
    }
}
