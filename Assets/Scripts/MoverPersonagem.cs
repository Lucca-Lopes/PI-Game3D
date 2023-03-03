using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoverPersonagem : MonoBehaviour
{
    MeusControles meusControles;
    Vector2 inputMovimento;
    [SerializeField] float velocidade;
    Rigidbody rgbd;

    private void Awake()
    {
        meusControles = new MeusControles();
    }

    private void OnEnable()
    {
        meusControles.Enable();
    }

    private void OnDisable()
    {
        meusControles.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        rgbd = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputMovimento = meusControles.Player.Mover.ReadValue<Vector2>();
        Mover();
    }

    void Mover()
    {
        rgbd.velocity = new Vector3(inputMovimento.x, 0, inputMovimento.y) * velocidade;
    }

    public void Atirar()
    {
        Debug.Log("Atirou");
    }
}
