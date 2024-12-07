public class ComicBook
{
    public int Id { int ; }
    public string Title { nvarchar(255); tên sách; }
    public string Author {nvarchar(255) ; tác giả ; }
    public decimal Price { decimal(10,2); giá thuê 1 ngày ; }
}

public class Customer
{

    public int Id { int; }
    public string FullName {nvarchar(255); họ tên; }
    public string PhoneNumber { nvarchar(15); số điện thoại; }
    public DateTime RegisterDate { datetime ; ngày đăng ký ; }
}

public class Rental
{
    public int Id { int ; }
    public int CustomerId { get; set; }
    public DateTime RentalDate { datetime ; }
    public DateTime ReturnDate { datetime ; }
    public decimal TotalPrice { nvarchar(50); set; }
    public ICollection<RentalDetail> RentalDetails { get; set; }
}

public class RentalDetail
{
    public int Id { int ;}
    public int RentalId { int ;}
    public int ComicBookId { int ; }
    public int Quantity { int ; }
    public decimal PricePerDay {decimal(10,2) ; }
}
