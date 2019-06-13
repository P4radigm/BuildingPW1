using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCodeHolder : MonoBehaviour
{
    public int rowIndex = 0;

    public KeyCode key;
    public int index = 0;
    public GameObject Highlight;
    bool IsThereLight = false;

    private GameObject CurrentLight;
    private GameObject currentPrefab;
    private GameObject[] prefabs;

    public void Start()
    {
        prefabs = Resources.LoadAll<GameObject>("KeyPrefabs");
    }

    public IEnumerator Light()
    {
        if(IsThereLight != true)
        {
        IsThereLight = true;
        CurrentLight = Instantiate(Highlight, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        Destroy(CurrentLight);
        IsThereLight = false;
        }
    }

    public void UpdateToNextprefab()
    {
        StartCoroutine(Light());

        index++;
        while (index < prefabs.Length && !CanPlace())
        {
            index++;
        }
            
        if(index >= prefabs.Length)
        {
            index = 0;
        }

        if(currentPrefab != null)
        {
            RemoveCurrentKey();
        }
        PlaceNewKey();

    }

    void RemoveCurrentKey()
    {
        switch (currentPrefab.tag)
        {
            case "CannonKey":
                KeyHolderManager.Instance.Rows[rowIndex].CurrentCannonAmount--;
                break;
            case "WallKey":
                KeyHolderManager.Instance.Rows[rowIndex].CurrentWallAmount--;
                break;
            case "StairKey":
                KeyHolderManager.Instance.Rows[rowIndex].CurrentStairsAmount--;
                break;
            case "StockKey":
                KeyHolderManager.Instance.Rows[rowIndex].CurrentStockAmount--;
                break;
        }

        Destroy(currentPrefab);
    }

    void PlaceNewKey()
    {
        switch (prefabs[index].tag)
        {
            case "CannonKey":
                KeyHolderManager.Instance.Rows[rowIndex].CurrentCannonAmount++;
                break;
            case "WallKey":
                KeyHolderManager.Instance.Rows[rowIndex].CurrentWallAmount++;
                break;
            case "StairKey":
                KeyHolderManager.Instance.Rows[rowIndex].CurrentStairsAmount++;
                break;
            case "StockKey":
                KeyHolderManager.Instance.Rows[rowIndex].CurrentStockAmount++;
                break;
        }

        currentPrefab = Instantiate(prefabs[index], transform.position, Quaternion.identity);
    }

    bool CanPlace()
    {
        bool _returnValue = false;

        switch (prefabs[index].tag)
        {
            case "CannonKey":
                if (KeyHolderManager.Instance.Rows[rowIndex].CurrentCannonAmount < KeyHolderManager.Instance.Rows[rowIndex].MaxCannonAmount)
                    _returnValue = true;
                break;
            case "WallKey":
                if (KeyHolderManager.Instance.Rows[rowIndex].CurrentWallAmount < KeyHolderManager.Instance.Rows[rowIndex].MaxWallAmount)
                    _returnValue = true;
                break;
            case "StairKey":
                if (KeyHolderManager.Instance.Rows[rowIndex].CurrentStairsAmount < KeyHolderManager.Instance.Rows[rowIndex].MaxStairsAmount)
                    _returnValue = true;
                break;
            case "StockKey":
                if (KeyHolderManager.Instance.Rows[rowIndex].CurrentStockAmount < KeyHolderManager.Instance.Rows[rowIndex].MaxStockAmount)
                    _returnValue = true;
                break;
        }

        return _returnValue;
    }
}
