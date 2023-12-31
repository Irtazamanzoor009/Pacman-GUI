﻿using System.Windows.Forms;
using System.Drawing;
namespace PacMan.GameGL
{

    public class GameCell
    {
        int row;
        int col;
        GameObject currentGameObject;
        GameGrid grid;
        PictureBox pictureBox;
        const int width = 40;
        const int height = 40;
        public GameCell(int row, int col,GameGrid grid) {
            this.row =row;
            this.col = col;
            pictureBox = new PictureBox();
            pictureBox.Left = col * width;
            pictureBox.Top = row * height;
            pictureBox.Size = new Size(width,height);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;
            this.Grid = grid;
        }
        
        public void setGameObject(GameObject gameObject) {
            currentGameObject = gameObject;
            pictureBox.Image = gameObject.Image;

        }
        public GameCell nextCell(GameDirection direction)
        {
          
            if (direction == GameDirection.Left) {
                if (this.col > 0) {
                    GameCell ncell = Grid.getCell(row, col-1);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL) {
                        return ncell;
                    }
                }    
            }

            if (direction == GameDirection.Right)
            {
                if (this.col < Grid.Cols-1)
                {
                    GameCell ncell = Grid.getCell(this.row, this.col+1);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Up)
            {
                if (this.row > 0)
                {
                    GameCell ncell = Grid.getCell(this.row-1, this.col);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Down)
            {
                if (this.row < Grid.Rows - 1)
                {
                    GameCell ncell = Grid.getCell(this.row+1, this.col);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }
            return this; // if can not return next cell return its own reference
        }
        public int X { get => row; set => row = value; }
        public int Y { get => col; set => col = value; }
        public GameObject CurrentGameObject { get => currentGameObject; set => currentGameObject = value; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }
        public GameGrid Grid { get => grid; set => grid = value; }
    }
}
