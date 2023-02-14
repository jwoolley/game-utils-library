using UnityEngine;

namespace Assets.Scripts.Assets {
    public class SpriteAsset {

        private readonly string path;

        public SpriteAsset(string path) {
            this.path = path;
        }

        private Sprite _sprite;

        public Sprite sprite {
            get {
                Debug.Log("SpriteAsset :: Getting sprite: " + this.path);
                if (_sprite == null) {
                    Debug.Log("SpriteAsset :: Sprite not found. Loading sprite");

                    _sprite = GameAssets.loadSprite(path);
                    Debug.Log("SpriteAsset :: Loaded sprite: " + _sprite);

                }

                return _sprite;
            }
        }
    }
}