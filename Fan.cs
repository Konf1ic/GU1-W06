using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GU1_W06
{
    public class Fan
    {
        // Số tốc độ
        const int SLOW = 1;
        const int MEDIUM = 2;
        const int FAST = 3;

        // Trường
        private int speed;
        private bool on;
        private double radius;
        private string color;

        // Getter và setter
        public int getSpeed()
        {
            return speed;
        }

        public void setSpeed(int speed)
        {
            if (speed >= SLOW && speed <= FAST)
            {
                this.speed = speed;
            }
        }

        public bool isOn()
        {
            return on;
        }

        public void setOn(bool on)
        {
            this.on = on;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
            }
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            if (color != null && color.Length > 0)
            {
                this.color = color;
            }
        }

        // Khởi tạo không tham số
        public Fan()
        {
            speed = SLOW;
            on = false;
            radius = 5;
            color = "blue";
        }

        // Phương thức ToString()
        public override string ToString()
        {
            string status;
            if (on)
            {
                status = "fan is on";
            }
            else
            {
                status = "fan is off";
            }
            return $"\nSpeed: {speed}\nColor: {color}\nRadius: {radius}\nStatus: {status}";
        }
    }
}