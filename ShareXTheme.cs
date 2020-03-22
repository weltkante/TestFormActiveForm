﻿namespace TestFormActiveForm
{
    using System.Collections.Generic;
    using System.Drawing;

    public class ShareXTheme
    {
        public ShareXTheme()
        {
        }

        public string Name { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color BackgroundColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color LightBackgroundColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color DarkBackgroundColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color TextColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color BorderColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color CheckerColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color CheckerColor2 { get; set; }

        public int CheckerSize { get; set; } = 15;

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color LinkColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color MenuHighlightColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color MenuHighlightBorderColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color MenuBorderColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color MenuCheckBackgroundColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color SeparatorLightColor { get; set; }

        // [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        // [TypeConverter(typeof(MyColorConverter))]
        public Color SeparatorDarkColor { get; set; }

        public static ShareXTheme GetDarkTheme()
            => new ShareXTheme()
            {
                Name = "Dark",
                BackgroundColor = Color.FromArgb(42, 47, 56),
                LightBackgroundColor = Color.FromArgb(52, 57, 65),
                DarkBackgroundColor = Color.FromArgb(28, 32, 38),
                TextColor = Color.FromArgb(235, 235, 235),
                BorderColor = Color.FromArgb(28, 32, 38),
                CheckerColor = Color.FromArgb(60, 60, 60),
                CheckerColor2 = Color.FromArgb(50, 50, 50),
                CheckerSize = 15,
                LinkColor = Color.FromArgb(166, 212, 255),
                MenuHighlightColor = Color.FromArgb(30, 34, 40),
                MenuHighlightBorderColor = Color.FromArgb(116, 129, 152),
                MenuBorderColor = Color.FromArgb(22, 26, 31),
                MenuCheckBackgroundColor = Color.FromArgb(56, 64, 75),
                SeparatorLightColor = Color.FromArgb(56, 64, 75),
                SeparatorDarkColor = Color.FromArgb(22, 26, 31),
            };

        public static ShareXTheme GetLightTheme()
            => new ShareXTheme()
            {
                Name = "Light",
                BackgroundColor = Color.FromArgb(242, 242, 242),
                LightBackgroundColor = Color.FromArgb(247, 247, 247),
                DarkBackgroundColor = Color.FromArgb(235, 235, 235),
                TextColor = Color.FromArgb(69, 69, 69),
                BorderColor = Color.FromArgb(201, 201, 201),
                CheckerColor = Color.FromArgb(60, 60, 60),
                CheckerColor2 = Color.FromArgb(50, 50, 50),
                CheckerSize = 15,
                LinkColor = Color.FromArgb(166, 212, 255),
                MenuHighlightColor = Color.FromArgb(247, 247, 247),
                MenuHighlightBorderColor = Color.FromArgb(96, 143, 226),
                MenuBorderColor = Color.FromArgb(201, 201, 201),
                MenuCheckBackgroundColor = Color.FromArgb(225, 233, 244),
                SeparatorLightColor = Color.FromArgb(253, 253, 253),
                SeparatorDarkColor = Color.FromArgb(189, 189, 189),
            };

        public static ShareXTheme GetPinkTheme()
            => new ShareXTheme()
            {
                Name = "Pink",
                BackgroundColor = Color.HotPink,
                LightBackgroundColor = Color.LightPink,

                // DarkBackgroundColor = Color.DarkPink,
                TextColor = Color.Black,

                // BorderColor = Color.DarkPink,
                // CheckerColor = ???
                // CheckerColor2 = ???
                CheckerSize = 15,

                // LinkColor = ???
                MenuHighlightColor = Color.LightPink,

                // MenuHighlightBorderColor = ???,
                // MenuBorderColor = Color.DarkPink,
                // MenuCheckBackgroundColor = ???,
                // SeparatorLightColor = ???,
                // SeparatorDarkColor = ???,
            };

        public static ShareXTheme GetPurpleTheme()
            => new ShareXTheme()
            {
                Name = "Purple",
            };

        public static List<ShareXTheme> GetPresets()
            => new List<ShareXTheme>() { GetDarkTheme(), GetLightTheme(), GetPinkTheme(), GetPurpleTheme() };

        public override string ToString()
            => this.Name;
    }
}
