﻿namespace CinemaWorld.Services.Data.Contracts
{
    using System.Threading.Tasks;

    public interface INewsCommentsService
    {
        Task Create(int newsId, string userId, string content, int? parentId = null);

        Task<bool> IsInNewsId(int commentId, int newsId);
    }
}
