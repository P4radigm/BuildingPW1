using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    private void Start()
    {
        spawnSmth(3, 13);
    }

    void spawnSmth(int currentKey, int kindOfKey)
    {
        whatToSpawnClone[currentKey] = Instantiate(whatToSpawnPrefab[currentKey], spawnLocations[kindOfKey].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        whatToSpawnClone[currentKey].name = currentKey.ToString() + '-' + kindOfKey.ToString();
    }


}
