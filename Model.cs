public class ComicBook
{
    public int Id { int ; }
    public string Title { nvarchar(255); doremon; }
    public string Author {nvarchar(255) ; fuij ; }
    public decimal Price { decimal(10,2); 50 ; }
}

public class Customer
{

    public int Id { int; }
    public string FullName {nvarchar(255); QuanNH; }
    public string PhoneNumber { nvarchar(15); 0989456789; }
    public DateTime RegisterDate { 05/07/2024 ; }
}

public class Rental
{
    public int Id { int ; }
    public int CustomerId { get; set; }
    public DateTime RentalDate { datetime ;26/11/2024 }
    public DateTime ReturnDate { datetime ;26/11/2024 }
    public decimal Status  { nvarchar(50); đang thuê ; }
    public ICollection<RentalDetail> RentalDetails { get; set; }
}

public class RentalDetail
{
    public int Id { int ;}
    public int RentalId { int ;}
    public int ComicBookId { int ; }
    public int Quantity { int ; 5 }
    public decimal PricePerDay {decimal(10,2) ; }
}
