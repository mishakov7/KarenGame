using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour
{

    public float speed;

    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed, 0.15f);
    }
}