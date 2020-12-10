using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    class ServiceManager : IServiceManager
    {
        IModelComponent _modelComponent;
        public ServiceManager(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
        }
        public void Reserve()
        {
            throw new NotImplementedException();
        }

        public void SeeAvailability()
        {
            throw new NotImplementedException();
        }
    }
}
