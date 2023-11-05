using BussinessLayer.Controllers;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppMediaBazaar.Classes
{
    public class AnnouncementsManager
    {
        private AnnouncemetsController _announcementsController;

        public AnnouncementsManager()
        {
            _announcementsController = new AnnouncemetsController(new DALAnnouncementsController());
        }

        public IEnumerable<Announcements> GetAllAnnouncements()
        {
            return _announcementsController.GetAll();
        }

        public Announcements GetAnnouncementById(int id)
        {
            return _announcementsController.GetById(id);
        }

        public bool DeleteAnnouncement(Announcements announcement)
        {
            return _announcementsController.DeleteAnnouncement(announcement);
        }

        public bool AddAnnouncement(Announcements announcement)
        {
            return _announcementsController.CreateAnnouncement(announcement);
        }

        public bool UpdateAnnouncement(Announcements announcement)
        {
            return _announcementsController.UpdateAnnouncement(announcement);
        }
    }
}
