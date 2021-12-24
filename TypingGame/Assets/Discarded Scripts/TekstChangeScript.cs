using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               // Moduł do edytowania UI poprzez kod ???

public class TekstChangeScript : MonoBehaviour
{
    private string text = "";
    public Text textToBeTyped;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textToBeTyped.text = text;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            text = "Wcisnąłeś Space";
        }
    }
}
