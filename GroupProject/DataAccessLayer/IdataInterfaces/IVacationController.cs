using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
	public interface IVacationController
	{
		public bool Create(Vacation vacation);

		public bool Update(Vacation vacation);

		public bool Delete(Vacation vacation);

		public Vacation[] ReadAll();

		public Vacation[] ReadAllByMember(int id);

		public Vacation[] ReadAllByMemberFiltered(string filter, int id);

		public Vacation ReadById(int id);
	}
}
