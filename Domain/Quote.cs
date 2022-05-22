

public class Quotes
{
    public int id { get; set; }
    public string ? Author { get; set; }
    public string ? QuoteText { get; set; }
     public string ? CategoryId { get; set; }
}


public class GetQuotes
{
    public int id { get; set; }
    public string ? Author { get; set; }
    public string ? QuoteText { get; set; }
     public int ? CategoryId { get; set; }
     public string ?  CategoryName { get; set; }
}
