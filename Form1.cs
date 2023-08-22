using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacMan.GameGL;
using EZInput;
using PacManGUI.GameGL;

namespace PacManGUI
{
    public partial class Form1 : Form
    {
        GameGrid grid;
        int score = 0;
        int enemyBulletDelay = 0;
        //private Label lblScore;
        GamePacManPlayer pacman;
        HorizontalGhost HGhost;
        VerticalGhost VGhost;
        RandomGhost RGhost;
        List<Ghost> ghostlist = new List<Ghost>();
        List<Bullets> Playerbullets = new List<Bullets>();
        List<Bullets> EnemyBullets = new List<Bullets>();
        
       
        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze.txt", 15, 32);

            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            pacman = new GamePacManPlayer(pacManImage, startCell);

            Image HorizontalGhostImage = Game.getGameObjectImage('H');
            GameCell startGhost = grid.getCell(1, 3);
            HGhost = new HorizontalGhost(HorizontalGhostImage, startGhost);

            Image VerticalGhostImage = Game.getGameObjectImage('V');
            GameCell startverticalGhost = grid.getCell(13, 30);
            VGhost = new VerticalGhost(VerticalGhostImage, startverticalGhost);

            Image RandomGhostImage = Game.getGameObjectImage('R');
            GameCell startRandomGhost = grid.getCell(3, 25);
            RGhost = new RandomGhost(RandomGhostImage, startRandomGhost);

