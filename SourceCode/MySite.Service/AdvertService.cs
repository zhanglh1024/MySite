using System;
using System.Collections.Generic;
using MySite.Core;
using MySite.Model;
using Titan;

namespace MySite.Service
{
    /// <summary>
    /// 广告位相关服务
    /// </summary>
    public class AdvertService : BaseService
    {
        /// <summary>
        /// 添加或修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Advert AddOrUpdate(Advert model)
        {
            if (model.AdvertId.IsNull())
            {
                model.AdvertId = ExtendUtil.GuidToString();
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
        /// 删除指定广告位
        /// </summary>
        /// <param name="advertId">广告标识</param>
        /// <returns></returns>
        public bool Delete(string advertId)
        {
            var ad = new Advert { AdvertId = advertId };
            return Session.Delete(ad) > 0;
        }

        /// <summary>
        /// 获取指定广告位
        /// </summary>
        /// <param name="advertId"></param>
        /// <returns></returns>
        public Advert GetFrLink(string advertId)
        {
            var ad = new Advert { AdvertId = advertId };
            return Session.Select(ad) ? ad : null;
        }

        /// <summary>
        /// 获取广告位列表
        /// </summary>
        /// <param name="status">状态：-1--全部;0--启用;1--禁用</param>
        /// <param name="pageSize">每页显示数,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="pageIndex">当前页,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        public List<Advert> GetFrLinkList(int status, int? pageSize, int? pageIndex, ref int totalCount)
        {
            var query = new QueryExpression();
            query.EntityType = typeof(Advert);
            query.PageSize = pageSize;
            query.PageIndex = pageIndex;
            query.ReturnMatchedCount = false;
            query.Selects.Add(Advert_.ALL);
            if (status != -1)
            {
                query.Wheres.Add(Advert_.Status.TEqual(status));
            }
            var adList = new List<Advert>();
            totalCount = Session.SelectCollection(adList, query);

            return adList;
        }
    }
}
