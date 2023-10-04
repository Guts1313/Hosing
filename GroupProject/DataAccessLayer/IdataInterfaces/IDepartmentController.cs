using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface IDepartmentController
    {
        public bool Create(Department department);

        public bool Update(Department department);

        public bool Delete(Department department);

        public Department[] GetAll();

        public Department Get(int id);

        public Department Get(string name);
    }
}
