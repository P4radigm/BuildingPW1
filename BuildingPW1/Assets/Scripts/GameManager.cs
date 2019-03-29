using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum GameState {Keyboard, FPS};
    bool capsLockOn = false;

    GameState myGameState = GameState.Keyboard;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            if (myGameState == GameState.Keyboard)
            {
                myGameState = GameState.FPS;
            }
            else
            {
                myGameState = GameState.Keyboard;
            }
        }

        if (myGameState == GameState.FPS)
        {
            GameObject.Find("SpawnerB").GetComponent<KeyHolderManager>().enabled = false;

            GameObject.GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<Camera>.enabled = false;
        }

        if (myGameState == GameState.Keyboard)
        {
            GameObject.Find("SpawnerB").GetComponent<KeyHolderManager>().enabled = true;

            GameObject.Find("FPS controller").SetActive(false);
            GameObject.Find("Main Camera").SetActive(true);
        }
    }
}
