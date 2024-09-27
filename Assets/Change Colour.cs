using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{

    private Color thisColor;
    [SerializeField] private GameObject player;
    private PlayerMovement playerMovement;

    private void Start()
    {
        thisColor = GetComponent<Renderer>().material.color;
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hit " + player.tag);
            playerMovement.ChangeColor(thisColor);
        }
    }

}
