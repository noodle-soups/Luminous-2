using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarKey : MonoBehaviour
{

    [SerializeField] private GameObject keyColorObject;
    private Color keyColor;
    private Material material;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
        keyColor = keyColorObject.GetComponent<Renderer>().material.color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Color _playerColor = collision.gameObject.GetComponent<Renderer>().material.color;

            if (_playerColor == keyColor)
            {
                material.color = _playerColor;
            }
            else
            {
                Debug.Log("No");
            }
        }
    }

}
