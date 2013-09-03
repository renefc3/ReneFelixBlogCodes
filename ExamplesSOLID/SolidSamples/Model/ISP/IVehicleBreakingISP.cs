using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ISP
{

    public interface IVehicleBreakingISP
    {
        void TurnOn();
        void TurnOff();

        void OpenDoor();
        void CloseDoor();
    }
}
