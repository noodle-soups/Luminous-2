using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Material playerMaterial;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

        float _xInput = Input.GetAxisRaw("Horizontal");
        float _zInput = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(_xInput, 0f, _zInput) * 5f;
        
    }

    public void ChangeColor(Color _newColor)
    {
        playerMaterial.color = _newColor;
    }
}
