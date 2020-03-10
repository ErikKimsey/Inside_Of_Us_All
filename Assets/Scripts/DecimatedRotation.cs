using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecimatedRotation : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 torusPosition;
    public float rotateSpeed = 5f;

    void Start()
    {
      Debug.Log(transform.position);
      Debug.Log(GetComponent<Renderer>().bounds.size);
    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
