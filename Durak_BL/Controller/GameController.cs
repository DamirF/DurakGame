using Durak_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak_BL.Controller
{
    public class GameController
    {
        PackController packController;
        List<Player> Players; // maybe will be changed to PlayerController;

        public GameController()
        {
            packController = new PackController(ref Players);
        }
    }
}
