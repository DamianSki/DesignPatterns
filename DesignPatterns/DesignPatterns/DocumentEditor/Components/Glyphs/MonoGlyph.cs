﻿using DesignPatterns.DocumentEditor.Primitives;
using DesignPatterns.DocumentEditor.Primitives.Windows;
using DesignPatterns.Primitives.Drawing;
using System;
using System.Collections.Generic;

namespace DesignPatterns.DocumentEditor.Components.Glyphs
{
    class MonoGlyph : Glyph
    {
        IEnumerable<Glyph> glyphs;

        public override void Bounds(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }

        public override void Draw(Window window)
        {
            throw new NotImplementedException();
        }

        public override void Insert(Glyph glyph)
        {
            throw new NotImplementedException();
        }

        public override bool Intersects(Point point)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Glyph glyph)
        {
            throw new NotImplementedException();
        }
    }
}
