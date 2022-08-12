using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiros : MonoBehaviour
{
    [SerializeField] Transform fireP;
    [SerializeField] GameObject balaPref;
    [SerializeField] float forcaBala;

    [SerializeField] SpriteRenderer balaSR;
    [SerializeField] Rigidbody2D balaGO;
    [SerializeField] Rigidbody2D personagem;
    // Start is called before the first frame update
    SpriteRenderer teste;
    AudioSource tiroAudio;
    // Start is called before the first frame update
    void Start()
    {
        tiroAudio = GetComponent<AudioSource>();
        teste = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            tiroAudio.Play();
            Atirar();
        }
    }

    void Atirar()
    {
        balaSR.color = teste.color;
        balaGO.gameObject.tag = personagem.gameObject.tag;
        Debug.Log(balaGO);
        GameObject bala = Instantiate(balaPref, fireP.position, fireP.rotation);
        Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
        rb.AddForce(fireP.up * forcaBala, ForceMode2D.Impulse);
    }

}
