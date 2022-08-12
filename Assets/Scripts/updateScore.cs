using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class updateScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI normalScoreTXT;
    int teste;
    // Start is called before the first frame update
    void Start()
    {
        //varScore = GameObject.Find("Bala").GetComponent<Bala>();
    }

    // Update is called once per frame
    void Update()
    {
        teste = Bala.score;
        normalScoreTXT.text = "S C O R E : " + teste;
    }
}
