using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciaTiro : MonoBehaviour
{
    public int dano;
    Rigidbody rgbd;
    [SerializeField] GameObject jogador;

    // Start is called before the first frame update
    void Start()
    {
        rgbd = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        if(this.transform.position.x > jogador.transform.position.x * 10 || this.transform.position.z > jogador.transform.position.z * 10)
        {
            ReiniciarTiro();
        }
    }

    void Mover()
    {
        rgbd.velocity = 10 * Time.deltaTime * new Vector3(1, 0, 0);
    }

    public void ReiniciarTiro()
    {
        this.gameObject.SetActive(false);
        this.transform.position = jogador.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            ReiniciarTiro();
        }
    }
}
