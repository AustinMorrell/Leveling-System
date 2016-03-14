using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leveling_System
{
    class Player : ILevelable
    {
        List<double> m_Curve = new List<double>();
        private int m_Level = 1;
        private double m_EXP = 0;

        public double EXP
        {
            get
            {
                return m_EXP;
            }

            set
            {
                m_EXP = value;
            }
        }

        public int Level
        {
            get
            {
                return m_Level;
            }

            set
            {
                m_Level = value;
            }
        }

        public List<double> Curve
        {
            get
            {
                return m_Curve;
            }

            set
            {
                m_Curve = value;
            }
        }

        public void LevelCurve()
        {
            double TempEXPNumber;
            for (int i = 1; i < 100; i++)
            {
                TempEXPNumber = Math.Pow(i, 2);
                m_Curve[i] = TempEXPNumber;
            }
        }
    }
}
