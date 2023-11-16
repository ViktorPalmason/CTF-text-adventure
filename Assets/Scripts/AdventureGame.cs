using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }
    // Update is called once per frame
    void Update()
    {
        ManageState();

    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        if (Input.GetKeyDown(KeyCode.Alpha1) && nextStates.Length > 0)
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && nextStates.Length > 1)
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && nextStates.Length > 2)
        {
            state = nextStates[2];
        }

        textComponent.text = state.GetStateStory();
    }
}