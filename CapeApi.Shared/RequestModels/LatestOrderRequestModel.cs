using System.ComponentModel.DataAnnotations;

namespace CapeApi.Shared
{
    public class LatestOrderRequestModel
    {
        [Required, EmailAddress]
        public string User { get; set; }

        [Required]
        public string CustomerId { get; set; }
    }
}
