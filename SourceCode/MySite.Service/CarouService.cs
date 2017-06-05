using System;
using System.Collections.Generic;
using MySite.Core;
using MySite.Model;
using Titan;

namespace MySite.Service
{
    /// <summary>
    /// 走马灯服务
    /// </summary>
    public class CarouService : BaseService
    {
        /// <summary>
        /// 添加或修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Carousel AddOrUpdate(Carousel model)
        {
            if (model.CarouselId.IsNull())
            {
                model.CarouselId = ExtendUtil.GuidToString();
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
        /// 删除指定走马灯
        /// </summary>
        /// <param name="carouselId">走马灯标识</param>
        /// <returns></returns>
        public bool Delete(string carouselId)
        {
            var ca = new Carousel { CarouselId = carouselId };
            return Session.Delete(ca) > 0;
        }

        /// <summary>
        /// 获取指定走马灯
        /// </summary>
        /// <param name="carouselId">走马灯标识</param>
        /// <returns></returns>
        public Carousel GetFrLink(string carouselId)
        {
            var ca = new Carousel { CarouselId = carouselId };
            return Session.Select(ca) ? ca : null;
        }

        /// <summary>
        /// 获取走马灯列表
        /// </summary>
        /// <param name="type">类型：LINK|IMAGE|VEDIO</param>
        /// <param name="status">状态：-1--全部;0--启用;1--禁用</param>
        /// <param name="pageSize">每页显示数,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="pageIndex">当前页,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        public List<Carousel> GetFrLinkList(string type, int status, int? pageSize, int? pageIndex, ref int totalCount)
        {
            var query = new QueryExpression();
            query.EntityType = typeof(Carousel);
            query.PageSize = pageSize;
            query.PageIndex = pageIndex;
            query.ReturnMatchedCount = false;
            query.Selects.Add(Carousel_.ALL);
            if (type != "*")
            {
                query.Wheres.Add(Carousel_.Type.TEqual(type));
            }
            if (status != -1)
            {
                query.Wheres.Add(Carousel_.Status.TEqual(status));
            }
            var adList = new List<Carousel>();
            totalCount = Session.SelectCollection(adList, query);

            return adList;
        }
    }
}
