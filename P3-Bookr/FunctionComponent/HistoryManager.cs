﻿using System;
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

        public List<Service> GetLastUsedServices(Member member, int count)
        {
            List<Service> result = new List<Service>();
            List<Reservation> reservations = _modelComponent.GetAllReservationsByMember(member);

            reservations = reservations.OrderByDescending(r => r.CreationDate).ToList();
            foreach (Reservation res in reservations)
            {
                if (result.Count() == count)
                    break;
                if (!result.Contains(res.ServiceOffering.Service))
                {
                    result.Add(res.ServiceOffering.Service);
                }
            }
            return result;
        }
    }
}
