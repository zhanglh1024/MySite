using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Model
{
    public class PageList<T>
    {
        /// <summary>
        /// 数据集
        /// </summary>
        public List<T> Records { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        public int TotalRecords { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPage { get; set; }

        public void SetList(List<T> query, int pageSize, int pageIndex)
        {
            this.TotalRecords = query.Count();
            this.TotalPage = TotalRecords / pageSize + (TotalRecords % pageSize == 0 ? 0 : 1);
            this.Records = query.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
        }

    }

    public class PageFilter
    {
        private int _pageIndex = 1;
        private int _pageSize = 10;

        public int pageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value > 0 ? value : _pageSize;
            }
        }
        public int pageIndex
        {
            get
            {
                return _pageIndex;
            }
            set
            {
                _pageIndex = value > 0 ? value : _pageIndex;
            }
        }
    }

    public class ResList<T>
    {
        /// <summary>
        /// 数据集
        /// </summary>
        public List<T> Records { get; set; }
    }
}
