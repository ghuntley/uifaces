using System;
using Newtonsoft.Json;

namespace UIFaces
{
    public class Face
    {
        public string Username { get; set; }

        [JsonProperty(PropertyName = "image_urls")]
        public ImageUrls ImageUrls { get; set; }
    }

    public class ImageUrls
    {
        public Uri Epic { get; set; }
        public Uri Bigger { get; set; }
        public Uri Normal { get; set; }
        public Uri Mini { get; set; }
    }
}