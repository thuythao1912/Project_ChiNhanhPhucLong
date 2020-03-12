/*==============================================================*/
/* DBMS name:      Sybase SQL Anywhere 12                       */
/* Created on:     20/11/2019 2:06:02 PM                        */
/*==============================================================*/
create database CHINHANHPHUCLONG
use CHINHANHPHUCLONG
/*==============================================================*/
/* Table: CHINHANH                                              */
/*==============================================================*/
create table CHINHANH 
(
   CN_ID                nvarchar(100)                        not null,
   TT_ID                nvarchar(100)                         not null,
   CN_TEN               nvarchar(100)                   null,
   CN_SDT               nvarchar(11)                    null,
   CN_DIACHI            nvarchar(100)                   null,
   TK_ID int not null
   constraint PK_CHINHANH primary key (CN_ID)
);

/*==============================================================*/
/* Index: CHINHANH_PK                                           */
/*==============================================================*/
create unique index CHINHANH_PK on CHINHANH (
CN_ID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_2_FK on CHINHANH (
TT_ID ASC
);

/*==============================================================*/
/* Table: DANHGIA                                               */
/*==============================================================*/
create table DANHGIA 
(
   DG_ID                integer    identity(1,1)                    not null,
   CN_ID                nvarchar(100)                        not null,
   DG_NOIDUNG           nvarchar(255)                   null,
   constraint PK_DANHGIA primary key (DG_ID)
);

/*==============================================================*/
/* Index: DANHGIA_PK                                            */
/*==============================================================*/
create unique index DANHGIA_PK on DANHGIA (
DG_ID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_5_FK on DANHGIA (
CN_ID ASC
);

/*==============================================================*/
/* Table: HINHANH                                               */
/*==============================================================*/
create table HINHANH 
(
   HINH_ID              integer         identity(1,1)                  not null,
   CN_ID                nvarchar(100)                        not null,
   HINH_LINK            nvarchar(255)                   null,
   HINH_BYTE			varbinary(MAX)
   constraint PK_HINHANH primary key (HINH_ID)
);

/*==============================================================*/
/* Index: HINHANH_PK                                            */
/*==============================================================*/
create unique index HINHANH_PK on HINHANH (
HINH_ID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_3_FK on HINHANH (
CN_ID ASC
);

/*==============================================================*/
/* Table: TAIKHOAN                                              */
/*==============================================================*/
create table TAIKHOAN 
(
   TK_ID                integer          identity(1,1)                 not null,
   TK_HOTEN             nvarchar(255)                   null,
   TK_EMAIL             nvarchar(255)                   null,
   TK_SDT               nvarchar(255)                   null,
   TK_PASSWORD          nvarchar(255)                   null,
   TK_DIACHI            nvarchar(255)                   null,
   constraint PK_TAIKHOAN primary key (TK_ID)
);

/*==============================================================*/
/* Index: TAIKHOAN_PK                                           */
/*==============================================================*/
create unique index TAIKHOAN_PK on TAIKHOAN (
TK_ID ASC
);

/*==============================================================*/
/* Table: THUCUONG                                              */
/*==============================================================*/
create table THUCUONG 
(
   THUCUONG_ID          integer         identity(1,1)                  not null,
   TK_ID                integer                        not null,
   THUCUONG_TEN         nvarchar(255)                   null,
   THUCUONG_GIA         float                          null,
   constraint PK_THUCUONG primary key (THUCUONG_ID)
);

/*==============================================================*/
/* Index: THUCUONG_PK                                           */
/*==============================================================*/
create unique index THUCUONG_PK on THUCUONG (
THUCUONG_ID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_7_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_7_FK on THUCUONG (
TK_ID ASC
);

/*==============================================================*/
/* Table: TINHTHANH                                             */
/*==============================================================*/
create table TINHTHANH 
(
   TT_ID                nvarchar(100)                        not null,
   VUNG_ID              nvarchar(100)                         not null,
   TT_TEN               nvarchar(100)                   null,
   constraint PK_TINHTHANH primary key (TT_ID)
);

/*==============================================================*/
/* Index: TINHTHANH_PK                                          */
/*==============================================================*/
create unique index TINHTHANH_PK on TINHTHANH (
TT_ID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_4_FK on TINHTHANH (
VUNG_ID ASC
);

/*==============================================================*/
/* Table: VUNG                                                  */
/*==============================================================*/
create table VUNG 
(
   VUNG_ID              nvarchar(100)             not null,
   VUNG_TEN             nvarchar(255)                   null,
   constraint PK_VUNG primary key (VUNG_ID)
);

/*==============================================================*/
/* Index: VUNG_PK                                               */
/*==============================================================*/
create unique index VUNG_PK on VUNG (
VUNG_ID ASC
);

alter table CHINHANH
   add constraint FK_CHINHANH_RELATIONS_TINHTHAN foreign key (TT_ID)
      references TINHTHANH (TT_ID)


alter table CHINHANH
   add constraint FK_CHINHANH_RELATIONS_TAIKHOAN foreign key (TK_ID)
      references TAIKHOAN (TK_ID)


alter table DANHGIA
   add constraint FK_DANHGIA_RELATIONS_CHINHANH foreign key (CN_ID)
      references CHINHANH (CN_ID)


alter table HINHANH
   add constraint FK_HINHANH_RELATIONS_CHINHANH foreign key (CN_ID)
      references CHINHANH (CN_ID)


alter table THUCUONG
   add constraint FK_THUCUONG_RELATIONS_TAIKHOAN foreign key (TK_ID)
      references TAIKHOAN (TK_ID)


alter table TINHTHANH
   add constraint FK_TINHTHAN_RELATIONS_VUNG foreign key (VUNG_ID)
      references VUNG (VUNG_ID)

