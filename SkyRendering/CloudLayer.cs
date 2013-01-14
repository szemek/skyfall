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
            Clouds.Add(c);
        }
    }
}
