using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO
{
    internal class FirstRoundGroup
    {
        private Contestant playerA;
        private Contestant playerB;
        private Contestant? playerC;

        private short playerAPoints = 0;
        private short playerBPoints = 0;
        private short playerCPoints = -1;

        public FirstRoundGroup(Contestant playerA, Contestant playerB)
        {
            this.playerA = playerA;
            this.playerB = playerB;
        }

        public void addThirdContestant(Contestant contestant)
        {
            this.playerC = contestant;
            this.playerCPoints = 0;
        }

       public Contestant? getWinner()
        {
            if ((playerAPoints > playerBPoints) && (playerAPoints > playerCPoints))
            { return playerA; };
            if ((playerBPoints > playerCPoints) && (playerBPoints > playerAPoints))
            { return playerB; };
            if ((playerCPoints > playerBPoints) && (playerCPoints > playerAPoints))
            { return playerC; };
            return null;
        }
        public Contestant? getSecond()
        {
            if ((playerAPoints > playerBPoints) && (playerAPoints < playerCPoints))
            { return playerA; };
            if ((playerAPoints > playerCPoints) && (playerAPoints < playerBPoints))
            { return playerA; };
            if ((playerBPoints > playerCPoints) && (playerBPoints < playerAPoints))
            { return playerB; };
            if ((playerBPoints > playerAPoints) && (playerBPoints < playerCPoints))
            { return playerB; };
            if ((playerCPoints > playerBPoints) && (playerCPoints < playerAPoints))
            { return playerC; };
            if ((playerCPoints > playerAPoints) && (playerCPoints < playerBPoints))
            { return playerC; };
            return null;
        }
        public void setContestantPoints(char playerCode, short points)
        {
            switch (playerCode)
            {
                case 'A':
                    playerAPoints = points;
                    break;
                case 'B':
                    playerBPoints = points;
                    break;
                case 'C':
                    if (playerC != null)
                        playerCPoints = points;
                    break;
                default:
                    break;
            }
        }
        public short getContestantPoints(char playerCode)
        {
            switch (playerCode)
            {
                case 'A':
                    return playerAPoints;
                case 'B':
                    return playerBPoints;
                case 'C':
                    return playerCPoints;
                default:
                    return -1;
            }
        }
        public string getContestantString(char playerCode)
        {
            switch (playerCode)
            {
                case 'A':
                    return playerA.ToString();
                case 'B':
                    return playerB.ToString();
                case 'C':
                    if (playerC != null)
                    {
                        return playerC.ToString();
                    }
                    else
                    {
                        return "";
                    }
                default:
                    return "";
            }
        }
    }
}
