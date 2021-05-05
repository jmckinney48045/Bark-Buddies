﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BarkBuddies.Data.Entities
{
    public class UserProfile
    {
        public int Id { get; set; }
        [DisplayName("Zip Code")]
        public int? ZipCode { get; set; }
        public bool HasChildren { get; set; }
        public bool HasCats { get; set; }
        public SizeChoice SizeChoice { get; set; }
        public AgeChoice AgeChoice { get; set; }
        public IdentityUser User { get; set; }
    }

    public enum SizeChoice
    {
        [Display(Name = "Smaller")]
        smaller = 0,
        [Display(Name = "Same Size")]
        same,
        [Display(Name = "Larger")]
        bigger
    }

    public enum AgeChoice
    {
        [Display(Name = "Younger")]
        younger = 0,
        [Display(Name = "Same Age")]
        same,
        [Display(Name = "Older")]
        older
    }
}
