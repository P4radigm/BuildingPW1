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

            GameObject.Find("EnterBefore").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("EnterAfter").GetComponent<MeshRenderer>().enabled = true;
        }

        if (myGameState == GameState.Keyboard)
        {
            GameObject.Find("SpawnerB").GetComponent<KeyHolderManager>().enabled = true;

            GameObject.Find("EnterBefore").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("EnterAfter").GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
