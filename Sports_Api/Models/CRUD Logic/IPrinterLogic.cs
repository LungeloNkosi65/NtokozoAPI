using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models.CRUD_Logic
{
    public interface IPrinterLogic
    {
        void AddPrinter(Printer printer);


        void UpdatePrinter(Printer printer);

        void DeletePrinter(int? printerId);
        List<Printer> GettAllPrinters();
        List<VPrinter> GettAllVPrinters();



        Printer GetPrinterById(int? printerId);
    }
}
