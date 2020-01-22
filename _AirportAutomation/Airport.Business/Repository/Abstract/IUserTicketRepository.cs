using Airport.Business.UnitOfWork.Abstract;
using Airport.DataEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Business.Repository.Abstract
{
   public interface IUserTicketRepository:IRepository<UserTicket>
    {
    }
}
