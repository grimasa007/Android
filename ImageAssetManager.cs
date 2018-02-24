using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Tester.Helpers
{
    public static class ImageAssetManager
    {
        static Dictionary<string, Drawable> cache = new Dictionary<string, Drawable>();

        public static Drawable Get(Activity context, string url)
        {
            if (!cache.ContainsKey(url))
            {
                Stream stream = context.Assets.Open(url);
                var drawable = Drawable.CreateFromStream(stream, null);
                cache.Add(url, drawable);
            }

            return cache[url];
        }
    }
}
