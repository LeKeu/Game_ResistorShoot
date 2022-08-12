using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimento : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] float velMov;
    [SerializeField] Camera cam;
    private float moveVert;
    private float moveHoriz;
    int x;
    int y;


    Vector2 mousePos;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        x = Screen.width;
        y = Screen.height;
        Debug.Log(x);
        Debug.Log(y);

    }

    void Update()
    {
        moveHoriz = Input.GetAxisRaw("Horizontal");
        moveVert = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);


    }

    void FixedUpdate()
    {
        if (moveHoriz > 0.1f || moveHoriz < -0.1f)
        {
            rb2D.AddForce(new Vector2(moveHoriz / velMov, 0f), ForceMode2D.Impulse);
        }
        if (moveVert > 0.1f || moveVert < -0.1f)
        {
            rb2D.AddForce(new Vector2(0f, moveVert / velMov), ForceMode2D.Impulse);
        }

        Vector2 olharPara = mousePos - rb2D.position;
        float angulo = Mathf.Atan2(olharPara.y, olharPara.x) * Mathf.Rad2Deg - 90f;
        rb2D.rotation = angulo;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "inimigo")
        {
            if (Bala.score >= PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", Bala.score);
                //https://www.youtube.com/watch?v=Y7GjVFFSMuI
            }
            SceneManager.LoadScene("Menu");
        }
    }
}
