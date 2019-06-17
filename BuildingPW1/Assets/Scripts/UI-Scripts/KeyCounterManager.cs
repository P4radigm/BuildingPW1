using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyCounterManager : MonoBehaviour
{
    private GameObject Spawner;
    public TextMeshProUGUI[] counterTextWall;
    public int[] currentWall;
    public int[] maxWall;
    public TextMeshProUGUI[] counterTextStock;
    public int[] currentStock;
    public int[] maxStock;
    public TextMeshProUGUI[] counterTextCannon;
    public int[] currentCannon;
    public int[] maxCannon;
    public TextMeshProUGUI[] counterTextStairs;
    public int[] currentStairs;
    public int[] maxStairs;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Spawner = GameObject.FindGameObjectWithTag("Spawner");
        KeyHolderManager keyHolderManager = Spawner.GetComponent<KeyHolderManager>();

        for (int i = 4; i >= 0; i--)
        {
            currentWall[i] = keyHolderManager.Rows[i].CurrentWallAmount;
            maxWall[i] = keyHolderManager.Rows[i].MaxWallAmount;
            currentStock[i] = keyHolderManager.Rows[i].CurrentStockAmount;
            maxStock[i] = keyHolderManager.Rows[i].MaxStockAmount;
            currentCannon[i] = keyHolderManager.Rows[i].CurrentCannonAmount;
            maxCannon[i] = keyHolderManager.Rows[i].MaxCannonAmount;
            currentStairs[i] = keyHolderManager.Rows[i].CurrentStairsAmount;
            maxStairs[i] = keyHolderManager.Rows[i].MaxStairsAmount;
        }

        for (int g = 4; g >= 0; g--)
        {
            counterTextWall[g].text = maxWall[g] - currentWall[g] + "x";
            counterTextStock[g].text = maxStock[g] - currentStock[g] + "x";
            counterTextCannon[g].text = maxCannon[g] - currentCannon[g] + "x";
            counterTextStairs[g].text = maxStairs[g] - currentStairs[g] + "x";
        }
    }
}
