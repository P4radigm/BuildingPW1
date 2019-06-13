using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum GameState {Keyboard, FPS};
    bool PlayerReset = false;
    GameObject Spawner;
    GameObject MainCamera;
    GameObject FPScontroller;
    Vector3 OGPos = new Vector3(898, -92, 1130);
    Transform OGtransform;

    GameState myGameState = GameState.Keyboard;

    void Start()
    {
        Spawner = GameObject.FindGameObjectWithTag("Spawner");
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        FPScontroller = GameObject.FindGameObjectWithTag("FPScontroller");

        OGtransform = FPScontroller.transform;
        
        FPScontroller.SetActive(false);
        MainCamera.SetActive(true);
        
    }

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
            Spawner.GetComponent<KeyHolderManager>().enabled = false;
            MainCamera.SetActive(false);
            FPScontroller.SetActive(true);

            if (PlayerReset == false)
            {
                FPScontroller.transform.position = OGPos;
                FPScontroller.transform.rotation = OGtransform.rotation;
                PlayerReset = true;
            }

        }

        if (myGameState == GameState.Keyboard)
        {
            Spawner.GetComponent<KeyHolderManager>().enabled = true;
            FPScontroller.SetActive(false);
            MainCamera.SetActive(true);
            PlayerReset = false;
        }
    }
}
