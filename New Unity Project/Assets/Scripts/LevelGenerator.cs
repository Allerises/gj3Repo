using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject[] levels;
    private Transform camT;

    private int currentLevelNumber = 0, numLevels, spawnX;
    private float curY;

    void Start()
    {

        camT = GameObject.FindWithTag("MainCamera").GetComponent<Transform>();
        numLevels = levels.Length;

        spawnX = 0;
        curY = 5f;
    }

    void Update()
    {
        if (camT.position.x >= spawnX)
        {
            spawnX += 16;
            transform.position = new Vector3(spawnX, curY, 0f);
            int lvl = Random.Range(0, numLevels);
            Instantiate(levels[lvl], transform.position, Quaternion.identity);

            var cam = GameObject.FindWithTag("MainCamera").GetComponent<Transform>();

            switch (lvl)
            {
                case 1:
                    cam.position  += Vector3.up * 0.6f;
                    curY += 0.6f;
                    break;
                case 2:
                    cam.position += Vector3.down * 0.6f;
                    curY -= 0.6f;
                    break;
            }
        }
    }

}