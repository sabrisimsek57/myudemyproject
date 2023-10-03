using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccsessLayer.Abstract;
using HotelProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ISendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal sendMessageDal;

        public ISendMessageManager(ISendMessageDal sendMessageDal)
        {
            this.sendMessageDal = sendMessageDal;
        }

        public void TDelete(SendMessage t)
        {
            sendMessageDal.Delete(t);
        }

        public SendMessage TGetByID(int id)
        {
            return sendMessageDal.GetByID(id);
        }

        public List<SendMessage> TGetList()
        {
            return sendMessageDal.GetList();
        }

        public int TGetSendMessageCount()
        {
            return sendMessageDal.GetSendMessageCount();
        }

        public void TInsert(SendMessage t)
        {
            sendMessageDal.Insert(t);
        }

        public void TUpdate(SendMessage t)
        {
            sendMessageDal.Update(t);
        }
    }
}
