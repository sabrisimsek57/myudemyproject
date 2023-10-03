using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly MessageCategoryManager _messageCategoryManager;

        public void TDelete(MessageCategory t)
        {
            _messageCategoryManager.TDelete(t);
        }

        public MessageCategory TGetByID(int id)
        {
            return _messageCategoryManager.TGetByID(id);
        }

        public List<MessageCategory> TGetList()
        {
           return  _messageCategoryManager.TGetList();
        }

        public void TInsert(MessageCategory t)
        {
            _messageCategoryManager.TInsert(t);
        }

        public void TUpdate(MessageCategory t)
        {
            _messageCategoryManager.TUpdate(t);
        }
    }
}
