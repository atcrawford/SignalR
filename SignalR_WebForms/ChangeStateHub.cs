using System.Collections.Generic;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Model;
using System.Linq;

namespace SignalR_Demo.ChangeState
{
    [HubName("changeState")]
    public class ChangeStateHub : Hub
    {
        private static List<Stall> _stalls;

        public ChangeStateHub()
        {
            if (_stalls == null)
            {
                _stalls = new List<Stall>
                    {
                        new Stall {FloorNumber = 8, StallNumber = 1, IsOccuppied = false},
                        new Stall {FloorNumber = 8, StallNumber = 2, IsOccuppied = false},
                        new Stall {FloorNumber = 15, StallNumber = 1, IsOccuppied = false}
                    };
            }
        }

        public void ChangeState(string compositeId)
        {
            var stall = _stalls.SingleOrDefault(x => x.CompositeId == compositeId);
            stall.IsOccuppied = !stall.IsOccuppied;

            Clients.All.stateChanged(stall);
        }

        public void GetState(Stall stall)
        {
            Clients.Caller.stateChanged(stall);
        }

        public void GetState()
        {
            foreach (var stall in _stalls)
            {
                Clients.Caller.stateChanged(stall);
            }
        }
    }
}