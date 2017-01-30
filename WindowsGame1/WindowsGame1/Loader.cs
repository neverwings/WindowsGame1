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
        public static void load(List<Texture2D>  myTextures, ContentManager Content)
        {
            myTextures.Add(Content.Load<Texture2D>("Jump"));
        }
    }
}
