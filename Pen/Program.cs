using System.Drawing;

namespace Pen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creatting pens!!\n");
            // Create array of pen configurations
            var penConfigs = new List<Pen>{
                new BallPen(.5d, Color.Green, new RotateOpen()),
                new GelPen(.7d, Color.Red, new ClickOpen()),
                new FountainPen(.3d, Color.Blue, new CapOpen())
            };

            foreach (var penConfig in penConfigs)
            {
                penConfig.Open();
                Console.WriteLine(penConfig.Write());
                penConfig.Close();
                Console.WriteLine();
            }
        }
    }
}
