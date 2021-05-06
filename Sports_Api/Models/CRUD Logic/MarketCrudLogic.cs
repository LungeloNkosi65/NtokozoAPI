using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Sports_Api.Models.CRUD_Logic
{
    public class MarketCrudLogic: ICrudMakeLogic
    {
        private static HollywoodBetsRepDbContext _context;

        public  MarketCrudLogic(HollywoodBetsRepDbContext hollywoodBetsRepDbContext)
        {
            _context = hollywoodBetsRepDbContext;
        }

        public  void AddMake(Make make)
        {
            _context.Makes.Add(make);
            _context.SaveChanges();

        }

        public  void UpdateMake(Make make)
        {
            _context.Entry(make).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteMake(int? makeId)
        {
            var makeFromDb = _context.Makes.Where(x => x.MakeId == makeId).FirstOrDefault();
            _context.Makes.Remove(makeFromDb);
            _context.SaveChanges();

        }


        public  List<Make> GettAllMakes()
        {
            var results = _context.Makes.ToList();
            return results;
        }


        public  Make GetMakeById(int? makeId)
        {
            var results = _context.Makes.Find(makeId);
            return results;
        }


    }
}
