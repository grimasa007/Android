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
