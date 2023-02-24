using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentar : MonoBehaviour
{
    GameObject personagem;
    Transform eixosPersonagem;
    Vector3 posicaoPersonagem;
    // Start is called before the first frame update
    void Start()
    {
        eixosPersonagem = personagem.GetComponent<Transform>();
        posicaoPersonagem = eixosPersonagem.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoverFrente()
    {
        //eixosPersonagem.position.z *= 10;
    }
}
