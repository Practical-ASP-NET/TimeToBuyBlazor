using System.ComponentModel.DataAnnotations;

namespace TimeToBuy.Data;

public record CartCheckoutInfo
{
    public Address DeliveryAddress { get; set; } = new Address();

    [Required] 
    public string CardNumber { get; set; }
    [Required] public string CardHolderName { get; set; }
    [Required] public string CardSecurityNumber { get; set; }
    public DateTime CardExpiration { get; set; } = DateTime.Now.Date;

    public record Address
    {
        [Required] public string BuyerName { get; set; }

        [Required] public string Line1 { get; set; }

        [Required] public string Line2 { get; set; }

        [Required] public string City { get; set; }

        [Required] public string PostCode { get; set; }
    }
}