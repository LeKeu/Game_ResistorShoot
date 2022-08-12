using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bala : MonoBehaviour
{
    public static int score;
    GameObject personag;
    GameObject bolinha;
    Rigidbody2D rb2D;
    Renderer r;
    AudioSource morteAudio;
    // Start is called before the first frame update
    private void Start()
    {
        personag = GameObject.Find("Personagem");
        bolinha = GameObject.Find("Bolinha");
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        r = GetComponent<Renderer>();
        morteAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!r.isVisible)
        {
            Destroy(rb2D.gameObject);
            Debug.Log("morreu");
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<SpriteRenderer>().color == rb2D.gameObject.GetComponent<SpriteRenderer>().color && other.gameObject.tag != "Player")
        {
            morteAudio.Play();
            Debug.Log("aaaaaaaaaaaaaaaa");
            Destroy(other.gameObject);
            Destroy(rb2D.gameObject);
            score++;
            //PlayerPrefs.SetInt("highscore", score);

        }

        if (other.gameObject.GetComponent<SpriteRenderer>().color == bolinha.gameObject.GetComponent<SpriteRenderer>().color && other.gameObject.tag != "Player")
        {
            Debug.Log("score : " + score);

            if (score >= PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", score);
                //https://www.youtube.com/watch?v=Y7GjVFFSMuI
            }
            SceneManager.LoadScene("Menu");
        }
    }
}
