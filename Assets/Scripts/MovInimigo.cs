using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovInimigo : MonoBehaviour
{
    GameObject jogador; // o jogador a ser seguido
    private Rigidbody2D rb;
    private Vector2 movimento;
    [SerializeField] float moveSpeed = 5f;
    //[SerializeField] float destroyDelay = 0.5f;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        jogador = GameObject.Find("Personagem");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcao = jogador.transform.position - transform.position; // eu pego a direção do meu jogador
        direcao.Normalize(); // o valor tem q ser entre -1 e +1, o Normalize faz isso pelo q eu entendi
        movimento = direcao;
    }

    private void FixedUpdate()
    {
        moverCarro(movimento);
    }

    void moverCarro(Vector2 direcao)
    {
        rb.MovePosition((Vector2)transform.position + (direcao * moveSpeed * Time.deltaTime));
    }

}
