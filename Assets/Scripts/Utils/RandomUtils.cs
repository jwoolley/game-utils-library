using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class RandomUtils {
	// TODO: use seed to initialize
	// TODO: consider defining multiple randoms for different cases (lootRandom, monsterRandom, etc.)
	public static readonly System.Random random = new System.Random();

	public static List<T> ShuffleList<T>(List<T> list) {
		return list.OrderBy(e => random.Next()).ToList();
	}

	public static T RandomElement<T>(List<T> list) {
		if (list.Count > 0) {
			List<T> tempList = new List<T>(list);
			tempList = tempList.OrderBy(e => random.Next()).ToList();
			return tempList[0];
		}
		return default;
	}

	public static bool coinFlip() {
		return randomBool();
	}

	public static bool randomBool(float chanceOfSuccess=0.5f) {
		return random.NextDouble() < Mathf.Clamp(chanceOfSuccess, 0f, 1.0f);
	}
}