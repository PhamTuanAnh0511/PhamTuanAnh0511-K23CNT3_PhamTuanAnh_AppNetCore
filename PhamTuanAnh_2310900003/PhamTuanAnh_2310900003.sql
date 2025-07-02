CREATE DATABASE phamtuananh_2310900003;
GO

USE phamtuananh_2310900003;
GO


CREATE TABLE PtaEmployee (
    PtaEmpId INT PRIMARY KEY,
    PtaEmpName NVARCHAR(100),
    PtaEmpLevel NVARCHAR(50),
    PtaEmpStartDate DATE,
    PtaEmpStatus BIT 
);
GO

INSERT INTO PtaEmployee (PtaEmpId, PtaEmpName, PtaEmpLevel, PtaEmpStartDate, PtaEmpStatus)
VALUES 
(1, 'Pham Tuan Anh', 'Intern', '2005-11-05', 1),
(2, 'Nguyen Van A', 'Junior Developer', '2024-03-15', 0),
(3, 'Tran Thi B', 'Senior Developer', '2023-10-01', 1);
GO
