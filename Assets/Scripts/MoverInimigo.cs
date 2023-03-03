using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverInimigo : MonoBehaviour
{
    Rigidbody rgbd;
    GameObject player;
    Vector3 posPlayer;
    [SerializeField] float velocidade;
    bool perseguindo = false;

    // Start is called before the first frame update
    void Start()
    {
        rgbd = gameObject.GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (perseguindo)
        {
            PerseguirJogador();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entrou no trigger do inimigo");
            perseguindo = true;
            
        }
    }

    void PerseguirJogador()
    {
        posPlayer = player.transform.position;
        Vector3 direcao = (posPlayer - this.transform.position).normalized;
        Vector3 movimento = Time.deltaTime * velocidade * direcao;
        this.transform.position += movimento;
    }
}
