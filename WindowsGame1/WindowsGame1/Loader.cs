using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace WindowsGame1
{
    class Loader
    {
        public Texture2D load(ContentManager Content)
        {
            return Content.Load<Texture2D>("M484SpaceSoldier");
        }
    }
}
