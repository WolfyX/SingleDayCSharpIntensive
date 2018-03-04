using Microsoft.SmallBasic.Library;

namespace SingleDayCSharpIntensive
{
    public class PictureWriter
    {
        public void Move()
        {
            Turtle.Speed = 6;
            int add = 20;
            while (true)
            {
                Turtle.Move(20);
                Turtle.Angle = (Turtle.Angle + add);
                add++;
                add %= 30;
            }
        }
    }
}
