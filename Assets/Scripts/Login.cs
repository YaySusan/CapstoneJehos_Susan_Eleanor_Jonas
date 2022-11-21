using JetBrains.Annotations;
using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Login : MonoBehaviour
{
    public TMP_Text message;
    public TMP_InputField username;
    public TMP_InputField password;
    public TMP_InputField netWorth;

    public GameObject Player;
    public GameObject VillageSpawnPoint;
    public GameObject CitySpawnPoint;
    /*public Animation loginAnimation;*/

    private string usernameInput;
    private string passwordInput;
    private float netWorthInput;
    /*private bool loginButtonClicked;*/

    public void Update()
    {
        /*loginButtonClicked = false; 
        
        if (loginButtonClicked)
        {
            loginAnimation.SetBool("Click", true);
        }*/
    }

    public void OnMouseDown()
    {

        usernameInput = username.text;
        passwordInput = password.text;
        netWorthInput = float.Parse(netWorth.text);

        /*loginButtonClicked=true;*/

        if ((usernameInput == "Jehos") && (passwordInput == "password"))
        {
            if (netWorthInput >= 4500000)
            {
                message.text = "Welcome to the Medieval City House";
                Player.transform.position = CitySpawnPoint.transform.position;
                Player.transform.rotation = CitySpawnPoint.transform.rotation;
            }
            if (netWorthInput >= 1000000 && netWorthInput < 4500000)
            {
                message.text = "Welcome to the Medieval Village House";
                Player.transform.position = VillageSpawnPoint.transform.position;
                Player.transform.rotation = VillageSpawnPoint.transform.rotation;
            }
            if (netWorthInput < 1000000)
            {
                message.text = "Sorry! Come back next time when you're eligible";

            }

        }
        else
        {
            message.text = "The username or password you entered was incorrect";

        }
    }

}
