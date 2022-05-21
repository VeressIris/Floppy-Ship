using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float maxTime = 1.5f;
    private float timer = 0f;
    private float height = 20f;

    [SerializeField] private GameObject pipe;

    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            
            Destroy(newPipe, 15f);
            
            timer = 0;
        }        

        timer += Time.deltaTime;
    }
}
