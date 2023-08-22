using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGUI.GameGL
{
    class RandomGhost:Ghost
    {
        public GameDirection direction = GameDirection.Down;

        public RandomGhost(Image img, GameCell cell) : base(img, cell) { }

        public int GenerateRandomNumber()
        {
            Random rand = new Random();
            int number = rand.Next(4);
            return number;
        }

        public override GameCell Move()
        {
            int num = GenerateRandomNumber();

            GameCell currentCell = this.CurrentCell;
            GameCell NextCell = currentCell.nextCell(direction);
            GameCell temp = new GameCell(NextCell.X, NextCell.Y, NextCell.Grid);
            temp.setGameObject(NextCell.CurrentGameObject);
            GameObject nextobject = NextCell.CurrentGameObject;
            this.CurrentCell = NextCell;
            NextCell.setGameObject(currentCell.CurrentGameObject);
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
            if(num == 0)
            {
                direction = GameDirection.Left;
            }
            else if(num == 1) 
            {
                direction = GameDirection.Right;
            }
            else if(num == 2) 
            {
                direction = GameDirection.Up;
            }
            else if(num == 3)
            {
                direction = GameDirection.Down;
            }
            return temp;
        }
    }
}
