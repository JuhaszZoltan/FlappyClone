using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPipe : MonoBehaviour
{
    public float maxTime = 2.5F;
    float timer = 2;
    public GameObject pipe;
    public float height = 2;

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
