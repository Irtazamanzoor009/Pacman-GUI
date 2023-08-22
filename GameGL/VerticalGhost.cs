using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGUI.GameGL
{
     class VerticalGhost : Ghost
    {
        public GameDirection direction = GameDirection.Up;

        public VerticalGhost(Image img, GameCell cell) : base(img, cell) { }

        public override GameCell Move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell NextCell = currentCell.nextCell(direction);
            GameCell temp = new GameCell(NextCell.X, NextCell.Y, NextCell.Grid);
            temp.setGameObject(NextCell.CurrentGameObject);
            GameObject nextobject = NextCell.CurrentGameObject;
            this.CurrentCell = NextCell;
            if (currentCell != NextCell)
            {
                if(previous.GameObjectType == GameObjectType.REWARD)
                {
                    currentCell.setGameObject(Game.GetRewardObject());
                }
                else
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                }
                previous = nextobject;
            }
            
            else
            {
                ChangeDirection();
            }
            return temp;
        }

        public void ChangeDirection()
        {
            if (direction == GameDirection.Up)
            {
                direction = GameDirection.Down;
            }
            else if (direction == GameDirection.Down)
            {
                direction = GameDirection.Up;
            }
        }
    }
}
