using backend.BE;
using backend.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.BL
{
    public class PeriodicElementLogic : IPeriodicElement
    {
        private PeriodicElementDataContext DataContext { get; set; }

        public PeriodicElementLogic(PeriodicElementDataContext dataContext)
        {
            DataContext = dataContext;
        }

        public PeriodicElement Get(int id)
        {
            throw new NotImplementedException();
        }

        public PeriodicElement Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<PeriodicElement> GetAll() => GetMock();//DataContext.PeriodicElements.ToList();

        public bool Create(PeriodicElement periodicElement)
        {
            throw new NotImplementedException();
        }

        public bool Update(PeriodicElement periodicElement)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string name)
        {
            throw new NotImplementedException();
        }

        public List<PeriodicElement> GetMock()
        {
            List<PeriodicElement> list = new List<PeriodicElement>()
            {
                  new PeriodicElement{Position= 1, Name= "Hydrogen", Weight= 1.0079, Symbol= "H"},
                  new PeriodicElement{Position= 2, Name= "Helium", Weight= 4.0026, Symbol= "He"},
                  new PeriodicElement{Position= 3, Name= "Lithium", Weight= 6.941, Symbol= "Li"},
                  new PeriodicElement{ Position= 4, Name= "Beryllium", Weight= 9.0122, Symbol= "Be"},
                  new PeriodicElement { Position = 5, Name = "Boron", Weight= 10.811, Symbol= "B" },
                  new PeriodicElement { Position = 6, Name = "Carbon", Weight= 12.0107, Symbol= "C" },
                  new PeriodicElement { Position = 7, Name = "Nitrogen", Weight= 14.0067, Symbol= "N" },
                  new PeriodicElement { Position = 8, Name = "Oxygen", Weight= 15.9994, Symbol= "O" },
                  new PeriodicElement { Position = 9, Name = "Fluorine", Weight= 18.9984, Symbol= "F" },
                  new PeriodicElement { Position = 10, Name = "Neon", Weight= 20.1797, Symbol= "Ne" }
            };
            return list;
        }
    }
}
