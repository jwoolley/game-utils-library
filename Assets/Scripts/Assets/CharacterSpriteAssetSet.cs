using System.Collections.Generic;

namespace Assets.Scripts.Assets {
    public class CharacterSpriteAssetSet {
        private const string SPRITE_FOLDER_PATH = "Sprites/Characters";

        // STATIC CLASS DATA
        public enum CHARACTER_SPRITE_TYPES {
            IDLE
        };

        static private Dictionary<CHARACTER_SPRITE_TYPES, string> filenames = new Dictionary<CHARACTER_SPRITE_TYPES, string>();

        static CharacterSpriteAssetSet() {
            filenames.Add(CHARACTER_SPRITE_TYPES.IDLE, "Idle");
        }

        // CLASS INSTANCE
        private readonly string folderName;
        private SpriteAsset _idle;

        public CharacterSpriteAssetSet(string folderName) {
            this.folderName = folderName;
        }

        public SpriteAsset idle {
            get {
                if (_idle == null) {
                    _idle = new SpriteAsset(SPRITE_FOLDER_PATH + "/" + this.folderName + "/" + filenames[CHARACTER_SPRITE_TYPES.IDLE]);
                }
                return _idle;
            }
        }
    }
}