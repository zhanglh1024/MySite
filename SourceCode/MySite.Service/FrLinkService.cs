using System;
using System.Collections.Generic;
using MySite.Core;
using MySite.Model;
using Titan;

namespace MySite.Service
{
    /// <summary>
    /// 友情链接服务
    /// </summary>
    public class FrLinkService : BaseService
    {
        /// <summary>
        /// 添加或修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public FrLink AddOrUpdate(FrLink model)
        {
            if (model.FrLinkId.IsNull())
            {
                model.FrLinkId = ExtendUtil.GuidToString();
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
        /// 删除指定友情链接
        /// </summary>
        /// <param name="frLinkId"></param>
        /// <returns></returns>
        public bool Delete(string frLinkId)
        {
            var fr = new FrLink { FrLinkId = frLinkId };
            return Session.Delete(fr) > 0;
        }
        
        /// <summary>
        /// 获取指定友情链接
        /// </summary>
        /// <param name="frLinkId"></param>
        /// <returns></returns>
        public FrLink GetFrLink(string frLinkId)
        {
            var fr = new FrLink { FrLinkId = frLinkId };
            return Session.Select(fr) ? fr : null;
        }

        /// <summary>
        /// 获取友情链接列表
        /// </summary>
        /// <param name="status">状态：-1--全部;0--启用;1--禁用</param>
        /// <param name="pageSize">每页显示数,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="pageIndex">当前页,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        public List<FrLink> GetFrLinkList(int status, int? pageSize, int? pageIndex, ref int totalCount)
        {
            var query = new QueryExpression();
            query.EntityType = typeof(FrLink);
            query.PageSize = pageSize;
            query.PageIndex = pageIndex;
            query.ReturnMatchedCount = false;
            query.Selects.Add(FrLink_.ALL);
            if (status != -1)
            {
                query.Wheres.Add(FrLink_.Status.TEqual(status));
            }
            var frList = new List<FrLink>();
            totalCount = Session.SelectCollection(frList, query);

            return frList;
        }
    }
}
