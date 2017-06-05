/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2017/6/5 ����һ 13:29:05                        */
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
   AdvertId             varchar(20) not null comment '����,��ʶ',
   Title                varchar(200) not null comment '����',
   ReMark               varchar(500) not null comment '����',
   Image                varchar(500) not null comment 'ͼƬ��ַ',
   Url                  varchar(500) not null comment 'URL��ַ',
   Status               int not null comment '״̬',
   UpdateTime           datetime not null comment '������ʱ��',
   primary key (AdvertId)
);

alter table Advert comment '����';

/*==============================================================*/
/* Table: ArtType                                               */
/*==============================================================*/
create table ArtType
(
   ArtTypeId            varchar(20) not null comment '����,��ʶ',
   ArtTypeName          varchar(50) not null comment '��������',
   ParentId             varchar(20) not null comment '�����ڵ�(һ��Ϊ*)',
   ParentName           varchar(50) not null comment '��������',
   Status               int not null comment '״̬',
   UpdateTime           datetime not null comment '����޸�ʱ��',
   primary key (ArtTypeId)
);

alter table ArtType comment '������Ϣ��';

/*==============================================================*/
/* Table: Article                                               */
/*==============================================================*/
create table Article
(
   ArticleId            varchar(20) not null comment '����,��ʶ',
   ArticleDesc          varchar(100) not null comment '��������',
   Content              text not null comment '����',
   ClickCount           bigint not null comment '�����',
   IsCommend            int not null comment '�Ƿ��Ƽ�',
   IsHot                int not null comment '�Ƿ�����',
   ArtTypeId            varchar(20) not null comment '�����ʶ',
   ArtTypeName          varchar(50) not null comment '��������',
   Tag                  varchar(50) not null comment '��ǩ',
   Status               int not null comment '����״̬(0-��;1-����;2-����)',
   PublishDate          datetime not null comment '����ʱ��',
   primary key (ArticleId)
);

alter table Article comment '������Ϣ��';

/*==============================================================*/
/* Table: Carousel                                              */
/*==============================================================*/
create table Carousel
(
   CarouselId           varchar(20) not null comment '����Id,��ʶ',
   CarouselName         varchar(200) not null comment '����',
   Type                 varchar(50) not null comment '����(LINK|IMAGE|VEDIO)',
   Url                  varchar(500) not null comment 'URL��ַ',
   Status               int not null comment '״̬(0-����;1-����)',
   UpdateTime           datetime not null comment '����޸�ʱ��',
   primary key (CarouselId)
);

alter table Carousel comment '����Ʊ�';

/*==============================================================*/
/* Table: Comment                                               */
/*==============================================================*/
create table Comment
(
   CommentId            varchar(20) not null comment '����,��ʶ',
   UserId               varchar(20) not null comment '�û���ʶ',
   ArticleId            varchar(20) not null comment '���±�ʶ',
   Content              text not null comment '��������',
   LightCount           int not null comment '������',
   ParentId             varchar(20) not null comment '�������۱�ʶ',
   UpdateTime           datetime not null comment '����޸�ʱ��',
   primary key (CommentId)
);

alter table Comment comment '������Ϣ��';

/*==============================================================*/
/* Table: DailyInfo                                             */
/*==============================================================*/
create table DailyInfo
(
   DailyId              varchar(20) not null comment '����,��ʶ',
   Content              text not null comment '����',
   UpdateTime           datetime not null comment '�޸�ʱ��',
   primary key (DailyId)
);

alter table DailyInfo comment '�����ռǱ�';

/*==============================================================*/
/* Table: FrLink                                                */
/*==============================================================*/
create table FrLink
(
   FrLinkId             varchar(20) not null comment '����,��ʶ',
   Title                varchar(20) not null comment '���ӱ���',
   ReMark               varchar(100) not null comment '��ע',
   Url                  varchar(200) not null comment '����URL��ַ',
   Sort                 int not null comment '����',
   Status               int not null comment '״̬',
   UpdateTime           datetime not null comment '����޸�ʱ��',
   primary key (FrLinkId)
);

alter table FrLink comment '��������';

alter table Article add constraint `FK_Article.ArtType` foreign key (ArtTypeId)
      references ArtType (ArtTypeId) on delete restrict on update restrict;

alter table Comment add constraint `FK_Commrnt.Article` foreign key (ArticleId)
      references Article (ArticleId) on delete restrict on update restrict;

