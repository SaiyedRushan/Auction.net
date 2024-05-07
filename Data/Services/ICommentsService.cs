using Auction.net.Models;

namespace Auction.net.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}