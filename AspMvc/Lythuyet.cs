namespace AspMvc
{
    public class Lythuyet
    {
        //2.1 Có mấy loại project ASP.NET Core MVC?
        /*
         ASP.NET Core có nhiều loại project khác nhau, nhưng phổ biến nhất là:

            1 : ASP.NET Core MVC: Dùng để phát triển ứng dụng web theo mô hình MVC, sử dụng Razor để render giao diện HTML.
            2 : ASP.NET Core API: Dùng để phát triển API, chỉ cung cấp dữ liệu (thường là JSON hoặc XML), không kèm theo giao diện người dùng.
            3 : ASP.NET Core Razor Pages: Một kiểu dựa trên trang, cho phép xây dựng ứng dụng web đơn giản hơn so với MVC, nhưng vẫn mạnh mẽ với khả năng của ASP.NET Core.
            4 : Blazor: Cho phép viết code C# để chạy trên cả server-side hoặc client-side (thông qua WebAssembly), phù hợp cho các ứng dụng web tương tác cao.
         */

        // 2.2 Thành phần cấu trúc của ASP.NET Core MVC là gì?

        /*
         ASP.NET Core MVC có các thành phần chính sau:

            1.Models:

                Định nghĩa: Models đại diện cho dữ liệu của ứng dụng và logic nghiệp vụ. Đây là nơi chứa các lớp, phương thức để xử lý dữ liệu, tương tác với cơ sở dữ liệu.
                Thành phần: Các class, phương thức liên quan đến dữ liệu, validations, truy xuất dữ liệu từ database.
            2.Views:

                Định nghĩa: Views là thành phần để tạo ra giao diện người dùng (UI). Chúng sử dụng Razor để kết hợp HTML với C#.
                Thành phần: Các file .cshtml chứa HTML và C# code, thường được tổ chức trong các thư mục tương ứng với các Controller.
            3.Controllers:

                Định nghĩa: Controllers là thành phần điều khiển luồng xử lý của ứng dụng. Chúng nhận các request từ client, xử lý dữ liệu thông qua Models, và trả về kết quả qua Views.
                Thành phần: Các class kế thừa từ Controller, chứa các phương thức xử lý các hành động (Actions) như Index, Create, Update, Delete.
            4.Routing:

                Định nghĩa: Routing là thành phần quyết định URL nào sẽ được map tới Controller nào và Action nào.
                Thành phần: Các route được cấu hình trong Startup.cs hoặc thông qua các Attribute trực tiếp trên các Actions hoặc Controllers.
            5.Middleware:

                Định nghĩa: Là thành phần trung gian xử lý các request trước khi chúng đến với Controller và xử lý response trước khi trả về cho client.
                Thành phần: Được cấu hình trong Startup.cs, nơi bạn có thể thêm các middleware như Authentication, Logging, Error Handling.
            6.Startup.cs:

                Định nghĩa: File khởi động của ứng dụng, nơi cấu hình các dịch vụ, middleware, routing.
                Thành phần: Chứa các phương thức ConfigureServices và Configure để cấu hình DI container và pipeline của ứng dụng.
            7.Program.cs:

                Định nghĩa: Entry point của ứng dụng, nơi khởi động web host, thường là nơi gọi CreateHostBuilder() và Build().
                Thành phần: Chứa hàm Main() khởi động ứng dụng.
            8.wwwroot:

                Định nghĩa: Thư mục chứa các tài nguyên tĩnh như CSS, JS, hình ảnh.
                Thành phần: Các file tĩnh có thể truy cập trực tiếp từ URL.
         */
    }
}
