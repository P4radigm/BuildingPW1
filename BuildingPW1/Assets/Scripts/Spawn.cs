using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    public int currentOfKeyBackQuote = 0;
    public int toDestroyOfKeyBackQuote = 4;
    public int currentOfKeyAlpha1 = 0;
    public int toDestroyOfKeyAlpha1 = 4;
    public int currentOfKeyAlpha2 = 0;
    public int toDestroyOfKeyAlpha2 = 4;
    public int currentOfKeyAlpha3 = 0;
    public int toDestroyOfKeyAlpha3 = 4;
    public int currentOfKeyAlpha4 = 0;
    public int toDestroyOfKeyAlpha4 = 4;
    public int currentOfKeyAlpha5 = 0;
    public int toDestroyOfKeyAlpha5 = 4;
    public int currentOfKeyAlpha6 = 0;
    public int toDestroyOfKeyAlpha6 = 4;
    public int currentOfKeyAlpha7 = 0;
    public int toDestroyOfKeyAlpha7 = 4;
    public int currentOfKeyAlpha8 = 0;
    public int toDestroyOfKeyAlpha8 = 4;
    public int currentOfKeyAlpha9 = 0;
    public int toDestroyOfKeyAlpha9 = 4;
    public int currentOfKeyAlpha0 = 0;
    public int toDestroyOfKeyAlpha0 = 4;
    public int currentOfKeyMinus = 0;
    public int toDestroyOfKeyMinus = 4;
    public int currentOfKeyEquals = 0;
    public int toDestroyOfKeyEquals = 4;
    public int currentOfKeyBackspace = 0;
    public int toDestroyOfKeyBackspace = 4;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            Debug.Log(currentOfKeyBackQuote);
            DestroyGameObject(toDestroyOfKeyBackQuote.ToString() + '-' + '0');
            spawnSmth(currentOfKeyBackQuote, 0);
            currentOfKeyBackQuote += 1;
            toDestroyOfKeyBackQuote += 1;
            if (toDestroyOfKeyBackQuote > 4)
            {
                toDestroyOfKeyBackQuote = 0;
            }
            if (currentOfKeyBackQuote > 4)
            {
                currentOfKeyBackQuote = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log(currentOfKeyAlpha1);
            DestroyGameObject(toDestroyOfKeyAlpha1.ToString() + '-' + '1');
            spawnSmth(currentOfKeyAlpha1, 1);
            currentOfKeyAlpha1 += 1;
            toDestroyOfKeyAlpha1 += 1;
            if (toDestroyOfKeyAlpha1 > 4)
            {
                toDestroyOfKeyAlpha1 = 0;
            }
            if (currentOfKeyAlpha1 > 4)
            {
                currentOfKeyAlpha1 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log(currentOfKeyAlpha2);
            DestroyGameObject(toDestroyOfKeyAlpha2.ToString() + '-' + '2');
            spawnSmth(currentOfKeyAlpha2, 2);
            currentOfKeyAlpha2 += 1;
            toDestroyOfKeyAlpha2 += 1;
            if (toDestroyOfKeyAlpha2 > 4)
            {
                toDestroyOfKeyAlpha2 = 0;
            }
            if (currentOfKeyAlpha2 > 4)
            {
                currentOfKeyAlpha2 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log(currentOfKeyAlpha3);
            DestroyGameObject(toDestroyOfKeyAlpha3.ToString() + '-' + '3');
            spawnSmth(currentOfKeyAlpha3, 3);
            currentOfKeyAlpha3 += 1;
            toDestroyOfKeyAlpha3 += 1;
            if (toDestroyOfKeyAlpha3 > 4)
            {
                toDestroyOfKeyAlpha3 = 0;
            }
            if (currentOfKeyAlpha3 > 4)
            {
                currentOfKeyAlpha3 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log(currentOfKeyAlpha4);
            DestroyGameObject(toDestroyOfKeyAlpha4.ToString() + '-' + '4');
            spawnSmth(currentOfKeyAlpha4, 4);
            currentOfKeyAlpha4 += 1;
            toDestroyOfKeyAlpha4 += 1;
            if (toDestroyOfKeyAlpha4 > 4)
            {
                toDestroyOfKeyAlpha4 = 0;
            }
            if (currentOfKeyAlpha4 > 4)
            {
                currentOfKeyAlpha4 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Debug.Log(currentOfKeyAlpha5);
            DestroyGameObject(toDestroyOfKeyAlpha5.ToString() + '-' + '5');
            spawnSmth(currentOfKeyAlpha5, 5);
            currentOfKeyAlpha5 += 1;
            toDestroyOfKeyAlpha5 += 1;
            if (toDestroyOfKeyAlpha5 > 4)
            {
                toDestroyOfKeyAlpha5 = 0;
            }
            if (currentOfKeyAlpha5 > 4)
            {
                currentOfKeyAlpha5 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Debug.Log(currentOfKeyAlpha6);
            DestroyGameObject(toDestroyOfKeyAlpha6.ToString() + '-' + '6');
            spawnSmth(currentOfKeyAlpha6, 6);
            currentOfKeyAlpha6 += 1;
            toDestroyOfKeyAlpha6 += 1;
            if (toDestroyOfKeyAlpha6 > 4)
            {
                toDestroyOfKeyAlpha6 = 0;
            }
            if (currentOfKeyAlpha6 > 4)
            {
                currentOfKeyAlpha6 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Debug.Log(currentOfKeyAlpha7);
            DestroyGameObject(toDestroyOfKeyAlpha7.ToString() + '-' + '7');
            spawnSmth(currentOfKeyAlpha7, 7);
            currentOfKeyAlpha8 += 1;
            toDestroyOfKeyAlpha8 += 1;
            if (toDestroyOfKeyAlpha7 > 4)
            {
                toDestroyOfKeyAlpha7 = 0;
            }
            if (currentOfKeyAlpha7 > 4)
            {
                currentOfKeyAlpha7 = 0;
            }
        }


    }

    

    void spawnSmth(int currentKey, int kindOfKey)
    {
        whatToSpawnClone[currentKey] = Instantiate(whatToSpawnPrefab[currentKey], spawnLocations[kindOfKey].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        whatToSpawnClone[currentKey].name = currentKey.ToString() + '-' + kindOfKey.ToString();
    }

    void DestroyGameObject(string lastPlacedKey)
    {
        Destroy(GameObject.Find(lastPlacedKey));
    }


}
