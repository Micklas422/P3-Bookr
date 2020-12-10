using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    class HistoryManager : IHistoryManager
    {
        IModelComponent _modelComponent;
        public HistoryManager(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
        }

        public void SeeHistory()
        {
            throw new NotImplementedException();
        }
    }
}
