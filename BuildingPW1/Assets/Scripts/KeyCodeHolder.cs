using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCodeHolder : MonoBehaviour
{
    public KeyCode key;
    public int state = 0;

    private GameObject currentPrefab;
    private GameObject[] prefabs;

    public void Start()
    {
        prefabs = Resources.LoadAll<GameObject>("KeyPrefabs");
    }

    public void UpdateToNextprefab()
    {
        state++;
        if(state >= prefabs.Length)
        {
            state = 0;
        }
        if(currentPrefab != null)
        {
            Destroy(currentPrefab);
        }
        currentPrefab = Instantiate(prefabs[state],transform.position, Quaternion.identity);
    }
}
