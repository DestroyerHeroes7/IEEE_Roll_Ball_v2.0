using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool isAir;
    void Start()
    {
        RandomPositionSet();
    }
    void Update()
    {
        transform.Rotate(new Vector3(30, 45, 30) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin"))
            RandomPositionSet();
    }
    public void RandomPositionSet()
    {
        float rX = Random.Range(-3.5f, 3.5f);
        float rZ = Random.Range(-3.5f, 3.5f);
        while(rX > -1 && rX < 1)
        {
            Debug.Log("rX in Player Spawn Area");
            rX = Random.Range(-3.5f, 3.5f);
        }
        while (rZ > -1 && rZ < 1)
        {
            Debug.Log("rZ in Player Spawn Area");
            rZ = Random.Range(-3.5f, 3.5f);
        }
        transform.position = new Vector3(rX, isAir ? 2f : 0.45f, rZ);
    }
}
