using Ninject;
using System.Collections.Generic;
using the_third.Models;
using the_third.Models.Repository;
using the_third.Presenters;

namespace the_third.App_Start
{
    public static class DIconfiguration
    {
        public static void SetupDI(IKernel kernel)
        {
            //GuestResponse
            kernel.Bind<IPresenter<GuestResponse>>().To<RSVPPresenter>();
            kernel.Bind<IPresenter<IEnumerable<GuestResponse>>>().To<RSVPPresenter>();
            kernel.Bind<IRepository>().To<ResponseRepository>().InSingletonScope();
            //GuestResponse                 END
        }
    }
}