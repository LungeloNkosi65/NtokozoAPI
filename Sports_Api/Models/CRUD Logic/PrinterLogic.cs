using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models.CRUD_Logic
{
    public class PrinterLogic : IPrinterLogic
    {
        private readonly HollywoodBetsRepDbContext _context;
        public PrinterLogic(HollywoodBetsRepDbContext context)
        {
            _context = context;
        }
        public void AddPrinter(Printer printer)
        {
            _context.Printers.Add(printer);
            _context.SaveChanges();
        }

        public void DeletePrinter(int? printerId)
        {
            var printerFromDb = _context.Printers.Where(x => x.PrinterId == printerId).FirstOrDefault();
            _context.Printers.Remove(printerFromDb);
            _context.SaveChanges();
        }

        public Printer GetPrinterById(int? printerId)
        {
            var results = _context.Printers.Find(printerId);
            return results;
        }

        public List<Printer> GettAllPrinters()
        {
            var results = _context.Printers.ToList();
            return results;
        }

        public List<VPrinter> GettAllVPrinters()
        {
            var results = new List<VPrinter>();
            var printersFromDb = _context.Printers.ToList();
            var printerMakes = _context.Makes.ToList();
            foreach (var item in printersFromDb)
            {
                var xMake = printerMakes.Where(x => x.MakeId == item.MakeId).FirstOrDefault();
                results.Add(new VPrinter
                {
                    PrinterId = item.PrinterId,
                    PrinterName = item.PrinterName,
                    FolderToMinitor = item.FolderToMinitor,
                    OutPutType = item.OutPutType,
                    FileOutput = item.FileOutput,
                    MakeId = item.MakeId,
                    PrinterMake = xMake.PrinterMake,
                    CreateDate = item.CreateDate
                });
            }
           return results;
        }

        public void UpdatePrinter(Printer printer)
        {
            _context.Entry(printer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
