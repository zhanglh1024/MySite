/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2017/6/5 星期一 13:29:05                        */
/*==============================================================*/


drop table if exists Advert;

drop table if exists ArtType;

drop table if exists Article;

drop table if exists Carousel;

drop table if exists Comment;

drop table if exists DailyInfo;

drop table if exists FrLink;

/*==============================================================*/
/* Table: Advert                                                */
/*==============================================================*/
create table Advert
(
   AdvertId             varchar(20) not null comment '主键,标识',
   Title                varchar(200) not null comment '标题',
   ReMark               varchar(500) not null comment '描述',
   Image                varchar(500) not null comment '图片地址',
   Url                  varchar(500) not null comment 'URL地址',
   Status               int not null comment '状态',
   UpdateTime           datetime not null comment '最后更新时间',
   primary key (AdvertId)
);

alter table Advert comment '广告表';

/*==============================================================*/
/* Table: ArtType                                               */
/*==============================================================*/
create table ArtType
(
   ArtTypeId            varchar(20) not null comment '主键,标识',
   ArtTypeName          varchar(50) not null comment '分类名称',
   ParentId             varchar(20) not null comment '父级节点(一级为*)',
   ParentName           varchar(50) not null comment '父级名称',
   Status               int not null comment '状态',
   UpdateTime           datetime not null comment '最后修改时间',
   primary key (ArtTypeId)
);

alter table ArtType comment '分类信息表';

/*==============================================================*/
/* Table: Article                                               */
/*==============================================================*/
create table Article
(
   ArticleId            varchar(20) not null comment '主键,标识',
   ArticleDesc          varchar(100) not null comment '文章描述',
   Content              text not null comment '内容',
   ClickCount           bigint not null comment '点击量',
   IsCommend            int not null comment '是否推荐',
   IsHot                int not null comment '是否热门',
   ArtTypeId            varchar(20) not null comment '分类标识',
   ArtTypeName          varchar(50) not null comment '分类名称',
   Tag                  varchar(50) not null comment '标签',
   Status               int not null comment '文章状态(0-新;1-正常;2-热门)',
   PublishDate          datetime not null comment '发布时间',
   primary key (ArticleId)
);

alter table Article comment '文章信息表';

/*==============================================================*/
/* Table: Carousel                                              */
/*==============================================================*/
create table Carousel
(
   CarouselId           varchar(20) not null comment '主键Id,标识',
   CarouselName         varchar(200) not null comment '名称',
   Type                 varchar(50) not null comment '类型(LINK|IMAGE|VEDIO)',
   Url                  varchar(500) not null comment 'URL地址',
   Status               int not null comment '状态(0-禁用;1-启用)',
   UpdateTime           datetime not null comment '最后修改时间',
   primary key (CarouselId)
);

alter table Carousel comment '走马灯表';

/*==============================================================*/
/* Table: Comment                                               */
/*==============================================================*/
create table Comment
(
   CommentId            varchar(20) not null comment '主键,标识',
   UserId               varchar(20) not null comment '用户标识',
   ArticleId            varchar(20) not null comment '文章标识',
   Content              text not null comment '评论内容',
   LightCount           int not null comment '点亮数',
   ParentId             varchar(20) not null comment '父级评论标识',
   UpdateTime           datetime not null comment '最后修改时间',
   primary key (CommentId)
);

alter table Comment comment '评论信息表';

/*==============================================================*/
/* Table: DailyInfo                                             */
/*==============================================================*/
create table DailyInfo
(
   DailyId              varchar(20) not null comment '主键,标识',
   Content              text not null comment '内容',
   UpdateTime           datetime not null comment '修改时间',
   primary key (DailyId)
);

alter table DailyInfo comment '个人日记表';

/*==============================================================*/
/* Table: FrLink                                                */
/*==============================================================*/
create table FrLink
(
   FrLinkId             varchar(20) not null comment '主键,标识',
   Title                varchar(20) not null comment '链接标题',
   ReMark               varchar(100) not null comment '备注',
   Url                  varchar(200) not null comment '链接URL地址',
   Sort                 int not null comment '排序',
   Status               int not null comment '状态',
   UpdateTime           datetime not null comment '最后修改时间',
   primary key (FrLinkId)
);

alter table FrLink comment '友情链接';

alter table Article add constraint `FK_Article.ArtType` foreign key (ArtTypeId)
      references ArtType (ArtTypeId) on delete restrict on update restrict;

alter table Comment add constraint `FK_Commrnt.Article` foreign key (ArticleId)
      references Article (ArticleId) on delete restrict on update restrict;

