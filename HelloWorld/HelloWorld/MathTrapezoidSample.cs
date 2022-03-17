using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class MathTrapezoidSample
    {
        private double m_longBase;
        private double m_shortBase;
        private double m_leftLeg;
        private double m_rightLeg;

        public MathTrapezoidSample(double longbase, double shortbase, double leftLeg, double rightLeg)
        {
            m_longBase = Math.Abs(longbase);
            m_shortBase = Math.Abs(shortbase);
            m_leftLeg = Math.Abs(leftLeg);
            m_rightLeg = Math.Abs(rightLeg);
        }

        private double GetRightSmallBase()
        {
            return (Math.Pow(m_rightLeg, 2.0) - Math.Pow(m_leftLeg, 2.0) + Math.Pow(m_longBase, 2.0) + Math.Pow(m_shortBase, 2.0) - 2 * m_shortBase * m_longBase) / (2 * (m_longBase - m_shortBase));
        }

        public double GetHeight()
        {
            double x = GetRightSmallBase();
            return Math.Sqrt(Math.Pow(m_rightLeg, 2.0) - Math.Pow(x, 2.0));
        }

        public double GetSquare()
        {
            return GetHeight() * m_longBase / 2.0;
        }

        public double GetLeftBaseRadianAngle()
        {
            double sinX = GetHeight() / m_leftLeg;
            return Math.Round(Math.Asin(sinX), 2);
        }

        public double GetRightBaseRadianAngle()
        {
            double x = GetRightSmallBase();
            double cosX = (Math.Pow(m_rightLeg, 2.0) + Math.Pow(x, 2.0) - Math.Pow(GetHeight(), 2.0)) / (2 * x * m_rightLeg);
            return Math.Round(Math.Acos(cosX), 2);
        }

        public double GetLeftBaseDegreeAngle()
        {
            double x = GetLeftBaseRadianAngle() * 180 / Math.PI;
            return Math.Round(x, 2);
        }

        public double GetRightBaseDegreeAngle()
        {
            double x = GetRightBaseRadianAngle() * 180 / Math.PI;
            return Math.Round(x, 2);
        }
    }
}
