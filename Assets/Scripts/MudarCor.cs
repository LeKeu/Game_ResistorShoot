using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarCor : MonoBehaviour
{
    SpriteRenderer teste;
    [SerializeField] Rigidbody2D personagem;
    List<Color> cores = new List<Color>();
    int testeI = 0;
    // Start is called before the first frame update
    void Start()
    {
        cores.Add(Color.black);
        cores.Add(new Color32(123, 63, 0, 255));
        cores.Add(Color.red);
        cores.Add(new Color32(255, 140, 0, 255));
        cores.Add(Color.yellow);
        cores.Add(Color.green);
        cores.Add(Color.blue);
        cores.Add(new Color32(138, 43, 226, 255));
        cores.Add(Color.grey);
        cores.Add(Color.white);

        teste = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            teste.color = cores[testeI];
            testeI++;
            if (testeI == 10)
            {
                testeI = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown("[0]"))
        {
            teste.color = Color.black;
            //personagem.tag = "preto";
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown("[1]"))
        {
            teste.color = new Color32(123, 63, 0, 255);
            //personagem.tag = "marrom";
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown("[2]"))
        {
            teste.color = Color.red;
            //personagem.tag = "vermelho";
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown("[3]"))
        {
            teste.color = new Color32(255, 140, 0, 255);
            //personagem.tag = "laranja";
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown("[4]"))
        {
            teste.color = Color.yellow;
            //personagem.tag = "amarelo";
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown("[5]"))
        {
            teste.color = Color.green;
            //personagem.tag = "verde";
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown("[6]"))
        {
            teste.color = Color.blue;
            //personagem.tag = "azul";
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown("[7]"))
        {
            teste.color = new Color32(138, 43, 226, 255);
            //personagem.tag = "violeta";
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown("[8]"))
        {
            teste.color = Color.grey;
            //personagem.tag = "cinza";
        }
        if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown("[9]"))
        {
            teste.color = Color.white;
            //personagem.tag = "branco";
        }
    }
}
