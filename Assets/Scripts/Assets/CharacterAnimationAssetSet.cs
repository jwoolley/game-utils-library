using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Assets.Scripts.Assets {
    public class CharacterAnimationAssetSet {
        private const string ANIMATION_FOLDER_PATH = "Animations/Classes";

        // STATIC CLASS DATA
        public enum CHARACTER_ANIMATION_TYPES {
            IDLE
        };

        static private Dictionary<CHARACTER_ANIMATION_TYPES, string> filenames = new Dictionary<CHARACTER_ANIMATION_TYPES, string>();

        static CharacterAnimationAssetSet() {
            filenames.Add(CHARACTER_ANIMATION_TYPES.IDLE, "Idle");
        }

        // CLASS INSTANCE
        private readonly string folderName;
        private AnimationAsset _idle;

        public CharacterAnimationAssetSet(string folderName) {
            this.folderName = folderName;
        }

        public AnimationAsset idle {
            get {
                if (_idle == null) {
                    _idle = new AnimationAsset(ANIMATION_FOLDER_PATH + "/" + this.folderName + "/" + filenames[CHARACTER_ANIMATION_TYPES.IDLE]);
                }
                return _idle;
            }
        }
    }
}