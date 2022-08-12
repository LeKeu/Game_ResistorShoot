using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    [SerializeField] GameObject inimigo;
    [SerializeField] float tempo_respawn;
    [SerializeField] GameObject p1;
    [SerializeField] GameObject p2;
    [SerializeField] GameObject p3;
    [SerializeField] GameObject p4;
    List<GameObject> iList = new List<GameObject>();
    List<Color> cores = new List<Color>();
    SpriteRenderer testinho;

    void Start()
    {

        iList.Add(p1);
        iList.Add(p2);
        iList.Add(p3);
        iList.Add(p4);

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

        StartCoroutine(inimigo_wave());
        Instantiate(inimigo);
        inimigo.transform.position = new Vector2(20, -80);
    }

    private void criar_inimigo()
    {
        Instantiate(inimigo);

        int num = Random.Range(0, 4);
        int numC = Random.Range(0, 10);
        testinho = inimigo.GetComponent<SpriteRenderer>();
        testinho.color = cores[numC];
        inimigo.transform.position = new Vector2(iList[num].transform.position.x, iList[num].transform.position.y);

    }


    IEnumerator inimigo_wave()
    {
        while (true)
        {
            yield return new WaitForSeconds(tempo_respawn); //aparentemente, isso faz esperar x segundos antes de prosseguir
            criar_inimigo();
        }
    }


}
