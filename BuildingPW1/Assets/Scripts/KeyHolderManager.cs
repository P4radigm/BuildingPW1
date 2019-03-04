using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolderManager : MonoBehaviour
{
    private Dictionary<KeyCode, KeyCodeHolder> keyCodeDictionary = new Dictionary<KeyCode, KeyCodeHolder>();
    // Start is called before the first frame update
    void Start()
    {
        KeyCodeHolder[] keyCodeHolders = GetComponentsInChildren<KeyCodeHolder>();
        foreach(KeyCodeHolder holder in keyCodeHolders)
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
