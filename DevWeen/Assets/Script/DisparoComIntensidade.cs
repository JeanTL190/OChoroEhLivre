using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoComIntensidade : MonoBehaviour
{
    [SerializeField] private float maxVel = 5f;
    [SerializeField] private float acel = 0.5f;
    [SerializeField] private float desacel = 0.1f;
    [SerializeField] private string disparo;
    [SerializeField] private Transform transfDisp;
    private float velAtual = 1f;
    private Rigidbody2D rb;
    private bool shoot = false;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (!shoot)
        {
            this.transform.position = transfDisp.position;
            this.transform.rotation = transfDisp.rotation;
            if (Input.GetAxisRaw(disparo) > 0)
            {
                velAtual += (Time.deltaTime * acel);
                velAtual = Mathf.Clamp(velAtual, 0, maxVel);
            }
            else if (Input.GetButtonUp(disparo))
            {
                rb.velocity = transform.up * velAtual;
                shoot = true;
            }
        }
    }
    private void FixedUpdate()
    {
        if (shoot)
        {
            velAtual -= (Time.deltaTime * desacel);
            velAtual = Mathf.Clamp(velAtual, 0, maxVel);
            rb.velocity = transform.up * velAtual;
            if (velAtual == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
    public void SetDisparo(string d)
    {
        disparo = d;
    }
    public void SetTransfDisp(Transform t)
    {
        transfDisp = t;
    }
}
