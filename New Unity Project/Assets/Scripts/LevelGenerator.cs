using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public Level levelOne;
	public Level levelTwo;
	public Level levelThree;
	public Level levelFour;
	public Level levelFive;
	public int levelSize = 30;
	public int originX = 0;
	private List<GameObject> currentLevel = new List<GameObject>();
	private int currentLevelNumber = 0;
	void Start () {
		if (!(levelOne != null && levelTwo != null && levelThree != null && levelFour != null && levelFive != null)) {
			Debug.Log ("All of the level prefabs must be set through the LevelManager GameObject!");
			Application.Quit ();
		}
		LoadNextLevel();
	}

	void Update () {
		
	}

	private void LoadNextLevel() {
		float distance = originX;
		for (int i=0; i < levelSize; i++) {
			int selected = Random.Range (0, 6);
			if (selected == 1) {
				load (levelOne, distance);
			} else if (selected == 2) {
				load (levelTwo, distance);
			} else if (selected == 3) {
				load (levelThree, distance);
			} else if (selected == 4) {
				load (levelFour, distance);
			} else if (selected == 5) {
				load (levelFive, distance);
			}
		}
	}

	private void load(Level level, float distance) {
		GameObject newLevel = level.Generate (distance);
		distance += newLevel.transform.localScale.x;
		currentLevel.Add (newLevel);
	}

	public void resetLevel() {
		for (int i = 0; i < currentLevel.Length; i++) {
			Destroy (currentLevel [i]);
		}
	}
}
