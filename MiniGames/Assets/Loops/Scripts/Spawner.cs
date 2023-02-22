using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public int spawnCount = 100;
    public float spawnOffset = 1f;

    private void Start() {
        if (spawnPrefab != null) {
            SpawnEnemies();
        } else {
            Debug.LogError("prefab missing!");
        }
    }

    void SpawnEnemies() {
        for (int i = 0; i < spawnCount; i++) {

            float xPos = i * spawnOffset;
            Vector3 spawnPos = new Vector3(xPos, 0, 0);

            Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
        }
    }
}
