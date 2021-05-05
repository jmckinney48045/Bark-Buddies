﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BarkBuddies.Data.Entities
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public Age Age { get; set; }
        public string Gender { get; set; }
        public Size Size { get; set; }
        public string Breed { get; set; }
        public IdentityUser Owner { get; set; }
    }

    public enum Size
    {
        [Display(Name = "Small")]
        small = 0,

        [Display(Name = "Medium")]
        medium,

        [Display(Name = "Large")]
        large,

        [Display(Name = "Extra Large")]
        xlarge
    }

    public enum Age
    {
        [Display(Name = "Puppy")]
        baby = 0,

        [Display(Name = "Young")]
        young,

        [Display(Name = "Adult")]
        adult,

        [Display(Name = "Senior")]
        senior
    }
}
