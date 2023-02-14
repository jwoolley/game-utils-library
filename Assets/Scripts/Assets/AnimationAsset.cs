using UnityEngine;

namespace Assets.Scripts.Assets {
    public class AnimationAsset {

        private readonly string path;

        public AnimationAsset(string path) {
            this.path = path;
        }

        private GameObject _animation;

        public GameObject animation {
            get {
                if (_animation == null) {
                    _animation = GameAssets.loadPrefab(path);
                }
                return _animation;
            }
        }
    }
}