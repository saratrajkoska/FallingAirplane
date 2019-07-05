using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingAirplane
{
    
  public  class Airplane
    {
        public int RADIUS { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public Color color { get; set; }

        public double Velocity { get; set; }
        public static int[] Angle = { 60, 270 };
        Random r;

        public float velocityX { get; set; }
        public float velocityY { get; set; }


        public Airplane()
        {

        }
        public Airplane(int ra, float x, float y, float v, Color c)
        {
            RADIUS = ra;
            X = x;
            Y = y;
            color = c;
            Velocity = v;

            r = new Random();

            velocityX = (float)(Math.Cos(Angle[r.Next(0, 2)]) * Velocity);
            velocityY = (float)(Math.Sin(Angle[r.Next(0, 2)]) * Velocity);
        }
        public Airplane(int ra, int angle, int Velocity, int x, int y, Color c)
        {
            RADIUS = ra;
            velocityX = (float)(Math.Cos(angle) * Velocity);
            velocityY = (float)(Math.Sin(angle) * Velocity);
            X = x;
            Y = y;
            color = c;
        }

        /*public Point Move(float x, float y, int left, int top, int width, int height)
        {

                 return MoveClicked(left, top, width, height);
             
        }

        public Point MoveDown(float height)
        {
            
                Y = Y + 6;
            return new Point((int)X, (int)Y);
            

        }
       /*public bool gameOver(float height)
        {
            if (color == Color.Red && Y > 305 && RADIUS != 35)
                return true;
            return false;
        }
        public Point MoveClicked(int left, int top, int width, int height)
        {
            int nextX = (int)(X + velocityX);
            //int nextY = (int)(Y + velocityY);
            int lft = left + 50;
            int rgt = left + width - 50;
            int tp = top + 50;
            int btm = top + height - 50;

            if (nextX <= lft)
            {
                nextX = lft + (lft - nextX);
                velocityX = -velocityX;
            }
            if (nextX >= rgt)
            {
                nextX = rgt - (nextX - rgt);
                velocityX = -velocityX;

            }
            
            X = nextX;
            
            Y = Y-50;
            if(Y<=tp)
            {
                Y = tp;
            }
           
            return new Point(nextX, (int)Y);


            /*if (color != Color.Red || (color == Color.Red && RADIUS == 35))
            {
                if (nextY >= 308)
                {

                    velocityY = -velocityY;
                    nextY = (int)(nextY + velocityY);
                }
            }
            X = nextX;
            Y = Y-50;
            return new Point((int)X, (int)Y);
        }
        public bool touchesRight(Airplane airplane)
        {
            return (((X - airplane.X) * (X - airplane.X) + (Y - airplane.Y) * (Y - airplane.Y)) <= radius * radius);
        }
        public Point MoveUp()
        {
            if (Y - 15 > radius)
                Y = Y - 15;
            return new Point((int)X, (int)Y);

        }

        public void promeniRadius()
        {
            
        }
        public void promeniRadiusPlavo()
        {
            
        }*/

        public Point Move(float x, float y, int left, int top, int width, int height)
        {

                return MoveClicked(left, top, width, height);
            /*
            else
            {
                if (color == Color.Red)
                    return MoveDown(height);
                else
                    return MoveClicked(left, top, width, height);
            }*/
        }

        public bool isClicked(float x, float y)
        {
            return (((X - x) * (X - x) + (Y - y) * (Y - y)) <= RADIUS * RADIUS);
        }
        public Point MoveDown(float height)
        {
            if(Y+6<height)
                Y = Y + 6;
            
            return new Point((int)X, (int)Y);
            

        }
        public bool gameOver(float height)
        {
            if (color == Color.Red && Y > 305 && RADIUS != 35)
                return true;
            return false;
        }
        public Point MoveClicked(int left, int top, int width, int height)
        {
            Random r = new Random();

            int nextX = (int)(X + velocityX);
            int nextY = (int)(Y + velocityY);

            if (nextX <= RADIUS || nextX >= width - RADIUS)
            {
                velocityX = -velocityX;
                nextX = (int)(X + velocityX);
            }

            if (nextY <= RADIUS)
            {
                velocityY = -velocityY;
                nextY = (int)(this.Y + velocityY);
            }
            if (color != Color.Red || (color == Color.Red && RADIUS == 35))
            {
                if (nextY >= 308)
                {

                    velocityY = -velocityY;
                    nextY = (int)(nextY + velocityY);
                }
            }
            X = nextX;
            Y = nextY-50;
            return new Point((int)X, (int)Y);
        }
        /*public bool touchesRight(Ball b)
        {
            return (((X - b.X) * (X - b.X) + (Y - b.Y) * (Y - b.Y)) <= RADIUS * RADIUS);
        }*/
        public void MoveUp()
        {
            if (Y - 15 > RADIUS)
                Y = Y - 15;

        }
    }
}
