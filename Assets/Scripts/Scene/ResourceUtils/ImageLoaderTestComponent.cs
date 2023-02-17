using UnityEngine;
using UnityEngine.UI;

public class ImageLoaderTestComponent : MonoBehaviour {    

  // TODO:  designate a directory inside the project for sample data
  //        and move this file there.
  //        specify its relative path and determine how to resolve
  //        it to an absolute ("file://") path in unity, so this is portable.
  readonly static string EXAMPLE_IMG_PATH = "C:/Users/harsh/Desktop/yassified.jpg";
  [SerializeField]
  string imagePath = EXAMPLE_IMG_PATH;

  [SerializeField]
  int pixelsPerUnit = 100;

  [SerializeField]
  Image imageComponent;

  public void onClick() {
    tryLoadImage();
  }

  private void tryLoadImage() {
    ImageResourceUtils.DownloadImage(this, imagePath, texture => {
      Vector2 pivot = new Vector2(0.5f, 0.5f);
      Debug.Log("We got the texture: " + texture);
      imageComponent.sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height),
        pivot, pixelsPerUnit);
    });
  }
}