            ghostlist.Add(HGhost);
            ghostlist.Add(VGhost);
            ghostlist.Add(RGhost);
            printMaze(grid);
            
        }



        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
               
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);          
            //        printCell(cell);
                }

            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }
     

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            
            if(Keyboard.IsKeyPressed(Key.LeftArrow)) {

                GameCell nextcell = pacman.move(GameDirection.Left);
                PacmanCollision(nextcell);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                GameCell nextcell = pacman.move(GameDirection.Right);
                PacmanCollision(nextcell);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                GameCell nextcell = pacman.move(GameDirection.Up);
                PacmanCollision(nextcell);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow)){
                GameCell nextcell = pacman.move(GameDirection.Down);
                PacmanCollision(nextcell);
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                IncreseScore();
                GeneratePlayerBullet();
            }
            foreach (var g in ghostlist)
            {
                GameCell cell = g.Move();
                if (CollisionDetection.PlayerDetection(cell))
                {
                    DecreasePlayerHealth(10);
                }
                
            }
            if (BarHorizontalEnemyHealth.Value <= 0)
            {
                HGhost.CurrentCell.setGameObject(Game.getBlankGameObject());
                HGhost.CurrentCell.CurrentGameObject.GameObjectType = GameObjectType.NONE;
                ghostlist.Remove(HGhost);
            }
            if (BarVerticalEnemyHealth.Value <= 0)
            {
                VGhost.CurrentCell.setGameObject(Game.getBlankGameObject());
                VGhost.CurrentCell.CurrentGameObject.GameObjectType = GameObjectType.NONE;
                ghostlist.Remove(VGhost);
            }
            if (BarRandomEnemyHealth.Value <= 0)
            {
                RGhost.CurrentCell.setGameObject(Game.getBlankGameObject());
                RGhost.CurrentCell.CurrentGameObject.GameObjectType = GameObjectType.NONE;
                ghostlist.Remove(RGhost);
            }
            if (enemyBulletDelay == 10)
            {
                if (BarHorizontalEnemyHealth.Value > 0)
                {
                    GenerateHorizontalEnemyBullet();
                }
                if (BarVerticalEnemyHealth.Value > 0)
                {
                    GenerateVerticalEnemyBullet();
                }
                enemyBulletDelay = 0;
            }
            enemyBulletDelay++;
            MovePlayerBullets();
            MoveEnemyBullets();
            GameOver();
            YouWOn();


        }
        public void YouWOn()
        {
            if(BarHorizontalEnemyHealth.Value <= 0 && BarRandomEnemyHealth.Value <= 0 && BarVerticalEnemyHealth.Value <= 0)
            {
                gameLoop.Enabled = false;
                this.Hide();
                Form youwon = new Youwon();
                youwon.ShowDialog();
            }
        }
        public void GeneratePlayerBullet()
        {
            Image bImage = Game.getGameObjectImage('B');
            GameCell bCell = grid.getCell(pacman.CurrentCell.X - 1, pacman.CurrentCell.Y);
            Bullets bullet = new Bullets(GameObjectType.BULLET, bImage, bCell, GameDirection.Up);
            Playerbullets.Add(bullet);

        }

        public void GenerateVerticalEnemyBullet()
        {
            Image bImage = Game.getGameObjectImage('l');
            GameCell bCell = grid.getCell(VGhost.CurrentCell.X, VGhost.CurrentCell.Y - 1);
            Bullets bullet = new Bullets(GameObjectType.BULLET, bImage, bCell, GameDirection.Left);
            EnemyBullets.Add(bullet);
        }
        public void GenerateHorizontalEnemyBullet()
        {
            Image bImage = Game.getGameObjectImage('i');
            GameCell bCell = grid.getCell(HGhost.CurrentCell.X + 1, HGhost.CurrentCell.Y);
            Bullets bullet = new Bullets(GameObjectType.BULLET, bImage, bCell, GameDirection.Down);
            EnemyBullets.Add(bullet);
        }
        
        

        public void PacmanCollision(GameCell cell)
        {
            if (CollisionDetection.EnemyDetection(cell))
            {
                DecreasePlayerHealth(10);
            }
        }

        private void DecreasePlayerHealth(int value)
        {
            if (BarTankHealth.Value > 0)
            {
                BarTankHealth.Value -= value;
            }
        }

        private void GameOver()
        {
            if (BarTankHealth.Value <= 0)
            {
                gameLoop.Enabled = false;
                this.Hide();
                Form gameover = new YouLose();
                gameover.ShowDialog();
                

            }

        }
        private void IncreseScore()
        {
            score++;
            lblScore.Text = "Score: " + score.ToString();
            Controls.Add(lblScore);
        }
        private void MovePlayerBullets()
        {
            for (int i = 0; i < Playerbullets.Count; i++)
            {
                GameCell cell = Playerbullets[i].Move();
                if (BarHorizontalEnemyHealth.Value > 0)
                {
                    if (CollisionDetection.EnemyDetection(cell, HGhost))
                    {
                        IncreseScore();
                        BarHorizontalEnemyHealth.Value -= 50;
                        Playerbullets[i].CurrentCell.setGameObject(Game.getBlankGameObject());
                        Playerbullets.Remove(Playerbullets[i]);
                    }
                }
                if (BarVerticalEnemyHealth.Value > 0)
                {
                    if (CollisionDetection.EnemyDetection(cell, VGhost))
                    {
                        IncreseScore();
                        BarVerticalEnemyHealth.Value -= 50;
                        Playerbullets[i].CurrentCell.setGameObject(Game.getBlankGameObject());
                        Playerbullets.Remove(Playerbullets[i]);
                        
                    }
                }
                if (BarRandomEnemyHealth.Value > 0)
                {
                    if (CollisionDetection.EnemyDetection(cell, RGhost))
                    {
                        IncreseScore();
                        BarRandomEnemyHealth.Value -= 50;
                        Playerbullets[i].CurrentCell.setGameObject(Game.getBlankGameObject());
                        Playerbullets.Remove(Playerbullets[i]);
                    }
                }
                if (CollisionDetection.WallDetection(cell))
                {
                    Playerbullets.Remove(Playerbullets[i]);
                }
            }
        }

        private void MoveEnemyBullets()
        {
            for (int i = 0; i < EnemyBullets.Count; i++)
            {
                GameCell cell = EnemyBullets[i].Move();
                if (CollisionDetection.PlayerDetection(cell))
                {
                    DecreasePlayerHealth(30);
                    EnemyBullets.Remove(EnemyBullets[i]);
                }
                else if (CollisionDetection.WallDetection(cell))
                {
                    EnemyBullets.Remove(EnemyBullets[i]);
                }
            }
        }
    }
}
