using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Start()
    {
       
    }
    void Update()
    {
        transform.Rotate(new Vector3(30, 45, 30) * Time.deltaTime);
    }
}
