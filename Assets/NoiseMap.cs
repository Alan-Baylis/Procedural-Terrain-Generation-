using UnityEngine;
using System.Collections;

public static class NoiseMap {

	public static float[,] GenerateNoiseMap(int width, int height, float scale) {
		float[,] noise_map = new float[width, height];

		for (int i = 0; i < width; i++) {
			for (int j = 0; j < height; j++) {
				float x = i / scale;
				float y = j / scale;
				noise_map[i, j] = Mathf.PerlinNoise(x, y);
			}
		}

		return noise_map;
	}
}
