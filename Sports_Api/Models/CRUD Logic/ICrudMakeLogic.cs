using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models.CRUD_Logic
{
   public interface ICrudMakeLogic
    {

          void AddMake(Make make);


          void UpdateMake(Make make);

         void DeleteMake(int? makeId);
         List<Make> GettAllMakes();



        Make GetMakeById(int? makeId);
       
    }
}
