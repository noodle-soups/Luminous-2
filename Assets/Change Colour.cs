using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{

    [SerializeField] private GameObject player;
    private Player playerScript;

    [SerializeField] private Color thisColor;
    [SerializeField] private float colorCharge;

    private void Start()
    {
        thisColor = GetComponent<Renderer>().material.color;
        playerScript = player.GetComponent<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerScript.ChangeColor(thisColor, colorCharge);
            Debug.Log("Trigger");
        }
    }

}
