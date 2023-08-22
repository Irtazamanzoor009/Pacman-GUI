using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGUI.GameGL
{
    internal class CollisionDetection
    {
        public static bool EnemyDetection(GameCell cell)
        {
            if (cell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                return true;
            }
            return false;
        }

        public static bool EnemyDetection(GameCell cell, GameObject obj1)
        {
            if (obj1.CurrentCell.X == cell.X && obj1.CurrentCell.Y == cell.Y)
            {
                return true;
            }
            return false;
        }
        public static bool WallDetection(GameCell cell)
        {
            if (cell.CurrentGameObject.GameObjectType == GameObjectType.WALL)
            {
                return true;
            }
            return false;
        }
        public static bool PlayerDetection(GameCell cell)
        {
            if (cell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                return true;
            }
            return false;
        }
    }
}
