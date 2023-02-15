using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedDorado : MonoBehaviour
{
    public float time = 0f;
    public float resetTime = 0f;

    public GameObject randomPosObj;
    int rndX;
    int rndY;
    int rndZ;
    void OnCollisionStay(Collision collision)
    {
        if (collision.transform.gameObject.tag == "Player")
        {
            time += Time.deltaTime;
            if (time >= 2)
            {
                PosAlAzar();
                time = resetTime;
            }

        }


    }   

    // Start is called before the first frame update
    void Start()
    {
        rndX = Random.Range(-10, 10);
        rndY = Random.Range(-20, 20);
        rndZ = Random.Range(-10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        rndX = Random.Range(-10, 10);
        rndY = Random.Range(-20, 20);
        rndZ = Random.Range(-10, 10);
    }
    void PosAlAzar()
    {
        randomPosObj.transform.position = new Vector3(rndX, 2.77f, rndZ);
    }
}
