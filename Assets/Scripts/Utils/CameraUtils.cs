using UnityEngine;

public static class CameraUtils {
    // TODO: make this method a helper on scene manager(s) so the  can be cached (per scene)
    public static Camera getCamera() {
        return Camera.main;
    }

    public static Vector3 transform3DPixelCoordinatesToWorldUnits(Vector3 vector3) {
        return getCamera().WorldToScreenPoint(vector3);
    }

    public static Vector2 transform3DPixelCoordinatesToWorldUnits(float x, float y, float z) {
        return transform3DPixelCoordinatesToWorldUnits(new Vector3(x, y, z));
    }

    public static Vector2 transform2DPixelCoordinatesToUnits(float x, float y) {
        return transform2DPixelCoordinatesToWorldUnits(new Vector2(x, y));
    }

    public static Vector2 transform2DPixelCoordinatesToWorldUnits(Vector2 vector2) {
        Vector3 transformedV3 = getCamera().WorldToScreenPoint(new Vector3(vector2.x, vector2.y, 0));
        return new Vector2(transformedV3.x, transformedV3.y);
    }

    public static float transformXPixelCoordinateToWorldUnits(float x) {
        return (transform3DPixelCoordinatesToWorldUnits(x, 0, 0)).x;
    }

    public static float transformYPixelCoordinateToWorldUnits(float y) {
        return (transform3DPixelCoordinatesToWorldUnits(0, y, 0)).y;
    }
}
