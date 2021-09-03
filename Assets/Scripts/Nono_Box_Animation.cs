using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nono_Box_Animation : MonoBehaviour
{
    //public float speed = 1;
    public GameObject Button_A;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0, -2, -1);

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(0, 2, 0) * speed * Time.deltaTime);

    }


    public void whenButtonClicked()

    {

        if (Button_A.activeInHierarchy == true)
            Button_A.transform.Translate(new Vector3(0, 2, 0) *  Time.deltaTime);
        else
            Button_A.SetActive(true);
    }
}
