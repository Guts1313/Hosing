using DataItems.LogicItems;

namespace DataAccessLayer.Interfaces
{
    public interface IAnnouncementController
    {
        public bool Create(Announcements announcements);

        public bool Update(Announcements announcements);

        public bool Delete(Announcements announcements);

        public Announcements[] GetAll();

        public Announcements[] GetAllCurrent();

		public Announcements GetById(int id);
    }
}
