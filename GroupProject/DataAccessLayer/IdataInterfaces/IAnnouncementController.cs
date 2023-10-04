using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
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
