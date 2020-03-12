-------------get Chi Nhanh Detail
CREATE PROCEDURE getChiNhanhDetail @CN_ID nvarchar(100)
AS
select cn.CN_ID, cn.TT_ID, cn.CN_TEN, cn.CN_SDT, cn.CN_DIACHI, tt.TT_TEN, tt.VUNG_ID from CHINHANH cn left join TINHTHANH tt on cn.TT_ID = tt.TT_ID where cn.CN_ID = @CN_ID
GO
--exec getChiNhanhDetail 'D10'

-------------get Danh gia theo chi nhanh
CREATE PROCEDURE getDanhGiaTheoChiNhanh @CN_ID nvarchar(100)
AS
select * from danhgia where cn_id = @CN_ID
GO
--exec getDanhGiaTheoChiNhanh 'D10'

-------------get Tinh thanh Detail
CREATE PROCEDURE getTinhThanhDetail @TT_ID nvarchar(100)
AS
select tt.TT_ID, tt.TT_TEN, tt.VUNG_ID, v.VUNG_TEN from TINHTHANH tt left join VUNG v on tt.VUNG_ID = v.VUNG_ID where tt.TT_ID = @TT_ID
GO
--exec getTinhThanhDetail 'T1'

-------------get Chi nhanh theo tinh thanh
CREATE PROCEDURE getChiNhanhTheoTinh @TT_ID nvarchar(100)
AS
select CN_ID, CN_TEN, CN_SDT, CN_DIACHI from chinhanh where tt_id = @TT_ID
GO
--exec getChiNhanhTheoTinh 'T1'

-------------get Chi nhanh theo vung
CREATE PROCEDURE getChiNhanhTheoVung @VUNG_ID nvarchar(100)
AS
select cn.CN_ID, cn.CN_TEN, cn.CN_SDT, cn.CN_DIACHI, tt.TT_TEN from CHINHANH cn left join tinhthanh tt on cn.TT_ID = tt.TT_ID where cn.TT_ID in (
select TT_ID from tinhthanh where vung_id = @VUNG_ID)
GO
--exec getChiNhanhTheoVung 'V5'

-------------get Vung Detail
CREATE PROCEDURE getVungDetail @VUNG_ID nvarchar(100)
AS
select * from VUNG where VUNG_ID = @VUNG_ID
GO
--exec getVungDetail 'V5'

-------------get Image
CREATE PROCEDURE getHinhTheoChiNhanh @CN_ID nvarchar(100)
AS
select TOP 1 * from HINHANH where CN_ID =  @CN_ID 
order by hinh_id desc
GO
--exec getHinhTheoChiNhanh 'D10'

--------------search Ten Chi Nhanh
CREATE PROCEDURE searchChiNhanh @SEARCH_STRING nvarchar(255)
AS
select * from CHINHANH where CN_TEN LIKE @SEARCH_STRING
GO

-------------search Thuc Uong
CREATE PROCEDURE searchThucUong @SEARCH_STRING nvarchar(255)
AS
select * from THUCUONG where THUCUONG_TEN LIKE @SEARCH_STRING
GO

-------------search Tai Khoan
CREATE PROCEDURE searchTaiKhoan @SEARCH_STRING nvarchar(255)
AS
select * from TAIKHOAN where TK_HOTEN LIKE @SEARCH_STRING
GO

