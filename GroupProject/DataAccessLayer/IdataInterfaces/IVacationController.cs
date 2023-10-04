using DataItems.LogicItems;

namespace DataAccessLayer.Interfaces
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
