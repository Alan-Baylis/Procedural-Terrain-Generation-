using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof (MapGenerator))]
public class MapGeneratorEditor : Editor {

	public override void OnInspectorGUI() {
		MapGenerator map_gen = (MapGenerator) target;

		if (DrawDefaultInspector ()) {
			if (map_gen.autoUpdate) {
				map_gen.GenerateMap ();
			}
		}

		if (GUILayout.Button ("Generate Map")) {
			map_gen.GenerateMap ();
		}
	}

}
