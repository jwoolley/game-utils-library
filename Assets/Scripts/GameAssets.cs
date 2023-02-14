using Assets.Scripts.Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour {

    // TODO: consider creating a GameAssets prefab hieararchy and bootstrapping intantiation of everything
    //       through this class. Character animations, enemy animations, backgrounds, etc. would all be
    //       contained under their own sub-prefabs (or sub-sub prefabs, etc.).
    //       This would be opaque to the game code--all references would still be through this class
    //       (possibly through a chain notation structure, e.g. GameAssets.Animations.Characters.FireShaman.Idle)

    private static GameAssets _instance;

    public static GameAssets instance {
        get {
            if (_instance == null) {
                _instance = initialize();
            }
            return _instance;
        }
    }

    private static GameAssets initialize() {
        GameAssets newGameAssets = loadPrefab("GameAssets").GetComponent<GameAssets>();

        newGameAssets.Animations = new AnimationAssets();
        newGameAssets.Sprites = new SpriteAssets();

        return newGameAssets;
    }

    public static GameObject loadPrefab(string pathOrPrefabName) {
        //Debug.Log("GameAssets::loadPrefab loading " + pathOrPrefabName);
        return (Instantiate(Resources.Load(pathOrPrefabName)) as GameObject);
    }

    public static Sprite loadSprite(string pathOrSpriteName) {
        Debug.Log("GameAssets::loadSprite loading " + pathOrSpriteName);
        return Resources.Load<Sprite>(pathOrSpriteName);
    }

    public static void registerCharacterAnimationIfNeeded(string id, CharacterAnimationAssetSet assetSet) {
        if (!GameAssets.instance.Animations.characters.ContainsKey(id)) {
            GameAssets.instance.Animations.characters.Add(id, assetSet);
        }
    }

    public static void registerEnemySpriteIfNeeded(string id, CharacterSpriteAssetSet assetSet) {
        if (!GameAssets.instance.Sprites.enemies.ContainsKey(id)) {
            GameAssets.instance.Sprites.enemies.Add(id, assetSet);
        }
    }

    public Transform cardTitlePopup;
    public Transform iconPopup;
    public Transform ItemInfoTooltip;
    public Transform HeroProgressInfoPanel;
    public AnimationAssets Animations;
    public SpriteAssets Sprites;
}