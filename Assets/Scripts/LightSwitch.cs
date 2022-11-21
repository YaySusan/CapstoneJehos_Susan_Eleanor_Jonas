using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    private bool lampState = false;
    public GameObject[] lamp;
    public AudioSource lightSwitchSound;
    public int numberOfLamps;



    private void OnMouseDown()
    {
        lightSwitchSound.Play();
        //foreach (GameObject light in lamp)
            if (!lampState)
            { 
                for (int i = 0; i < numberOfLamps; i++)
                {
                lamp[i].SetActive(false);
                    lampState = true;
                }
            }
            else
            {
                for (int i = 0; i < numberOfLamps; i++)
                {
                    lamp[i].SetActive(true);
                    lampState = false;
                }

            }

    }
}
