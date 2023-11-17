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

        // loop through the array of next optional states
        for (int index = 0; index < nextStates.Length; index++)
        {
            // Check if the an alpha key corresponding to one of the options in a state is pressed.
            //
            // The length of the array matches the number of options pressented in a state so
            // we increment index by one up to the length of the array and use it
            // to check each alpha key corresponding to an option.
            if(Input.GetKeyDown(KeyCode.Alpha1 + index) && nextStates[index] != null)
            {
                state = nextStates[index];
            }
        }

        textComponent.text = state.GetStateStory();
    }
}
