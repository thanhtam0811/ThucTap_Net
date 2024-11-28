------------slnhap
CREATE TRIGGER tr_capnhatsoluonghangnhap ON Qlnhap FOR INSERT AS
PRINT 'trigger tr_capnhatsoluonghangnhap dang kich hoat'
SELECT * FROM INSERTED
UPDATE Qlhanghoa SET soluong = soluong + (SELECT soluongnhap FROM INSERTED)
WHERE mahang = (SELECT mahang FROM INSERTED)

select *from Qlhanghoa
	Select *from Qlnhap
Insert into Qlnhap values(14,'NV11','MH11','MN11','2002-1-1',1000,2000,10,2000)
DROP TRIGGER tr_capnhatsoluonghangnhap


-----------slxuat
CREATE TRIGGER tr_capnhatsoluonghangxuat ON Qlxuat FOR INSERT AS
PRINT 'trigger tr_capnhatsoluonghang dang kich hoat'
SELECT * FROM INSERTED
UPDATE Qlhanghoa SET soluong = soluong - (SELECT soluongxuat FROM INSERTED)
WHERE mahang = (SELECT mahang FROM INSERTED)

DROP TRIGGER tr_capnhatsoluonghangxuat

Insert into Qlxuat values(23,'MH11',N'dat','2002-1-1','a',1000,2000,10,2000)
select *from Qlhanghoa
	Select *from Qlxuat

------------tiennhap
Create trigger trigThemTinhTien on Qlnhap
after insert,update 
as
	update Qlnhap set ThanhTien=c.soluongnhap*c.gianhap + c.soluongnhap*c.gianhap*c.thue/100 from inserted i,Qlnhap c where c.manhap=i.manhap

	
Drop trigger trigThemTinhTien

------------tienxuat
Create trigger trigThemTinhTienxuat on Qlxuat
after insert,update 
as
	update Qlxuat set thanhtien=c.soluongxuat*c.giaxuat + c.soluongxuat*c.giaxuat*c.thue/100 from inserted i,Qlxuat c where c.maxuat=i.maxuat
Drop trigger trigThemTinhTienxuat

Insert into Qlxuat values(24,'MH11',N'dat','2002-1-1','a',1000,2000,10,2000)

	Select *from Qlxuat

------------luong
CREATE TRIGGER tr_capnhatthanhtien ON Qlluong FOR INSERT AS
	PRINT 'trigger tr_capnhatthanhtien dang hoat dong'
	SELECT* FROM INSERTED
	UPDATE Qlluong SET tienluong = (SELECT hesoluong*luongcoban FROM QLluong,Qlnhanvien 
											WHERE Qlluong.manv=Qlnhanvien.manv AND maluong = (SELECT maluong FROM INSERTED))
	WHERE maluong = (SELECT maluong FROM INSERTED)

	Insert into Qlluong values(3,'NV11',1.7,2000000)

	Select *from Qlluong

DROP TRIGGER tr_capnhatthanhtien


