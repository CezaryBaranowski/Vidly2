using System.Collections.Generic;

namespace Vidly2.DTOs
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }

        public List<int> MovieIds { get; set; }
    }
}