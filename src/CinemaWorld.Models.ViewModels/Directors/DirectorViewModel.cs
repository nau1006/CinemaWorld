﻿namespace CinemaWorld.Models.ViewModels.Directors
{
    using System.ComponentModel.DataAnnotations;

    using CinemaWorld.Data.Models;
    using CinemaWorld.Services.Mapping;

    using static CinemaWorld.Models.Common.ModelValidation.Director;

    public class DirectorViewModel : IMapFrom<Director>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Display(Name = FullNameDisplayName)]
        public string FullName => string.Concat(this.FirstName, " ", this.LastName);
    }
}
