using HotelListing.Data;
using HotelListing.IRepository;
using HotelListing.Models;
using System;
using System.Threading.Tasks;

namespace HotelListing.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenereicRepository<Country> _countries;
        private IGenereicRepository<Hotel> _hotels;

        public UnitOfWork(DatabaseContext context)
        {
            ; _context = context;

        }

        public IGenereicRepository<Country> countries => _countries ??= new GenericRepository<Country>(_context);
        public IGenereicRepository<Hotel> hotels => _hotels ??= new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
