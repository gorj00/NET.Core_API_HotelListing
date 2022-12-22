using HotelListing.Models;
using System;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenereicRepository<Country> countries { get; }
        IGenereicRepository<Hotel> hotels { get; }
        Task Save();

    }
}
