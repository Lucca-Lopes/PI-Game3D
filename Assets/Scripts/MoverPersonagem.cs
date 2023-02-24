using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonagem : MonoBehaviour
{
    [SerializeField] float velocidade;
    Rigidbody rgbd;
    float inputHorizontal;
    float inputVertical;

    // Start is called before the first frame update
    void Start()
    {
        rgbd = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");
        Mover(inputHorizontal, inputVertical);
    }

    void Mover(float inputH, float inputV)
    {
        rgbd.velocity = new Vector3(inputH * velocidade, 0, inputV * velocidade);
    }
}
