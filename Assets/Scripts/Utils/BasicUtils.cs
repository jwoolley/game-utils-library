using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BasicUtils {
    public static int calculateComputedIntValue(int baseValue, float multiplier) {
        return (int)Math.Floor(baseValue * multiplier);
    }
    public static int calculateComputedPercentIntValue(int baseValue, int percent) {
        return (int)Math.Floor(baseValue * percent/100.0f);
    }
}
