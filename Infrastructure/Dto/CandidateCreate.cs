using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infrastructure.Dto;

public record CandidateCreate
{
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }
    [Required ,Phone] public string Phone { get; set; }
    [Required] public string City { get; set; }
    public string Education { get; set; } = "Не имеет";
    public string PreviousWork { get; set; } = "Не имеет";
    public string Status { get; set; } = "Новый";
}
