# BÀI TẬP NHÓM 8
# Viết ứng dụng quản lý người dùng với tính năng đăng nhập, đăng ký
Tạo ứng dụng Windows Forms bằng C# với các tính năng đăng nhập và đăng ký người dùng, lưu trữ thông tin người dùng vào cơ sở dữ liệu SQL Server. | [Link](https://github.com/TheAnh-05-UIT/NT106-Q14_BTNhom08) |

## Tính năng chính

* Giao diện người dùng
* Chức năng đăng ký
* Chức năng đăng nhập
* Cơ sở dữ liệu
* Mã hóa mật khẩu
* Tính năng quản lý sinh viên (Thêm, xóa, sửa)

## Phần mềm cần thiết

* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
* [SQL Server 2022](https://www.microsoft.com/vi-vn/sql-server/sql-server-downloads)

## Hướng dẫn cài đặt

### 1. Tải và cài đặt các phần mềm cần thiết

### 2. Cài đầy đủ thành phần cho VS2022
#### Workloads:
  
   * ".NET desktop development"
   * "Data storage and processing"
   * ".NET Framework 4.7.2 (hoặc cao hơn)"

#### Individual Components

   * "SQL Server Express LocalDB"
   * "SQL Server Data Tools"

### 3. Tạo bản sao của repository NT106Q14-BTNHOM8-2025
```bash
git clone https://github.com/TheAnh-05-UIT/NT106-Q14_BTNhom08.git
nhấn vào folder NT106-Q14_BTNhom08
mở file FormRegisterLogin-Group8.sln
```

### 4. Tạo Server và Database
* Kết nối đến server "(localdb)\MSSQLLocalDB" bằng [SMMS](https://learn.microsoft.com/en-us/ssms/) hoặc bằng VS2022
* Tạo Database bằng cách execute file "DatabaseConnection.sql"

### 5. Build và chạy 
* Set Project thành Startup Project
* Debug -> Start Debugging

### 6. Sử dụng ứng dụng
* Đăng ký tài khoản Giáo Viên
* Đăng nhập tài khoản Giáo Viên
* Quản lý Sinh Viên

## Tài liệu tham khảo

* [Tài liệu C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [Tài liệu Winforms](https://learn.microsoft.com/vi-vn/dotnet/desktop/winforms/)
* [Tài liệu SQL Server](https://learn.microsoft.com/en-us/sql/?view=sql-server-ver17)

## Credits
### Nhóm 8
| Tên thành viên   |      MSSV      |
|------------------|:--------------:|
| Nguyễn Quang Thế Anh   |   24520115     |
| Nguyễn Nhật Anh  |   24520112     |
| Nguyễn Hoàng Anh  |   24520102     |
| Phạm Phú Quang  |   24521478     |
| Trần Minh Hoàng Quân  |   24521454     |
