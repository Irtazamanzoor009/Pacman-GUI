using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGUI.GameGL
{
    abstract class Ghost : GameObject 
    {
        public GameObject previous = Game.getBlankGameObject();
        public Ghost(Image img, GameCell cell) : base(GameObjectType.ENEMY, img)
        {
            this.CurrentCell = cell;
        }

        public abstract GameCell Move();

        GameObjectType PrevObj { get; set; }
    }
}
