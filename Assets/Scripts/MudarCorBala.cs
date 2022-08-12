using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarCorBala : MonoBehaviour
{
    List<Color> cores = new List<Color>();
    SpriteRenderer bola;
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

        bola = GetComponent<SpriteRenderer>();
        int numC = Random.Range(0, 10);
        bola.color = cores[numC];
    }
}
