using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovements : MonoBehaviour
{

    [SerializeField]
    private float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.C))
        {
            this.transform.position += new Vector3(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.UpArrow)){
            this.transform.eulerAngles += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.eulerAngles += new Vector3(-1, 0, 0);
        }
    }
}
