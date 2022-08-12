using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class updateHighScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hScoreTXT;
    // Start is called before the first frame update
    void Start()
    {
        hScoreTXT.text = "H I G H  S C O R E : " + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
