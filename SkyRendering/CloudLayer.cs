using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Sky
{
    public class CloudLayer
    {
        public List<Cloud> Clouds;

        public CloudLayer()
        {
            Clouds = new List<Cloud>();

            Cloud c = new Cloud();
            c.Spheres.Add(new Sphere(new Vector3(0.6f), 0.1f));
            c.Spheres.Add(new Sphere(new Vector3(0.8f, 0.7f, 0.6f), 0.1f));
            c.Spheres.Add(new Sphere(new Vector3(-2.0f, 1.0f, -2.0f), 0.2f));
            c.Spheres.Add(new Sphere(new Vector3(-2.2f, 1.05f, -1.95f), 0.2f));
            c.Spheres.Add(new Sphere(new Vector3(-1.95f, 0.99f, -2.01f), 0.2f));
            c.Spheres.Add(new Sphere(new Vector3(-1.9f, 1.1f, -2.01f), 0.2f));
            Clouds.Add(c);
        }

        public void generateClouds(int n)
        {
            while (Clouds.Count < n)
            {
                Random rand = new Random();
                double theta = 90.0 - 30.0 * rand.NextDouble();
                double phi = 360.0 * rand.NextDouble();
                float x = (float) (Math.Cos(theta) * Math.Cos(phi));
                float z = (float) (Math.Cos(theta) * Math.Sin(phi));
                float y = (float) (1.0 + rand.NextDouble());
                Cloud c = new Cloud();
                c.Spheres.Add(new Sphere(new Vector3(x, y, z), 0.2f));
                c.Spheres.Add(new Sphere(new Vector3(x-0.1f, y, z+0.1f), 0.2f));
                c.Spheres.Add(new Sphere(new Vector3(x-0.2f, y, z-0.1f), 0.2f));
                Clouds.Add(c);
            }

            while (Clouds.Count > n)
            {
                Clouds.RemoveAt(Clouds.Count - 1);
            }
        }
    }
}
