using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Butoes : MonoBehaviour
{
    [SerializeField] KeyCode Key;

    // Start is called before the first frame update
    public void jogar()
    {
        Bala.score = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void voltar()
    {
        SceneManager.LoadScene("Menu");
    }

    public void howTP()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void sair()
    {
        Application.Quit();
    }
}
