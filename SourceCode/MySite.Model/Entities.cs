using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using Titan;
using Titan.MySql;
using Titan.SQLite;
using Titan.SqlServer;
using Titan.Oracle;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace MySite.Model
{
    [DataContract]
    public class EntityList<T>
    {
        private List<T> _items = new List<T>();
        [DataMember]
        public long TotalCount { get; set; }
        [DataMember]
        public List<T> Items
        {
            get { return _items; }
            set { _items = value; }
        }

    }
    /*
    <system.runtime.serialization>
        <dataContractSerializer>
          <declaredTypes>

          </declaredTypes>
        </dataContractSerializer>
      </system.runtime.serialization>

    */
    #region enums

    #endregion




    #region Carousel
    /// <summary>
    /// Carousel,走马灯表
    /// </summary>
    [DataContract]
    [Table]
    public partial class Carousel
    {

        public Carousel()
        {


        }
        #region propertys

        /// <summary>
        /// 主键Id,标识,
        /// </summary>
        [DataMember]
        [DisplayName("主键Id,标识")]
        [Column(IsPrimaryKey = true, Size = 20)]
        [Required(ErrorMessage = "主键Id,标识不允许空")]
        [MaxLength(20, ErrorMessage = "主键Id,标识不能超过20个字")]

        public string CarouselId { get; set; }


        /// <summary>
        /// 名称,
        /// </summary>
        [DataMember]
        [DisplayName("名称")]
        [Column(Size = 200)]
        [MaxLength(200, ErrorMessage = "名称不能超过200个字")]

        public string CarouselName { get; set; }


        /// <summary>
        /// 类型(LINK|IMAGE|VEDIO),
        /// </summary>
        [DataMember]
        [DisplayName("类型(LINK|IMAGE|VEDIO)")]
        [Column(Size = 50)]
        [MaxLength(50, ErrorMessage = "类型(LINK|IMAGE|VEDIO)不能超过50个字")]

        public string Type { get; set; }


        /// <summary>
        /// URL地址,
        /// </summary>
        [DataMember]
        [DisplayName("URL地址")]
        [Column(Size = 500)]
        [MaxLength(500, ErrorMessage = "URL地址不能超过500个字")]

        public string Url { get; set; }


        /// <summary>
        /// 状态(0-禁用;1-启用),
        /// </summary>
        [DataMember]
        [DisplayName("状态(0-禁用;1-启用)")]
        [Column()]

        public int? Status { get; set; }


        /// <summary>
        /// 最后修改时间,
        /// </summary>
        [DataMember]
        [DisplayName("最后修改时间")]
        [Column()]

        public DateTime? UpdateTime { get; set; }


        #endregion

    }
    #endregion
    #region CarouselProperties
    public static partial class Carousel_
    {

        private static CarouselDescriptor instance = new CarouselDescriptor("");

        /// <summary>
        /// 全部字段
        /// </summary>
        public static PropertyExpression[] ALL { get { return instance.ALL; } }


        /// <summary>
        /// 主键Id,标识,
        /// </summary>
        public static PropertyExpression CarouselId { get { return instance.CarouselId; } }
        /// <summary>
        /// 名称,
        /// </summary>
        public static PropertyExpression CarouselName { get { return instance.CarouselName; } }
        /// <summary>
        /// 类型(LINK|IMAGE|VEDIO),
        /// </summary>
        public static PropertyExpression Type { get { return instance.Type; } }
        /// <summary>
        /// URL地址,
        /// </summary>
        public static PropertyExpression Url { get { return instance.Url; } }
        /// <summary>
        /// 状态(0-禁用;1-启用),
        /// </summary>
        public static PropertyExpression Status { get { return instance.Status; } }
        /// <summary>
        /// 最后修改时间,
        /// </summary>
        public static PropertyExpression UpdateTime { get { return instance.UpdateTime; } }




        public static IEnumerable<PropertyExpression> Exclude(params PropertyExpression[] properties)
        {
            return instance.Exclude(properties);
        }

    }
    #endregion
    #region CarouselDescriptor
    public partial class CarouselDescriptor : ObjectDescriptorBase
    {

        public CarouselDescriptor(string prefix) : base(prefix)
        {

            this._CarouselId = new PropertyExpression(prefix + "CarouselId");
            this._CarouselName = new PropertyExpression(prefix + "CarouselName");
            this._Type = new PropertyExpression(prefix + "Type");
            this._Url = new PropertyExpression(prefix + "Url");
            this._Status = new PropertyExpression(prefix + "Status");
            this._UpdateTime = new PropertyExpression(prefix + "UpdateTime");
            ALL = new PropertyExpression[] { this._CarouselId, this._CarouselName, this._Type, this._Url, this._Status, this._UpdateTime };
        }


        private PropertyExpression _CarouselId;
        /// <summary>
        /// 主键Id,标识,
        /// </summary>
        public PropertyExpression CarouselId { get { return _CarouselId; } }
        private PropertyExpression _CarouselName;
        /// <summary>
        /// 名称,
        /// </summary>
        public PropertyExpression CarouselName { get { return _CarouselName; } }
        private PropertyExpression _Type;
        /// <summary>
        /// 类型(LINK|IMAGE|VEDIO),
        /// </summary>
        public PropertyExpression Type { get { return _Type; } }
        private PropertyExpression _Url;
        /// <summary>
        /// URL地址,
        /// </summary>
        public PropertyExpression Url { get { return _Url; } }
        private PropertyExpression _Status;
        /// <summary>
        /// 状态(0-禁用;1-启用),
        /// </summary>
        public PropertyExpression Status { get { return _Status; } }
        private PropertyExpression _UpdateTime;
        /// <summary>
        /// 最后修改时间,
        /// </summary>
        public PropertyExpression UpdateTime { get { return _UpdateTime; } }



    }
    #endregion


    #region Carousels
    /// <summary>
    /// Carousel,走马灯表
    /// </summary>
    [DataContract]
    [Table]
    public partial class Carousels : EntityList<Carousel>
    {

    }
    #endregion


    #region Article
    /// <summary>
    /// Article,文章信息表
    /// </summary>
    [DataContract]
    [Table]
    public partial class Article
    {

        public Article()
        {


        }
        #region propertys

        /// <summary>
        /// 主键,标识,
        /// </summary>
        [DataMember]
        [DisplayName("主键,标识")]
        [Column(IsPrimaryKey = true, Size = 20)]
        [Required(ErrorMessage = "主键,标识不允许空")]
        [MaxLength(20, ErrorMessage = "主键,标识不能超过20个字")]

        public string ArticleId { get; set; }


        /// <summary>
        /// 文章描述,
        /// </summary>
        [DataMember]
        [DisplayName("文章描述")]
        [Column(Size = 100)]
        [MaxLength(100, ErrorMessage = "文章描述不能超过100个字")]

        public string ArticleDesc { get; set; }


        /// <summary>
        /// 内容,
        /// </summary>
        [DataMember]
        [DisplayName("内容")]
        [Column()]

        public string Content { get; set; }


        /// <summary>
        /// 点击量,
        /// </summary>
        [DataMember]
        [DisplayName("点击量")]
        [Column()]

        public long? ClickCount { get; set; }


        /// <summary>
        /// 是否推荐,
        /// </summary>
        [DataMember]
        [DisplayName("是否推荐")]
        [Column()]

        public int? IsCommend { get; set; }


        /// <summary>
        /// 是否热门,
        /// </summary>
        [DataMember]
        [DisplayName("是否热门")]
        [Column()]

        public int? IsHot { get; set; }


        /// <summary>
        /// 分类标识,
        /// </summary>
        [DataMember]
        [DisplayName("分类标识")]
        [Column(Size = 20)]
        [MaxLength(20, ErrorMessage = "分类标识不能超过20个字")]

        public string ArtTypeId { get; set; }


        /// <summary>
        /// 分类名称,
        /// </summary>
        [DataMember]
        [DisplayName("分类名称")]
        [Column(Size = 50)]
        [MaxLength(50, ErrorMessage = "分类名称不能超过50个字")]

        public string ArtTypeName { get; set; }


        /// <summary>
        /// 标签,
        /// </summary>
        [DataMember]
        [DisplayName("标签")]
        [Column(Size = 50)]
        [MaxLength(50, ErrorMessage = "标签不能超过50个字")]

        public string Tag { get; set; }


        /// <summary>
        /// 文章状态(0-新;1-正常;2-热门),
        /// </summary>
        [DataMember]
        [DisplayName("文章状态(0-新;1-正常;2-热门)")]
        [Column()]

        public int? Status { get; set; }


        /// <summary>
        /// 发布时间,
        /// </summary>
        [DataMember]
        [DisplayName("发布时间")]
        [Column()]

        public DateTime? PublishDate { get; set; }


        #endregion

        #region link objects

        /// <summary>
        /// Article.ArtType,
        /// </summary>
        [DataMember]
        [Relation("this.ArtTypeId=out.ArtTypeId")]
        public ArtType ArtType { get; set; }



        #endregion
    }
    #endregion
    #region ArticleProperties
    public static partial class Article_
    {

        private static ArticleDescriptor instance = new ArticleDescriptor("");

        /// <summary>
        /// 全部字段
        /// </summary>
        public static PropertyExpression[] ALL { get { return instance.ALL; } }


        /// <summary>
        /// 主键,标识,
        /// </summary>
        public static PropertyExpression ArticleId { get { return instance.ArticleId; } }
        /// <summary>
        /// 文章描述,
        /// </summary>
        public static PropertyExpression ArticleDesc { get { return instance.ArticleDesc; } }
        /// <summary>
        /// 内容,
        /// </summary>
        public static PropertyExpression Content { get { return instance.Content; } }
        /// <summary>
        /// 点击量,
        /// </summary>
        public static PropertyExpression ClickCount { get { return instance.ClickCount; } }
        /// <summary>
        /// 是否推荐,
        /// </summary>
        public static PropertyExpression IsCommend { get { return instance.IsCommend; } }
        /// <summary>
        /// 是否热门,
        /// </summary>
        public static PropertyExpression IsHot { get { return instance.IsHot; } }
        /// <summary>
        /// 分类标识,
        /// </summary>
        public static PropertyExpression ArtTypeId { get { return instance.ArtTypeId; } }
        /// <summary>
        /// 分类名称,
        /// </summary>
        public static PropertyExpression ArtTypeName { get { return instance.ArtTypeName; } }
        /// <summary>
        /// 标签,
        /// </summary>
        public static PropertyExpression Tag { get { return instance.Tag; } }
        /// <summary>
        /// 文章状态(0-新;1-正常;2-热门),
        /// </summary>
        public static PropertyExpression Status { get { return instance.Status; } }
        /// <summary>
        /// 发布时间,
        /// </summary>
        public static PropertyExpression PublishDate { get { return instance.PublishDate; } }



        /// <summary>
        /// Article.ArtType,
        /// </summary>
        public static ArtTypeDescriptor ArtType { get { return instance.ArtType; } }

        public static IEnumerable<PropertyExpression> Exclude(params PropertyExpression[] properties)
        {
            return instance.Exclude(properties);
        }

    }
    #endregion
    #region ArticleDescriptor
    public partial class ArticleDescriptor : ObjectDescriptorBase
    {

        public ArticleDescriptor(string prefix) : base(prefix)
        {

            this._ArticleId = new PropertyExpression(prefix + "ArticleId");
            this._ArticleDesc = new PropertyExpression(prefix + "ArticleDesc");
            this._Content = new PropertyExpression(prefix + "Content");
            this._ClickCount = new PropertyExpression(prefix + "ClickCount");
            this._IsCommend = new PropertyExpression(prefix + "IsCommend");
            this._IsHot = new PropertyExpression(prefix + "IsHot");
            this._ArtTypeId = new PropertyExpression(prefix + "ArtTypeId");
            this._ArtTypeName = new PropertyExpression(prefix + "ArtTypeName");
            this._Tag = new PropertyExpression(prefix + "Tag");
            this._Status = new PropertyExpression(prefix + "Status");
            this._PublishDate = new PropertyExpression(prefix + "PublishDate");
            ALL = new PropertyExpression[] { this._ArticleId, this._ArticleDesc, this._Content, this._ClickCount, this._IsCommend, this._IsHot, this._ArtTypeId, this._ArtTypeName, this._Tag, this._Status, this._PublishDate };
        }


        private PropertyExpression _ArticleId;
        /// <summary>
        /// 主键,标识,
        /// </summary>
        public PropertyExpression ArticleId { get { return _ArticleId; } }
        private PropertyExpression _ArticleDesc;
        /// <summary>
        /// 文章描述,
        /// </summary>
        public PropertyExpression ArticleDesc { get { return _ArticleDesc; } }
        private PropertyExpression _Content;
        /// <summary>
        /// 内容,
        /// </summary>
        public PropertyExpression Content { get { return _Content; } }
        private PropertyExpression _ClickCount;
        /// <summary>
        /// 点击量,
        /// </summary>
        public PropertyExpression ClickCount { get { return _ClickCount; } }
        private PropertyExpression _IsCommend;
        /// <summary>
        /// 是否推荐,
        /// </summary>
        public PropertyExpression IsCommend { get { return _IsCommend; } }
        private PropertyExpression _IsHot;
        /// <summary>
        /// 是否热门,
        /// </summary>
        public PropertyExpression IsHot { get { return _IsHot; } }
        private PropertyExpression _ArtTypeId;
        /// <summary>
        /// 分类标识,
        /// </summary>
        public PropertyExpression ArtTypeId { get { return _ArtTypeId; } }
        private PropertyExpression _ArtTypeName;
        /// <summary>
        /// 分类名称,
        /// </summary>
        public PropertyExpression ArtTypeName { get { return _ArtTypeName; } }
        private PropertyExpression _Tag;
        /// <summary>
        /// 标签,
        /// </summary>
        public PropertyExpression Tag { get { return _Tag; } }
        private PropertyExpression _Status;
        /// <summary>
        /// 文章状态(0-新;1-正常;2-热门),
        /// </summary>
        public PropertyExpression Status { get { return _Status; } }
        private PropertyExpression _PublishDate;
        /// <summary>
        /// 发布时间,
        /// </summary>
        public PropertyExpression PublishDate { get { return _PublishDate; } }



        private ArtTypeDescriptor _ArtType;
        public ArtTypeDescriptor ArtType
        {
            get
            {
                if (_ArtType == null) _ArtType = new ArtTypeDescriptor(base.Prefix + "ArtType.");
                return _ArtType;
            }
        }
    }
    #endregion


    #region Articles
    /// <summary>
    /// Article,文章信息表
    /// </summary>
    [DataContract]
    [Table]
    public partial class Articles : EntityList<Article>
    {

    }
    #endregion


    #region FrLink
    /// <summary>
    /// FrLink,友情链接
    /// </summary>
    [DataContract]
    [Table]
    public partial class FrLink
    {

        public FrLink()
        {


        }
        #region propertys

        /// <summary>
        /// 主键,标识,
        /// </summary>
        [DataMember]
        [DisplayName("主键,标识")]
        [Column(IsPrimaryKey = true, Size = 20)]
        [Required(ErrorMessage = "主键,标识不允许空")]
        [MaxLength(20, ErrorMessage = "主键,标识不能超过20个字")]

        public string FrLinkId { get; set; }


        /// <summary>
        /// 链接标题,
        /// </summary>
        [DataMember]
        [DisplayName("链接标题")]
        [Column(Size = 20)]
        [MaxLength(20, ErrorMessage = "链接标题不能超过20个字")]

        public string Title { get; set; }


        /// <summary>
        /// 备注,
        /// </summary>
        [DataMember]
        [DisplayName("备注")]
        [Column(Size = 100)]
        [MaxLength(100, ErrorMessage = "备注不能超过100个字")]

        public string ReMark { get; set; }


        /// <summary>
        /// 链接URL地址,
        /// </summary>
        [DataMember]
        [DisplayName("链接URL地址")]
        [Column(Size = 200)]
        [MaxLength(200, ErrorMessage = "链接URL地址不能超过200个字")]

        public string Url { get; set; }


        /// <summary>
        /// 排序,
        /// </summary>
        [DataMember]
        [DisplayName("排序")]
        [Column()]

        public int? Sort { get; set; }


        /// <summary>
        /// 状态,
        /// </summary>
        [DataMember]
        [DisplayName("状态")]
        [Column()]

        public int? Status { get; set; }


        /// <summary>
        /// 最后修改时间,
        /// </summary>
        [DataMember]
        [DisplayName("最后修改时间")]
        [Column()]

        public DateTime? UpdateTime { get; set; }


        #endregion

    }
    #endregion
    #region FrLinkProperties
    public static partial class FrLink_
    {

        private static FrLinkDescriptor instance = new FrLinkDescriptor("");

        /// <summary>
        /// 全部字段
        /// </summary>
        public static PropertyExpression[] ALL { get { return instance.ALL; } }


        /// <summary>
        /// 主键,标识,
        /// </summary>
        public static PropertyExpression FrLinkId { get { return instance.FrLinkId; } }
        /// <summary>
        /// 链接标题,
        /// </summary>
        public static PropertyExpression Title { get { return instance.Title; } }
        /// <summary>
        /// 备注,
        /// </summary>
        public static PropertyExpression ReMark { get { return instance.ReMark; } }
        /// <summary>
        /// 链接URL地址,
        /// </summary>
        public static PropertyExpression Url { get { return instance.Url; } }
        /// <summary>
        /// 排序,
        /// </summary>
        public static PropertyExpression Sort { get { return instance.Sort; } }
        /// <summary>
        /// 状态,
        /// </summary>
        public static PropertyExpression Status { get { return instance.Status; } }
        /// <summary>
        /// 最后修改时间,
        /// </summary>
        public static PropertyExpression UpdateTime { get { return instance.UpdateTime; } }




        public static IEnumerable<PropertyExpression> Exclude(params PropertyExpression[] properties)
        {
            return instance.Exclude(properties);
        }

    }
    #endregion
    #region FrLinkDescriptor
    public partial class FrLinkDescriptor : ObjectDescriptorBase
    {

        public FrLinkDescriptor(string prefix) : base(prefix)
        {

            this._FrLinkId = new PropertyExpression(prefix + "FrLinkId");
            this._Title = new PropertyExpression(prefix + "Title");
            this._ReMark = new PropertyExpression(prefix + "ReMark");
            this._Url = new PropertyExpression(prefix + "Url");
            this._Sort = new PropertyExpression(prefix + "Sort");
            this._Status = new PropertyExpression(prefix + "Status");
            this._UpdateTime = new PropertyExpression(prefix + "UpdateTime");
            ALL = new PropertyExpression[] { this._FrLinkId, this._Title, this._ReMark, this._Url, this._Sort, this._Status, this._UpdateTime };
        }


        private PropertyExpression _FrLinkId;
        /// <summary>
        /// 主键,标识,
        /// </summary>
        public PropertyExpression FrLinkId { get { return _FrLinkId; } }
        private PropertyExpression _Title;
        /// <summary>
        /// 链接标题,
        /// </summary>
        public PropertyExpression Title { get { return _Title; } }
        private PropertyExpression _ReMark;
        /// <summary>
        /// 备注,
        /// </summary>
        public PropertyExpression ReMark { get { return _ReMark; } }
        private PropertyExpression _Url;
        /// <summary>
        /// 链接URL地址,
        /// </summary>
        public PropertyExpression Url { get { return _Url; } }
        private PropertyExpression _Sort;
        /// <summary>
        /// 排序,
        /// </summary>
        public PropertyExpression Sort { get { return _Sort; } }
        private PropertyExpression _Status;
        /// <summary>
        /// 状态,
        /// </summary>
        public PropertyExpression Status { get { return _Status; } }
        private PropertyExpression _UpdateTime;
        /// <summary>
        /// 最后修改时间,
        /// </summary>
        public PropertyExpression UpdateTime { get { return _UpdateTime; } }



    }
    #endregion


    #region FrLinks
    /// <summary>
    /// FrLink,友情链接
    /// </summary>
    [DataContract]
    [Table]
    public partial class FrLinks : EntityList<FrLink>
    {

    }
    #endregion


    #region Advert
    /// <summary>
    /// Advert,广告表
    /// </summary>
    [DataContract]
    [Table]
    public partial class Advert
    {

        public Advert()
        {


        }
        #region propertys

        /// <summary>
        /// 主键,标识,
        /// </summary>
        [DataMember]
        [DisplayName("主键,标识")]
        [Column(IsPrimaryKey = true, Size = 20)]
        [Required(ErrorMessage = "主键,标识不允许空")]
        [MaxLength(20, ErrorMessage = "主键,标识不能超过20个字")]

        public string AdvertId { get; set; }


        /// <summary>
        /// 标题,
        /// </summary>
        [DataMember]
        [DisplayName("标题")]
        [Column(Size = 200)]
        [MaxLength(200, ErrorMessage = "标题不能超过200个字")]

        public string Title { get; set; }


        /// <summary>
        /// 描述,
        /// </summary>
        [DataMember]
        [DisplayName("描述")]
        [Column(Size = 500)]
        [MaxLength(500, ErrorMessage = "描述不能超过500个字")]

        public string ReMark { get; set; }


        /// <summary>
        /// 图片地址,
        /// </summary>
        [DataMember]
        [DisplayName("图片地址")]
        [Column(Size = 500)]
        [MaxLength(500, ErrorMessage = "图片地址不能超过500个字")]

        public string Image { get; set; }


        /// <summary>
        /// URL地址,
        /// </summary>
        [DataMember]
        [DisplayName("URL地址")]
        [Column(Size = 500)]
        [MaxLength(500, ErrorMessage = "URL地址不能超过500个字")]

        public string Url { get; set; }


        /// <summary>
        /// 状态,
        /// </summary>
        [DataMember]
        [DisplayName("状态")]
        [Column()]

        public int? Status { get; set; }


        /// <summary>
        /// 最后更新时间,
        /// </summary>
        [DataMember]
        [DisplayName("最后更新时间")]
        [Column()]

        public DateTime? UpdateTime { get; set; }


        #endregion

    }
    #endregion
    #region AdvertProperties
    public static partial class Advert_
    {

        private static AdvertDescriptor instance = new AdvertDescriptor("");

        /// <summary>
        /// 全部字段
        /// </summary>
        public static PropertyExpression[] ALL { get { return instance.ALL; } }


        /// <summary>
        /// 主键,标识,
        /// </summary>
        public static PropertyExpression AdvertId { get { return instance.AdvertId; } }
        /// <summary>
        /// 标题,
        /// </summary>
        public static PropertyExpression Title { get { return instance.Title; } }
        /// <summary>
        /// 描述,
        /// </summary>
        public static PropertyExpression ReMark { get { return instance.ReMark; } }
        /// <summary>
        /// 图片地址,
        /// </summary>
        public static PropertyExpression Image { get { return instance.Image; } }
        /// <summary>
        /// URL地址,
        /// </summary>
        public static PropertyExpression Url { get { return instance.Url; } }
        /// <summary>
        /// 状态,
        /// </summary>
        public static PropertyExpression Status { get { return instance.Status; } }
        /// <summary>
        /// 最后更新时间,
        /// </summary>
        public static PropertyExpression UpdateTime { get { return instance.UpdateTime; } }




        public static IEnumerable<PropertyExpression> Exclude(params PropertyExpression[] properties)
        {
            return instance.Exclude(properties);
        }

    }
    #endregion
    #region AdvertDescriptor
    public partial class AdvertDescriptor : ObjectDescriptorBase
    {

        public AdvertDescriptor(string prefix) : base(prefix)
        {

            this._AdvertId = new PropertyExpression(prefix + "AdvertId");
            this._Title = new PropertyExpression(prefix + "Title");
            this._ReMark = new PropertyExpression(prefix + "ReMark");
            this._Image = new PropertyExpression(prefix + "Image");
            this._Url = new PropertyExpression(prefix + "Url");
            this._Status = new PropertyExpression(prefix + "Status");
            this._UpdateTime = new PropertyExpression(prefix + "UpdateTime");
            ALL = new PropertyExpression[] { this._AdvertId, this._Title, this._ReMark, this._Image, this._Url, this._Status, this._UpdateTime };
        }


        private PropertyExpression _AdvertId;
        /// <summary>
        /// 主键,标识,
        /// </summary>
        public PropertyExpression AdvertId { get { return _AdvertId; } }
        private PropertyExpression _Title;
        /// <summary>
        /// 标题,
        /// </summary>
        public PropertyExpression Title { get { return _Title; } }
        private PropertyExpression _ReMark;
        /// <summary>
        /// 描述,
        /// </summary>
        public PropertyExpression ReMark { get { return _ReMark; } }
        private PropertyExpression _Image;
        /// <summary>
        /// 图片地址,
        /// </summary>
        public PropertyExpression Image { get { return _Image; } }
        private PropertyExpression _Url;
        /// <summary>
        /// URL地址,
        /// </summary>
        public PropertyExpression Url { get { return _Url; } }
        private PropertyExpression _Status;
        /// <summary>
        /// 状态,
        /// </summary>
        public PropertyExpression Status { get { return _Status; } }
        private PropertyExpression _UpdateTime;
        /// <summary>
        /// 最后更新时间,
        /// </summary>
        public PropertyExpression UpdateTime { get { return _UpdateTime; } }



    }
    #endregion


    #region Adverts
    /// <summary>
    /// Advert,广告表
    /// </summary>
    [DataContract]
    [Table]
    public partial class Adverts : EntityList<Advert>
    {

    }
    #endregion


    #region ArtType
    /// <summary>
    /// ArtType,分类信息表
    /// </summary>
    [DataContract]
    [Table]
    public partial class ArtType
    {

        public ArtType()
        {


        }
        #region propertys

        /// <summary>
        /// 主键,标识,
        /// </summary>
        [DataMember]
        [DisplayName("主键,标识")]
        [Column(IsPrimaryKey = true, Size = 20)]
        [Required(ErrorMessage = "主键,标识不允许空")]
        [MaxLength(20, ErrorMessage = "主键,标识不能超过20个字")]

        public string ArtTypeId { get; set; }


        /// <summary>
        /// 分类名称,
        /// </summary>
        [DataMember]
        [DisplayName("分类名称")]
        [Column(Size = 50)]
        [MaxLength(50, ErrorMessage = "分类名称不能超过50个字")]

        public string ArtTypeName { get; set; }


        /// <summary>
        /// 父级节点(一级为*),
        /// </summary>
        [DataMember]
        [DisplayName("父级节点(一级为*)")]
        [Column(Size = 20)]
        [MaxLength(20, ErrorMessage = "父级节点(一级为*)不能超过20个字")]

        public string ParentId { get; set; }


        /// <summary>
        /// 父级名称,
        /// </summary>
        [DataMember]
        [DisplayName("父级名称")]
        [Column(Size = 50)]
        [MaxLength(50, ErrorMessage = "父级名称不能超过50个字")]

        public string ParentName { get; set; }


        /// <summary>
        /// 状态,
        /// </summary>
        [DataMember]
        [DisplayName("状态")]
        [Column()]

        public int? Status { get; set; }


        /// <summary>
        /// 最后修改时间,
        /// </summary>
        [DataMember]
        [DisplayName("最后修改时间")]
        [Column()]

        public DateTime? UpdateTime { get; set; }


        #endregion

    }
    #endregion
    #region ArtTypeProperties
    public static partial class ArtType_
    {

        private static ArtTypeDescriptor instance = new ArtTypeDescriptor("");

        /// <summary>
        /// 全部字段
        /// </summary>
        public static PropertyExpression[] ALL { get { return instance.ALL; } }


        /// <summary>
        /// 主键,标识,
        /// </summary>
        public static PropertyExpression ArtTypeId { get { return instance.ArtTypeId; } }
        /// <summary>
        /// 分类名称,
        /// </summary>
        public static PropertyExpression ArtTypeName { get { return instance.ArtTypeName; } }
        /// <summary>
        /// 父级节点(一级为*),
        /// </summary>
        public static PropertyExpression ParentId { get { return instance.ParentId; } }
        /// <summary>
        /// 父级名称,
        /// </summary>
        public static PropertyExpression ParentName { get { return instance.ParentName; } }
        /// <summary>
        /// 状态,
        /// </summary>
        public static PropertyExpression Status { get { return instance.Status; } }
        /// <summary>
        /// 最后修改时间,
        /// </summary>
        public static PropertyExpression UpdateTime { get { return instance.UpdateTime; } }




        public static IEnumerable<PropertyExpression> Exclude(params PropertyExpression[] properties)
        {
            return instance.Exclude(properties);
        }

    }
    #endregion
    #region ArtTypeDescriptor
    public partial class ArtTypeDescriptor : ObjectDescriptorBase
    {

        public ArtTypeDescriptor(string prefix) : base(prefix)
        {

            this._ArtTypeId = new PropertyExpression(prefix + "ArtTypeId");
            this._ArtTypeName = new PropertyExpression(prefix + "ArtTypeName");
            this._ParentId = new PropertyExpression(prefix + "ParentId");
            this._ParentName = new PropertyExpression(prefix + "ParentName");
            this._Status = new PropertyExpression(prefix + "Status");
            this._UpdateTime = new PropertyExpression(prefix + "UpdateTime");
            ALL = new PropertyExpression[] { this._ArtTypeId, this._ArtTypeName, this._ParentId, this._ParentName, this._Status, this._UpdateTime };
        }


        private PropertyExpression _ArtTypeId;
        /// <summary>
        /// 主键,标识,
        /// </summary>
        public PropertyExpression ArtTypeId { get { return _ArtTypeId; } }
        private PropertyExpression _ArtTypeName;
        /// <summary>
        /// 分类名称,
        /// </summary>
        public PropertyExpression ArtTypeName { get { return _ArtTypeName; } }
        private PropertyExpression _ParentId;
        /// <summary>
        /// 父级节点(一级为*),
        /// </summary>
        public PropertyExpression ParentId { get { return _ParentId; } }
        private PropertyExpression _ParentName;
        /// <summary>
        /// 父级名称,
        /// </summary>
        public PropertyExpression ParentName { get { return _ParentName; } }
        private PropertyExpression _Status;
        /// <summary>
        /// 状态,
        /// </summary>
        public PropertyExpression Status { get { return _Status; } }
        private PropertyExpression _UpdateTime;
        /// <summary>
        /// 最后修改时间,
        /// </summary>
        public PropertyExpression UpdateTime { get { return _UpdateTime; } }



    }
    #endregion


    #region ArtTypes
    /// <summary>
    /// ArtType,分类信息表
    /// </summary>
    [DataContract]
    [Table]
    public partial class ArtTypes : EntityList<ArtType>
    {

    }
    #endregion


    #region Comment
    /// <summary>
    /// Comment,评论信息表
    /// </summary>
    [DataContract]
    [Table]
    public partial class Comment
    {

        public Comment()
        {


        }
        #region propertys

        /// <summary>
        /// 主键,标识,
        /// </summary>
        [DataMember]
        [DisplayName("主键,标识")]
        [Column(IsPrimaryKey = true, Size = 20)]
        [Required(ErrorMessage = "主键,标识不允许空")]
        [MaxLength(20, ErrorMessage = "主键,标识不能超过20个字")]

        public string CommentId { get; set; }


        /// <summary>
        /// 用户标识,
        /// </summary>
        [DataMember]
        [DisplayName("用户标识")]
        [Column(Size = 20)]
        [MaxLength(20, ErrorMessage = "用户标识不能超过20个字")]

        public string UserId { get; set; }


        /// <summary>
        /// 文章标识,
        /// </summary>
        [DataMember]
        [DisplayName("文章标识")]
        [Column(Size = 20)]
        [MaxLength(20, ErrorMessage = "文章标识不能超过20个字")]

        public string ArticleId { get; set; }


        /// <summary>
        /// 评论内容,
        /// </summary>
        [DataMember]
        [DisplayName("评论内容")]
        [Column()]

        public string Content { get; set; }


        /// <summary>
        /// 点亮数,
        /// </summary>
        [DataMember]
        [DisplayName("点亮数")]
        [Column()]

        public int? LightCount { get; set; }


        /// <summary>
        /// 父级评论标识,
        /// </summary>
        [DataMember]
        [DisplayName("父级评论标识")]
        [Column(Size = 20)]
        [MaxLength(20, ErrorMessage = "父级评论标识不能超过20个字")]

        public string ParentId { get; set; }


        /// <summary>
        /// 最后修改时间,
        /// </summary>
        [DataMember]
        [DisplayName("最后修改时间")]
        [Column()]

        public DateTime? UpdateTime { get; set; }


        #endregion

        #region link objects

        /// <summary>
        /// Commrnt.Article,
        /// </summary>
        [DataMember]
        [Relation("this.ArticleId=out.ArticleId")]
        public Article Article { get; set; }



        #endregion
    }
    #endregion
    #region CommentProperties
    public static partial class Comment_
    {

        private static CommentDescriptor instance = new CommentDescriptor("");

        /// <summary>
        /// 全部字段
        /// </summary>
        public static PropertyExpression[] ALL { get { return instance.ALL; } }


        /// <summary>
        /// 主键,标识,
        /// </summary>
        public static PropertyExpression CommentId { get { return instance.CommentId; } }
        /// <summary>
        /// 用户标识,
        /// </summary>
        public static PropertyExpression UserId { get { return instance.UserId; } }
        /// <summary>
        /// 文章标识,
        /// </summary>
        public static PropertyExpression ArticleId { get { return instance.ArticleId; } }
        /// <summary>
        /// 评论内容,
        /// </summary>
        public static PropertyExpression Content { get { return instance.Content; } }
        /// <summary>
        /// 点亮数,
        /// </summary>
        public static PropertyExpression LightCount { get { return instance.LightCount; } }
        /// <summary>
        /// 父级评论标识,
        /// </summary>
        public static PropertyExpression ParentId { get { return instance.ParentId; } }
        /// <summary>
        /// 最后修改时间,
        /// </summary>
        public static PropertyExpression UpdateTime { get { return instance.UpdateTime; } }



        /// <summary>
        /// Commrnt.Article,
        /// </summary>
        public static ArticleDescriptor Article { get { return instance.Article; } }

        public static IEnumerable<PropertyExpression> Exclude(params PropertyExpression[] properties)
        {
            return instance.Exclude(properties);
        }

    }
    #endregion
    #region CommentDescriptor
    public partial class CommentDescriptor : ObjectDescriptorBase
    {

        public CommentDescriptor(string prefix) : base(prefix)
        {

            this._CommentId = new PropertyExpression(prefix + "CommentId");
            this._UserId = new PropertyExpression(prefix + "UserId");
            this._ArticleId = new PropertyExpression(prefix + "ArticleId");
            this._Content = new PropertyExpression(prefix + "Content");
            this._LightCount = new PropertyExpression(prefix + "LightCount");
            this._ParentId = new PropertyExpression(prefix + "ParentId");
            this._UpdateTime = new PropertyExpression(prefix + "UpdateTime");
            ALL = new PropertyExpression[] { this._CommentId, this._UserId, this._ArticleId, this._Content, this._LightCount, this._ParentId, this._UpdateTime };
        }


        private PropertyExpression _CommentId;
        /// <summary>
        /// 主键,标识,
        /// </summary>
        public PropertyExpression CommentId { get { return _CommentId; } }
        private PropertyExpression _UserId;
        /// <summary>
        /// 用户标识,
        /// </summary>
        public PropertyExpression UserId { get { return _UserId; } }
        private PropertyExpression _ArticleId;
        /// <summary>
        /// 文章标识,
        /// </summary>
        public PropertyExpression ArticleId { get { return _ArticleId; } }
        private PropertyExpression _Content;
        /// <summary>
        /// 评论内容,
        /// </summary>
        public PropertyExpression Content { get { return _Content; } }
        private PropertyExpression _LightCount;
        /// <summary>
        /// 点亮数,
        /// </summary>
        public PropertyExpression LightCount { get { return _LightCount; } }
        private PropertyExpression _ParentId;
        /// <summary>
        /// 父级评论标识,
        /// </summary>
        public PropertyExpression ParentId { get { return _ParentId; } }
        private PropertyExpression _UpdateTime;
        /// <summary>
        /// 最后修改时间,
        /// </summary>
        public PropertyExpression UpdateTime { get { return _UpdateTime; } }



        private ArticleDescriptor _Article;
        public ArticleDescriptor Article
        {
            get
            {
                if (_Article == null) _Article = new ArticleDescriptor(base.Prefix + "Article.");
                return _Article;
            }
        }
    }
    #endregion


    #region Comments
    /// <summary>
    /// Comment,评论信息表
    /// </summary>
    [DataContract]
    [Table]
    public partial class Comments : EntityList<Comment>
    {

    }
    #endregion


    #region DailyInfo
    /// <summary>
    /// DailyInfo,个人日记表
    /// </summary>
    [DataContract]
    [Table]
    public partial class DailyInfo
    {

        public DailyInfo()
        {


        }
        #region propertys

        /// <summary>
        /// 主键,标识,
        /// </summary>
        [DataMember]
        [DisplayName("主键,标识")]
        [Column(IsPrimaryKey = true, Size = 20)]
        [Required(ErrorMessage = "主键,标识不允许空")]
        [MaxLength(20, ErrorMessage = "主键,标识不能超过20个字")]

        public string DailyId { get; set; }


        /// <summary>
        /// 内容,
        /// </summary>
        [DataMember]
        [DisplayName("内容")]
        [Column()]

        public string Content { get; set; }


        /// <summary>
        /// 修改时间,
        /// </summary>
        [DataMember]
        [DisplayName("修改时间")]
        [Column()]

        public DateTime? UpdateTime { get; set; }


        #endregion

    }
    #endregion
    #region DailyInfoProperties
    public static partial class DailyInfo_
    {

        private static DailyInfoDescriptor instance = new DailyInfoDescriptor("");

        /// <summary>
        /// 全部字段
        /// </summary>
        public static PropertyExpression[] ALL { get { return instance.ALL; } }


        /// <summary>
        /// 主键,标识,
        /// </summary>
        public static PropertyExpression DailyId { get { return instance.DailyId; } }
        /// <summary>
        /// 内容,
        /// </summary>
        public static PropertyExpression Content { get { return instance.Content; } }
        /// <summary>
        /// 修改时间,
        /// </summary>
        public static PropertyExpression UpdateTime { get { return instance.UpdateTime; } }




        public static IEnumerable<PropertyExpression> Exclude(params PropertyExpression[] properties)
        {
            return instance.Exclude(properties);
        }

    }
    #endregion
    #region DailyInfoDescriptor
    public partial class DailyInfoDescriptor : ObjectDescriptorBase
    {

        public DailyInfoDescriptor(string prefix) : base(prefix)
        {

            this._DailyId = new PropertyExpression(prefix + "DailyId");
            this._Content = new PropertyExpression(prefix + "Content");
            this._UpdateTime = new PropertyExpression(prefix + "UpdateTime");
            ALL = new PropertyExpression[] { this._DailyId, this._Content, this._UpdateTime };
        }


        private PropertyExpression _DailyId;
        /// <summary>
        /// 主键,标识,
        /// </summary>
        public PropertyExpression DailyId { get { return _DailyId; } }
        private PropertyExpression _Content;
        /// <summary>
        /// 内容,
        /// </summary>
        public PropertyExpression Content { get { return _Content; } }
        private PropertyExpression _UpdateTime;
        /// <summary>
        /// 修改时间,
        /// </summary>
        public PropertyExpression UpdateTime { get { return _UpdateTime; } }



    }
    #endregion


    #region DailyInfos
    /// <summary>
    /// DailyInfo,个人日记表
    /// </summary>
    [DataContract]
    [Table]
    public partial class DailyInfos : EntityList<DailyInfo>
    {

    }
    #endregion
}
