using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    private GameObject[] levels;
    private Transform camT;

    private int currentLevelNumber = 0, numLevels, spawnX;

    void Start()
    {

        camT = GameObject.FindWithTag("MainCamera").GetComponent<Transform>();

        levels = GameObject.FindGameObjectsWithTag("Level");
        numLevels = levels.Length;
        spawnX = 0;
    }

    void Update()
    {
        if (camT.position.x >= spawnX)
        {
            spawnX += 16;
            transform.position = new Vector3(spawnX, 5f, 0f);

            Instantiate(levels[0], transform.position, Quaternion.identity);
        }
    }

}