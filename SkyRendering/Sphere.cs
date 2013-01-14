using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Sky
{
    public class Sphere
    {
        public Vector3 position;
        public float radius;

        public Sphere(Vector3 p, float r)
        {
            position = p;
            radius = r;
        }
    }
}
