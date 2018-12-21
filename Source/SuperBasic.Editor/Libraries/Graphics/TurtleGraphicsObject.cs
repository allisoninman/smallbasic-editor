﻿// <copyright file="TurtleGraphicsObject.cs" company="2018 Omar Tawfik">
// Copyright (c) 2018 Omar Tawfik. All rights reserved. Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

namespace SuperBasic.Editor.Libraries.Graphics
{
    using System.Collections.Generic;
    using SuperBasic.Editor.Components;
    using SuperBasic.Editor.Libraries.Utilities;

    internal sealed class TurtleGraphicsObject : BaseGraphicsObject
    {
        public TurtleGraphicsObject(GraphicsWindowStyles styles)
            : base(styles)
        {
        }

        public override void ComposeTree(TreeComposer composer)
        {
            composer.Element(
                name: "image",
                attributes: new Dictionary<string, string>
                {
                    { "href", $"Turtle.svg" },
                });
        }
    }
}
