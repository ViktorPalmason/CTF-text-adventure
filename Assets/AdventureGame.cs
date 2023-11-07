using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;

    // Start is called before the first frame update
    void Start()
    {
        string introText = "Get up Hector! If you get handle this than you will never rank up.";
        textComponent.text = introText;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
