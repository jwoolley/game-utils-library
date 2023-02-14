using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorUtils {
    public static readonly Color DEFAULT_COLOR = Color.white;
    public static Color colorFromHexValue(string hexValue) {
       Color color;
        if (ColorUtility.TryParseHtmlString(hexValue, out color)) {
            return color;
        } else if (!hexValue.StartsWith("#") && ColorUtility.TryParseHtmlString("#" + hexValue, out color)) {
            return color;
        } else {
            return DEFAULT_COLOR;
        }
    }
}
