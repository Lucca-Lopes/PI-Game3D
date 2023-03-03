using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorVida : MonoBehaviour
{
    [SerializeField] int vidaMaxima;
    int vidaAtual;
    bool vivo = true;

    // Start is called before the first frame update
    void Start()
    {
        vidaAtual = vidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReceberDano(int dano)
    {
        vidaAtual -= dano;
        VerificaVivo();
    }

    void VerificaVivo()
    {
        if (vidaAtual <= 0)
        {
            vivo = false;
        }
        else
        {
            vivo = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tiro"))
        {
            GerenciaTiro gerencaiTiro = collision.gameObject.GetComponent<GerenciaTiro>();
            ReceberDano(gerencaiTiro.dano);
        }
    }
}
