﻿using BlazorComponent;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASA.Blazor
{
    public partial class MAvatar : BAvatar
    {
        [Parameter]
        public bool Left { get; set; }

        [Parameter]
        public bool Right { get; set; }

        [Parameter]
        public bool Rounded { get; set; }

        [Parameter]
        public bool Tile { get; set; }

        [Parameter]
        public StringNumber Size { get; set; } = 48;

        [Parameter]
        public StringNumber Height { get; set; }

        [Parameter]
        public StringNumber MaxHeight { get; set; }

        [Parameter]
        public StringNumber MaxWidth { get; set; }

        [Parameter]
        public StringNumber MinHeight { get; set; }

        [Parameter]
        public StringNumber MinWidth { get; set; }

        [Parameter]
        public StringNumber Width { get; set; }

        [Parameter]
        public string Color { get; set; }

        protected override void SetComponentClass()
        {
            var prefix = "m-avatar";

            CssProvider
                .Apply<BAvatar>(cssBuilder =>
                {
                    cssBuilder
                        .Add(prefix)
                        .AddIf($"{prefix}--left", () => Left)
                        .AddIf($"{prefix}--right", () => Right)
                        .AddIf("rounded", () => Rounded)
                        .AddIf("rounded-0", () => Tile)
                        .AddIf(Color, () => !string.IsNullOrEmpty(Color));
                }, styleBuilder =>
                {
                    styleBuilder
                        .AddHeight(Size)
                        .AddMinWidth(Size)
                        .AddWidth(Size)
                        .AddHeight(Height)
                        .AddWidth(Width)
                        .AddMinWidth(MinWidth)
                        .AddMaxWidth(MaxWidth)
                        .AddMinHeight(MinHeight)
                        .AddMaxHeight(MaxHeight);
                });
        }
    }
}
