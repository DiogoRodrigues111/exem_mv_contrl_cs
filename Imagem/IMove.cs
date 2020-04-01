using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imagem
{
    public interface IMove
    {
        uint Movement(int x, int y);
        bool MouseTrack(int x, int y);
    }
}
