using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PacMan.GameGL
{
    public class Game
    {
        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, null);
            return blankGameObject;
        }
        public static GameObject getPlayerGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.PLAYER, PacManGUI.Properties.Resources.tankU);
            return blankGameObject;
        }

        public static GameObject getEnemyGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.ENEMY, PacManGUI.Properties.Resources.horizontalEnemy);
            return blankGameObject;
        }
        public static GameObject GetRewardObject()
        {
            GameObject reward = new GameObject(GameObjectType.REWARD, PacManGUI.Properties.Resources.pallet);
            return reward;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = null;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = PacManGUI.Properties.Resources.wall;
            }

            if (displayCharacter == '#')
            {
                img = PacManGUI.Properties.Resources.wall;
            }
            if(displayCharacter == 'B')
            {
                img = PacManGUI.Properties.Resources.tankbullet;
            }
            if (displayCharacter == 'q')
            {
                img = PacManGUI.Properties.Resources.randomenemybullet;
            }
            if (displayCharacter == 'i')
            {
                img = PacManGUI.Properties.Resources.horizontalEnemybullet;
            }
            if (displayCharacter == 'l')
            {
                img = PacManGUI.Properties.Resources.enemyverticalBullet;
            }
            if (displayCharacter == '.')
            {
                img = PacManGUI.Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p') {
                img = PacManGUI.Properties.Resources.tankU;
            }
            if(displayCharacter == 'H')
            {
                img = PacManGUI.Properties.Resources.horizontalEnemy;
            }
            if(displayCharacter == 'V')
            {
                img = PacManGUI.Properties.Resources.verticaltank;
            }
            if(displayCharacter == 'R')
            {
                img = PacManGUI.Properties.Resources.random;
            }
           

            return img;
        }
    }
}
