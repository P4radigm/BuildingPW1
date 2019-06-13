using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolderManager : MonoBehaviour
{
    public static KeyHolderManager Instance;
    public Row[] Rows = new Row[5];

    private Dictionary<KeyCode, KeyCodeHolder> keyCodeDictionary = new Dictionary<KeyCode, KeyCodeHolder>();

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        KeyCodeHolder[] keyCodeHolders = GetComponentsInChildren<KeyCodeHolder>();
        foreach (KeyCodeHolder holder in keyCodeHolders)
        {
            if (!keyCodeDictionary.ContainsKey(holder.key))
            {
                keyCodeDictionary.Add(holder.key, holder);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(vKey))
                {
                    //your code here
                    if (keyCodeDictionary.ContainsKey(vKey))
                    {
                        keyCodeDictionary[vKey].UpdateToNextprefab();
                    }

                }
            }
        }
    }
}

[System.Serializable]
public class Row
{
    public int MaxWallAmount;
    public int MaxStairsAmount;
    public int MaxCannonAmount;
    public int MaxStockAmount;

    public int CurrentWallAmount;
    public int CurrentStairsAmount;
    public int CurrentCannonAmount;
    public int CurrentStockAmount;
}
