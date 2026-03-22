CREATE DATABASE IF NOT EXISTS QuanLyXeBuyt CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE QuanLyXeBuyt;
-- 1. Vai trò 
CREATE TABLE Roles (
    RoleID INT PRIMARY KEY AUTO_INCREMENT,
    RoleName VARCHAR(50) -- Admin, Manager, Driver, Passenger
);

-- 2. Người dùng 
CREATE TABLE Users (
    UserID INT PRIMARY KEY AUTO_INCREMENT,
    Username VARCHAR(50) UNIQUE,
    Password VARCHAR(255),
    FullName VARCHAR(100),
    RoleID INT,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

-- 3. Tuyến đường
CREATE TABLE Routes (
    RouteID VARCHAR(10) PRIMARY KEY,
    RouteName VARCHAR(255),
    BaseFare INT
);

-- 4. Trạm dừng
CREATE TABLE Stops (
    StopID INT PRIMARY KEY AUTO_INCREMENT,
    StopName VARCHAR(255),
    Latitude DOUBLE, 
    Longitude DOUBLE
);

-- 5. Chi tiết lộ trình
CREATE TABLE RouteDetails (
    RouteID VARCHAR(10),
    StopID INT,
    StopOrder INT,
    Direction TINYINT, -- 0: Đi, 1: Về
    PRIMARY KEY (RouteID, StopID, Direction),
    FOREIGN KEY (RouteID) REFERENCES Routes(RouteID),
    FOREIGN KEY (StopID) REFERENCES Stops(StopID)
);

-- 6. Xe 
CREATE TABLE Buses (
    BusID INT PRIMARY KEY AUTO_INCREMENT,
    LicensePlate VARCHAR(20) UNIQUE, -- Biển số xe 
    Status VARCHAR(50) -- Sẵn sàng, Đang chạy, Bảo trì
);

-- 7. Phân công 
CREATE TABLE Assignments (
    AssignmentID INT PRIMARY KEY AUTO_INCREMENT,
    RouteID VARCHAR(10),
    BusID INT,
    DriverID INT, -- Foreign key tới Users(UserID)
    AssignedDate DATE,
    Shift INT, -- 1: Sáng, 2: Chiều
    FOREIGN KEY (RouteID) REFERENCES Routes(RouteID),
    FOREIGN KEY (BusID) REFERENCES Buses(BusID),
    FOREIGN KEY (DriverID) REFERENCES Users(UserID)
);

-- 8. Loại vé
CREATE TABLE TicketTypes (
    TypeID INT PRIMARY KEY AUTO_INCREMENT,
    TypeName VARCHAR(100), -- Vé lượt, Vé tháng SV, Vé tháng thường
    Price INT -- Giá tiền (số nguyên)
);

-- 9. Vé xe
CREATE TABLE Tickets (
    TicketID INT PRIMARY KEY AUTO_INCREMENT,
    QRCode VARCHAR(255) UNIQUE, -- Mã định danh để quét
    TypeID INT,
    UserID INT, -- Chủ thẻ
    ExpiryDate DATE,
    IsActive BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (TypeID) REFERENCES TicketTypes(TypeID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- 10. Doanh thu
CREATE TABLE Revenue (
    RevenueID INT PRIMARY KEY AUTO_INCREMENT,
    AssignmentID INT, -- Doanh thu gắn với ca trực
    TotalTicketsSold INT, -- Tổng vé bán
    TotalAmount INT,	-- Tổng tiền
    ReportDate DATE,
    FOREIGN KEY (AssignmentID) REFERENCES Assignments(AssignmentID)
);