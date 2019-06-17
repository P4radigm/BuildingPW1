using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    public float shootingRegularity;
    private Transform CannonBall_Spawn = null;
    public GameObject CannonBallPrefab = null;
    public int Power = 1;
    private bool WaitForShot = false;

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        if(WaitForShot == false)
        {
            WaitForShot = true;
            Shoot();
            StartCoroutine(Waiting());
        }
    }

    public void Shoot()
    {
        CannonBall_Spawn = transform.Find("CannonBall_Spawn");
        GameObject cannonBall = Instantiate(CannonBallPrefab, CannonBall_Spawn.position, Quaternion.identity);
        Rigidbody rb = cannonBall.AddComponent<Rigidbody>();
        rb.velocity = Power * CannonBall_Spawn.forward;

        StartCoroutine(RemoveBall(cannonBall, 8.0f));
    }

    public IEnumerator RemoveBall(GameObject spawnedCannonBall, float delay)
    {
        yield return new WaitForSeconds(delay);

        Destroy(spawnedCannonBall);
    }

    public IEnumerator Waiting()
    {
        yield return new WaitForSeconds(shootingRegularity);
        WaitForShot = false;
    }
}
