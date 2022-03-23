using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Bird bird;
    public GameObject pipes;
    public float time;

    public float height = 0.3f;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }


    public IEnumerator SpawnObject(float time)
    {
        while(!bird.isDead)
        {
            Instantiate(pipes, new Vector3(3,Random.Range(-height,height),0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}

