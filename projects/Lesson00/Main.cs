using Fusee.Engine;
using Fusee.Math;

namespace Examples.RocketGame.Lesson00
{
    public class RocketGame : RenderCanvas
    {
        // is called on startup
        public override void Init()
        {
            RC.ClearColor = new float4(1, 1, 1, 1);
        }

        // is called once a frame
        public override void RenderAFrame()
        {
            RC.Clear(ClearFlags.Color | ClearFlags.Depth);
            Present();
        }

        // is called when the window was resized
        public override void Resize()
        {
            RC.Viewport(0, 0, Width, Height);

            var aspectRatio = Width / (float)Height;
            RC.Projection = float4x4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspectRatio, 1, 10000);
        }

        public static void Main()
        {
            var app = new RocketGame();
            app.Run();
        }

    }
}
