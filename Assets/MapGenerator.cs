using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

	public int mapWidth;
	public int mapHeight;
	public float noise_scale;

	public bool autoUpdate;

	public void GenerateMap() {
		float[,] noise_map = NoiseMap.GenerateNoiseMap (mapWidth, mapHeight, noise_scale);
		MapDisplay display = FindObjectOfType<MapDisplay> ();
		display.DrawNoiseMap (noise_map);
	}

}
