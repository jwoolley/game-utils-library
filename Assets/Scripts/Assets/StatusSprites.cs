using System.Collections.Generic;
namespace Assets.Scripts.Assets {
    public class StatusSprites {
        private const string SPRITE_FOLDER_PATH = "Sprites/Status";
        public readonly Dictionary<string, SpriteAsset> statuses = new Dictionary<string, SpriteAsset>();
    }
}