using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerColl : MonoBehaviour

{
    GameObject FPScontroller;
    public GameObject winPanel;
    Vector3 OGPos = new Vector3(898, 288, 1130);
    Transform OGtransform;

    void Start()
    {
        FPScontroller = GameObject.FindGameObjectWithTag("FPScontroller");

        OGtransform = FPScontroller.transform;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "RespawnColliders")
        {
            FPScontroller.transform.position = OGPos;
            FPScontroller.transform.rotation = OGtransform.rotation;
        }

        if (collision.gameObject.tag == "FinishCollider")
        {
            StartCoroutine(Finish());
        }
    }

    public IEnumerator Finish()
    {
        winPanel.SetActive(true);

        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

