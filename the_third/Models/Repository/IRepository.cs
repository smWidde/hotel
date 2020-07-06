using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_third.Models.Repository
{
    public interface IRepository
    {
        IEnumerable<GuestResponse> GetAllResponses();
        void AddResponse(GuestResponse response);
    }
}
