using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            anim.SetBool("hajar",true);
        } else {
            anim.SetBool("hajar",false);
        }

        if (Input.GetKey(KeyCode.A)) {
            anim.SetBool("sepak",true);
        } else {
            anim.SetBool("sepak",false);
        }
    }
}
