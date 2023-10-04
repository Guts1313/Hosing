using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
    public class AnnouncemetsController
    {
        private IAnnouncementController _announcementController;
        public AnnouncemetsController(IAnnouncementController announcementController)
        {
            _announcementController = announcementController;
        }
        public bool CreateAnnouncement(Announcements announcements)
        {
            return _announcementController.Create(announcements);
        }
        public bool DeleteAnnouncement(Announcements announcements)
        {
            return _announcementController.Delete(announcements);
        }
        public bool UpdateAnnouncement(Announcements announcements)
        {
            return _announcementController.Update(announcements);
        }
        public Announcements[] GetAll()
        { 
            return _announcementController.GetAll(); 
        }
		public Announcements[] GetAllCurrent()
        {
            return _announcementController.GetAllCurrent();
        }
		public Announcements GetById(int id)
        {
            foreach (Announcements announcement in GetAll())
            {
                if(announcement.Id == id)
                    return announcement;
            }
            return null;
        }
    }
}
