﻿namespace CinemaWorld.Models.ViewModels.Movies
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using CinemaWorld.Data.Models;
    using CinemaWorld.Models.ViewModels.Directors;
    using CinemaWorld.Models.ViewModels.Genres;
    using CinemaWorld.Services.Mapping;

    using static CinemaWorld.Models.Common.ModelValidation.Movie;

    public class MovieDeleteViewModel : IMapFrom<Movie>, IMapFrom<Director>, IMapFrom<Genre>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = DateOfReleaseDisplayName)]
        public DateTime DateOfRelease { get; set; }

        public string DateOfReleaseAsString => this.DateOfRelease.ToShortDateString();

        public string Resolution { get; set; }

        public decimal Rating { get; set; }

        public string Description { get; set; }

        public string Language { get; set; }

        [Display(Name = CinemaCategoryDisplayName)]
        public string CinemaCategory { get; set; }

        [Display(Name = TrailerPathDisplayName)]
        public string TrailerPath { get; set; }

        [Display(Name = CoverPathDisplayName)]
        public string CoverPath { get; set; }

        [Display(Name = IMDBLinkDisplayName)]
        public string IMDBLink { get; set; }

        public int Length { get; set; }

        [Display(Name = nameof(Director))]
        public DirectorViewModel Director { get; set; }

        [Display(Name = nameof(Genre))]
        public GenreDetailsViewModel Genre { get; set; }
    }
}
