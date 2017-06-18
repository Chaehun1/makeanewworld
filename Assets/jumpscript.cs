using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscript : MonoBehaviour
{
    public float Jump;

    public bool Jumpable { get; private set; }

    // Update is called once per frame
    void Update()
    {
            if (Jumpable && Input.GetKeyDown()
            {
                Jumpable = false;
                GetComponent<Rigidbody2D>()
                    .AddForce(new Vector2(0, Jump));
            }
    }
}
