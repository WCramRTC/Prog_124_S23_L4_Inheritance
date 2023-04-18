using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L4_Inheritance
{
    internal class Player
    {
        int _level;
        string _name;
        Job _job;

        public Player(int level, string name, Job job)
        {
            _level = level;
            _name = name;
            _job = job;
        }

        public void Attack()
        {
            _job.Attack();
        }
    }
}
