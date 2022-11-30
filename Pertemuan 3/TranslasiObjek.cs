using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslasiObjek : MonoBehaviour
{
    Vector3 kekanan;
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3 (1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * Time.deltaTime);
    }
}