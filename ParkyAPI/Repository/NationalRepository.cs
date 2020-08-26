using ParkyAPI.Data;
using ParkyAPI.Models;
using ParkyAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Repository
{
    public class NationalRepository : INationalRepository
    {
        private readonly ApplicationDbContext _db;

        public NationalRepository(ApplicationDbContext db)
        {
            _db = db  ;
        }

        public bool CreateNationalPark(NationalPark nationalPark)
        {
            _db.nationalParks.Add(nationalPark);
            return save();
        }

        public bool DeleteNationalPark(NationalPark nationalPark)
        {
            _db.nationalParks.Remove(nationalPark);
            return save();
        }

        public NationalPark GetNationalPark(int nationalParkID)
        {
            return _db.nationalParks.FirstOrDefault(a => a.Id == nationalParkID);
        }

        public ICollection<NationalPark> GetNationalParks()
        {
            return _db.nationalParks.OrderBy(a => a.Name).ToList();
        }

        public bool NationalParkExists(string name)
        {
           bool value =   _db.nationalParks.Any(a => a.Name.ToLower() == name.ToLower());

            return value;

        }

        public bool NationalParkExists(int id)
        {
            bool value = _db.nationalParks.Any(a => a.Id == id);

            return value;
        }

        public bool save()
        {
           return _db.SaveChanges() >=0 ? true: false;
        }

        public bool UpdateNationalPark(NationalPark nationalPark)
        {
            _db.nationalParks.Update(nationalPark);
            return save();
        }
    }
}
