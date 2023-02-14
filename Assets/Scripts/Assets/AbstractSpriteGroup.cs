using System;
using System.Collections.Generic;
namespace Assets.Scripts.Assets {
    public class AbstractSpriteGroup : Dictionary<string, SpriteAsset> {
        private readonly string folderPath;

        public AbstractSpriteGroup(string folderPath) {
            this.folderPath = folderPath;
        }

        public void Add(string key, string filename) {
            this.Add(key, new SpriteAsset(this.folderPath + "/" + filename));
        }

        public static implicit operator Dictionary<object, object>(AbstractSpriteGroup v) {
            throw new NotImplementedException();
        }
    }
}