using PacMan.GameGL;
using PacManGUI.GameGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGUI
{
    internal class SmartGhost : Ghost
    {
        GameObjectType prevObj;
        public GameObjectType PrevObj { get => prevObj; set { prevObj = value; } }
        GamePacManPlayer player;
        public SmartGhost(Image img, GameCell cell) : base(img, cell) { }
       
       /* public SmartGhost(GameCell cell, GamePacManPlayer pacman) : base(GameObjectType.ENEMY, PacManGUI.Properties.Resources.ghost_pink)
        {
            this.player = pacman;
            this.CurrentCell = cell;
        }*/
        public override GameCell Move()
        {
            double[] distances = new double[4] { 999999, 999999, 999999, 999999 };
            GameDirection direction = GameDirection.Left;
            GameCell nextCell = this.CurrentCell.nextCell(direction);
            if (nextCell != CurrentCell)
            {
                distances[0] = distance(nextCell, player.CurrentCell);
            }
            direction = GameDirection.Right;
            nextCell = this.CurrentCell.nextCell(direction);
            if (nextCell != CurrentCell)
            {
                distances[1] = distance(nextCell, player.CurrentCell);
            }
            direction = GameDirection.Up;
            nextCell = this.CurrentCell.nextCell(direction);
            if (nextCell != CurrentCell)
            {
                distances[2] = distance(nextCell, player.CurrentCell);
            }
            direction = GameDirection.Down;
            nextCell = this.CurrentCell.nextCell(direction);
            if (nextCell != CurrentCell)
            {
                distances[3] = distance(nextCell, player.CurrentCell);
            }
            if (distances[0] < distances[1] && distances[0] < distances[2] && distances[0] < distances[3])
            {
                direction = GameDirection.Left;
            }
            else if (distances[1] < distances[0] && distances[1] < distances[2] && distances[1] < distances[3])
            {
                direction = GameDirection.Right;
            }
            else if (distances[2] < distances[1] && distances[2] < distances[0] && distances[2] < distances[3])
            {
                direction = GameDirection.Up;
            }
            else if (distances[3] < distances[1] && distances[3] < distances[2] && distances[3] < distances[3])
            {
                direction = GameDirection.Down;
            }
            GameCell tempcurrentCell = this.CurrentCell;
            nextCell = tempcurrentCell.nextCell(direction);
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD) prevObj = GameObjectType.REWARD;
            else if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.NONE) prevObj = GameObjectType.NONE;
            this.CurrentCell = nextCell;
            if (tempcurrentCell != nextCell)
            {
                //tempcurrentCell.setGameObject(Game.getBlankGameObject());
            }
            return nextCell;
        }

        double distance(GameCell cell1, GameCell cell2)
        {
            return (Math.Sqrt(((cell1.X - cell2.X) * (cell1.X - cell2.X) + (cell1.Y - cell2.Y) * (cell1.Y - cell2.Y))));
        }
    }
}
