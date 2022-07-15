using AK8PO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO
{
    internal class SecondRound
    {
        public Contestant? contestantA1;
        public Contestant? contestantB1;
        public Contestant? contestantC1;
        public Contestant? contestantD1;
        
        public Contestant? contestantE1;
        public Contestant? contestantF1;
        public Contestant? contestantG1;
        public Contestant? contestantH1;

        public Contestant? contestantA2;
        public Contestant? contestantB2;
        public Contestant? contestantC2;
        public Contestant? contestantD2;

        public Contestant? contestantE2;
        public Contestant? contestantF2;
        public Contestant? contestantG2;
        public Contestant? contestantH2;

        public SecondRound(List<FirstRoundGroup> groups)
        {
            contestantA1 = groups[0].getWinner();
            contestantB1 = groups[1].getWinner();
            contestantC1 = groups[2].getWinner();
            contestantD1 = groups[3].getWinner();
            contestantE1 = groups[4].getWinner();
            contestantF1 = groups[5].getWinner();
            contestantG1 = groups[6].getWinner();
            contestantH1 = groups[7].getWinner();

            contestantA2 = groups[0].getSecond();
            contestantB2 = groups[1].getSecond();
            contestantC2 = groups[2].getSecond();
            contestantD2 = groups[3].getSecond();
            contestantE2 = groups[4].getSecond();
            contestantF2 = groups[5].getSecond();
            contestantG2 = groups[6].getSecond();
            contestantH2 = groups[7].getSecond();
        }
    }
}
