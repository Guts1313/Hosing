using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
    public class DepartmentController
    {
        private IDepartmentController _departmentDAL;

        public DepartmentController(IDepartmentController departmentController)
        {
            _departmentDAL = departmentController;
        }

        public bool Create(Department department)
        {
            return _departmentDAL.Create(department);
        }

        public bool Remove(Department department)
        {
            return _departmentDAL.Delete(department);
        }

        public bool Update(Department department)
        {
            return _departmentDAL.Update(department);
        }

        public Department[] GetAll()
        {
            return _departmentDAL.GetAll();
        }

        public Department Get(int id)
        {
            foreach (Department department in GetAll())
            {
                if (department.Id == id) return department;
            }
            return null;
        }

        public Department Get(string name)
        {
            foreach (Department department in GetAll())
            {
                if (department.Name == name) return department;
            }
            return null;
        }

    }
}
