using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no_front_mv : MonoBehaviour
{
    public float times;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, times);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 2, 0) * speed * Time.deltaTime);  
    }
}
