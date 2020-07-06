using System;
using System.Collections.Generic;
using the_third.Models;
using the_third.Models.Repository;
using the_third.Presenters.Results;

namespace the_third.Presenters
{
    public class RSVPPresenter : IPresenter<GuestResponse>, IPresenter<IEnumerable<GuestResponse>>
    {
        [Ninject.Inject]
        public IRepository repository{ get; set; }

        IResult IPresenter<IEnumerable<GuestResponse>>.GetResult()
        {
            return new DataResult<IEnumerable<GuestResponse>>(repository.GetAllResponses());
        }

        IResult IPresenter<GuestResponse>.GetResult()
        {
            return new DataResult<GuestResponse>(new GuestResponse());
        }

        IResult IPresenter<GuestResponse>.GetResult(GuestResponse requestData)
        {
            if (requestData.ChosenRoomNumber != null && requestData.FIO != null && requestData.PhoneNumber != null)
            {
                repository.AddResponse(requestData);
                return new SuccessResult(true);
            }
            else
                return new SuccessResult(false);
        }
        //[Not implemented]
        IResult IPresenter<IEnumerable<GuestResponse>>.GetResult(IEnumerable<GuestResponse> requestData)
        {
            throw new NotImplementedException();
        }
    }
}