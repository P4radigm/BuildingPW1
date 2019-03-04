using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnB : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    public List<CertainKey> certainKeyList = new List<CertainKey>();

    void Start()
    {
        for (int i = 0; i < 51; i++)
        {
            CertainKey key = new CertainKey();
            key.currentKey = i;
            key.kindOfKey = i;
            key.currentKey = 0;
            key.toDestroyKey = 4;
            key.lastPlacedKey = "";

            certainKeyList.Add(key);
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            DestroyGameObject(certainKeyList[0]);
            SpawnSmthB(certainKeyList[0]);
            UpdateCurrentKey(certainKeyList[0]);
            UpdateToDestroyKey(certainKeyList[0]);
            UpdatelastPlacedKey(certainKeyList[0]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DestroyGameObject(certainKeyList[1]);
            SpawnSmthB(certainKeyList[1]);
            UpdateCurrentKey(certainKeyList[1]);
            UpdateToDestroyKey(certainKeyList[1]);
            UpdatelastPlacedKey(certainKeyList[1]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DestroyGameObject(certainKeyList[2]);
            SpawnSmthB(certainKeyList[2]);
            UpdateCurrentKey(certainKeyList[2]);
            UpdateToDestroyKey(certainKeyList[2]);
            UpdatelastPlacedKey(certainKeyList[2]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            DestroyGameObject(certainKeyList[3]);
            SpawnSmthB(certainKeyList[3]);
            UpdateCurrentKey(certainKeyList[3]);
            UpdateToDestroyKey(certainKeyList[3]);
            UpdatelastPlacedKey(certainKeyList[3]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            DestroyGameObject(certainKeyList[4]);
            SpawnSmthB(certainKeyList[4]);
            UpdateCurrentKey(certainKeyList[4]);
            UpdateToDestroyKey(certainKeyList[4]);
            UpdatelastPlacedKey(certainKeyList[4]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            DestroyGameObject(certainKeyList[5]);
            SpawnSmthB(certainKeyList[5]);
            UpdateCurrentKey(certainKeyList[5]);
            UpdateToDestroyKey(certainKeyList[5]);
            UpdatelastPlacedKey(certainKeyList[5]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            DestroyGameObject(certainKeyList[6]);
            SpawnSmthB(certainKeyList[6]);
            UpdateCurrentKey(certainKeyList[6]);
            UpdateToDestroyKey(certainKeyList[6]);
            UpdatelastPlacedKey(certainKeyList[6]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            DestroyGameObject(certainKeyList[7]);
            SpawnSmthB(certainKeyList[7]);
            UpdateCurrentKey(certainKeyList[7]);
            UpdateToDestroyKey(certainKeyList[7]);
            UpdatelastPlacedKey(certainKeyList[7]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            DestroyGameObject(certainKeyList[8]);
            SpawnSmthB(certainKeyList[8]);
            UpdateCurrentKey(certainKeyList[8]);
            UpdateToDestroyKey(certainKeyList[8]);
            UpdatelastPlacedKey(certainKeyList[8]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            DestroyGameObject(certainKeyList[9]);
            SpawnSmthB(certainKeyList[9]);
            UpdateCurrentKey(certainKeyList[9]);
            UpdateToDestroyKey(certainKeyList[9]);
            UpdatelastPlacedKey(certainKeyList[9]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            DestroyGameObject(certainKeyList[10]);
            SpawnSmthB(certainKeyList[10]);
            UpdateCurrentKey(certainKeyList[10]);
            UpdateToDestroyKey(certainKeyList[10]);
            UpdatelastPlacedKey(certainKeyList[10]);
        }

        if (Input.GetKeyDown(KeyCode.Minus))
        {
            DestroyGameObject(certainKeyList[11]);
            SpawnSmthB(certainKeyList[11]);
            UpdateCurrentKey(certainKeyList[11]);
            UpdateToDestroyKey(certainKeyList[11]);
            UpdatelastPlacedKey(certainKeyList[11]);
        }

        if (Input.GetKeyDown(KeyCode.Equals))
        {
            DestroyGameObject(certainKeyList[12]);
            SpawnSmthB(certainKeyList[12]);
            UpdateCurrentKey(certainKeyList[12]);
            UpdateToDestroyKey(certainKeyList[12]);
            UpdatelastPlacedKey(certainKeyList[12]);
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            DestroyGameObject(certainKeyList[13]);
            SpawnSmthB(certainKeyList[13]);
            UpdateCurrentKey(certainKeyList[13]);
            UpdateToDestroyKey(certainKeyList[13]);
            UpdatelastPlacedKey(certainKeyList[13]);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            DestroyGameObject(certainKeyList[14]);
            SpawnSmthB(certainKeyList[14]);
            UpdateCurrentKey(certainKeyList[14]);
            UpdateToDestroyKey(certainKeyList[14]);
            UpdatelastPlacedKey(certainKeyList[14]);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            DestroyGameObject(certainKeyList[15]);
            SpawnSmthB(certainKeyList[15]);
            UpdateCurrentKey(certainKeyList[15]);
            UpdateToDestroyKey(certainKeyList[15]);
            UpdatelastPlacedKey(certainKeyList[15]);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            DestroyGameObject(certainKeyList[16]);
            SpawnSmthB(certainKeyList[16]);
            UpdateCurrentKey(certainKeyList[16]);
            UpdateToDestroyKey(certainKeyList[16]);
            UpdatelastPlacedKey(certainKeyList[16]);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            DestroyGameObject(certainKeyList[17]);
            SpawnSmthB(certainKeyList[17]);
            UpdateCurrentKey(certainKeyList[17]);
            UpdateToDestroyKey(certainKeyList[17]);
            UpdatelastPlacedKey(certainKeyList[17]);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            DestroyGameObject(certainKeyList[18]);
            SpawnSmthB(certainKeyList[18]);
            UpdateCurrentKey(certainKeyList[18]);
            UpdateToDestroyKey(certainKeyList[18]);
            UpdatelastPlacedKey(certainKeyList[18]);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            DestroyGameObject(certainKeyList[19]);
            SpawnSmthB(certainKeyList[19]);
            UpdateCurrentKey(certainKeyList[19]);
            UpdateToDestroyKey(certainKeyList[19]);
            UpdatelastPlacedKey(certainKeyList[19]);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            DestroyGameObject(certainKeyList[20]);
            SpawnSmthB(certainKeyList[20]);
            UpdateCurrentKey(certainKeyList[20]);
            UpdateToDestroyKey(certainKeyList[20]);
            UpdatelastPlacedKey(certainKeyList[20]);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            DestroyGameObject(certainKeyList[21]);
            SpawnSmthB(certainKeyList[21]);
            UpdateCurrentKey(certainKeyList[21]);
            UpdateToDestroyKey(certainKeyList[21]);
            UpdatelastPlacedKey(certainKeyList[21]);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            DestroyGameObject(certainKeyList[22]);
            SpawnSmthB(certainKeyList[22]);
            UpdateCurrentKey(certainKeyList[22]);
            UpdateToDestroyKey(certainKeyList[22]);
            UpdatelastPlacedKey(certainKeyList[22]);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            DestroyGameObject(certainKeyList[16]);
            SpawnSmthB(certainKeyList[16]);
            UpdateCurrentKey(certainKeyList[16]);
            UpdateToDestroyKey(certainKeyList[16]);
            UpdatelastPlacedKey(certainKeyList[16]);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            DestroyGameObject(certainKeyList[23]);
            SpawnSmthB(certainKeyList[23]);
            UpdateCurrentKey(certainKeyList[23]);
            UpdateToDestroyKey(certainKeyList[23]);
            UpdatelastPlacedKey(certainKeyList[23]);
        }

        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            DestroyGameObject(certainKeyList[16]);
            SpawnSmthB(certainKeyList[16]);
            UpdateCurrentKey(certainKeyList[16]);
            UpdateToDestroyKey(certainKeyList[16]);
            UpdatelastPlacedKey(certainKeyList[16]);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            DestroyGameObject(certainKeyList[16]);
            SpawnSmthB(certainKeyList[16]);
            UpdateCurrentKey(certainKeyList[16]);
            UpdateToDestroyKey(certainKeyList[16]);
            UpdatelastPlacedKey(certainKeyList[16]);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            DestroyGameObject(certainKeyList[16]);
            SpawnSmthB(certainKeyList[16]);
            UpdateCurrentKey(certainKeyList[16]);
            UpdateToDestroyKey(certainKeyList[16]);
            UpdatelastPlacedKey(certainKeyList[16]);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            DestroyGameObject(certainKeyList[16]);
            SpawnSmthB(certainKeyList[16]);
            UpdateCurrentKey(certainKeyList[16]);
            UpdateToDestroyKey(certainKeyList[16]);
            UpdatelastPlacedKey(certainKeyList[16]);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            DestroyGameObject(certainKeyList[16]);
            SpawnSmthB(certainKeyList[16]);
            UpdateCurrentKey(certainKeyList[16]);
            UpdateToDestroyKey(certainKeyList[16]);
            UpdatelastPlacedKey(certainKeyList[16]);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            DestroyGameObject(certainKeyList[16]);
            SpawnSmthB(certainKeyList[16]);
            UpdateCurrentKey(certainKeyList[16]);
            UpdateToDestroyKey(certainKeyList[16]);
            UpdatelastPlacedKey(certainKeyList[16]);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            DestroyGameObject(certainKeyList[16]);
            SpawnSmthB(certainKeyList[16]);
            UpdateCurrentKey(certainKeyList[16]);
            UpdateToDestroyKey(certainKeyList[16]);
            UpdatelastPlacedKey(certainKeyList[16]);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            DestroyGameObject(certainKeyList[16]);
            SpawnSmthB(certainKeyList[16]);
            UpdateCurrentKey(certainKeyList[16]);
            UpdateToDestroyKey(certainKeyList[16]);
            UpdatelastPlacedKey(certainKeyList[16]);
        }

    }

    void SpawnSmthB(CertainKey certainKey)
    {
        whatToSpawnClone[certainKey.currentKey] = Instantiate(whatToSpawnPrefab[certainKey.currentKey], spawnLocations[certainKey.kindOfKey].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        whatToSpawnClone[certainKey.currentKey].name = certainKey.currentKey.ToString() + '-' + certainKey.kindOfKey.ToString();
    }

    void UpdateCurrentKey(CertainKey certainKey)
    {
        certainKey.currentKey += 1;
        if (certainKey.currentKey > 4)
        {
            certainKey.currentKey = 0;
        }
    }

    void UpdateToDestroyKey(CertainKey certainKey)
    {
        certainKey.toDestroyKey += 1;
        if (certainKey.toDestroyKey > 4)
        {
            certainKey.toDestroyKey = 0;
        }
    }

    void UpdatelastPlacedKey(CertainKey certainKey)
    {
        certainKey.lastPlacedKey = certainKey.toDestroyKey.ToString() + '-' + certainKey.kindOfKey.ToString();
    }

    void DestroyGameObject(CertainKey certainKey)
    {
        Destroy(GameObject.Find(certainKey.lastPlacedKey));
    }

}

public class CertainKey
{
    public int currentKey;
    public int kindOfKey;
    public int toDestroyKey;
    public string lastPlacedKey;
}
