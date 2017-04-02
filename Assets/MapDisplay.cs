using UnityEngine;
using System.Collections;

public class MapDisplay : MonoBehaviour {

	public Renderer texture_renderer;

	public void DrawNoiseMap(float[,] noise_map) {
		int width  = noise_map.GetLength (0);
		int height = noise_map.GetLength (1);

		Texture2D texture = new Texture2D (width, height);
		Color[] colors = new Color[width * height];

		for (int y = 0; y < height; y++) {
			for (int x = 0; x < width; x++) {
				colors[y * width + x] = Color.Lerp (Color.black, Color.white, noise_map[x, y]);
			}
		}

		texture.SetPixels (colors);
		texture.Apply ();

		texture_renderer.sharedMaterial.mainTexture = texture;
		texture_renderer.transform.localScale = new Vector3 (width, 1, height);
	}
}
