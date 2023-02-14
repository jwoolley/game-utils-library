using System.Collections.Generic;

namespace Assets.Scripts.Assets {
    public class SpriteAssets {
        //private static string STATUS_SPRITE_FOLDER_PATH = "Sprites/Status";
        private static string STATUS_SPRITE_FOLDER_PATH = "Ui/Battle/StatusIcons";

        public readonly Dictionary<string, CharacterSpriteAssetSet> enemies = new Dictionary<string, CharacterSpriteAssetSet>();
        public readonly AbstractSpriteGroup statuses = new AbstractSpriteGroup(STATUS_SPRITE_FOLDER_PATH);
    }
}