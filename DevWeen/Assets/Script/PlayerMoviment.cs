using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField] private float vel = 5f;
    [SerializeField] private string inptHorizontal;
    [SerializeField] private string inptVertical;
    [SerializeField] private Vector2 maxDist;
    [SerializeField] private Vector2 minDist;
    [SerializeField] Animator animacao;
    private Rigidbody2D rb;
    Vector2 movement;
    Vector2 posicaoAtual = new Vector2(0, 1);
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animacao = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw(inptHorizontal);
        movement.y = Input.GetAxisRaw(inptVertical);
        if (transform.position.x > maxDist.x)
            transform.position = new Vector2(maxDist.x, transform.position.y);
        if (transform.position.y > maxDist.y)
            transform.position = new Vector2(transform.position.x, maxDist.y);
        if (transform.position.x < minDist.x)
            transform.position = new Vector2(minDist.x, transform.position.y);
        if (transform.position.y < minDist.y)
            transform.position = new Vector2(transform.position.x, minDist.y);
        if (movement.y != 0)
        {
            if (movement.y > 0)
            {
                posicaoAtual = new Vector2(0, 1);
            }
            else
            {
                posicaoAtual = new Vector2(0, -1);
            }
        }

        else if (movement.x != 0)
        {
            if (movement.x > 0)
            {
                posicaoAtual = new Vector2(1, 0);
            }
            else
            {
                posicaoAtual = new Vector2(-1, 0);
            }
        }
        animacao.SetFloat("Speed", movement.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * vel * Time.fixedDeltaTime);
    }
}
