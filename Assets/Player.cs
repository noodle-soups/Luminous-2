using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody rb;
    private Material playerMaterial;

    [SerializeField] private Color playerBaseColor;

    [SerializeField] private float maxCharge = 5f;
    [SerializeField] private float currentCharge = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {

        float _xInput = Input.GetAxisRaw("Horizontal");
        float _zInput = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(_xInput, 0f, _zInput) * 5f;

        if (currentCharge > 0f)
        {
            currentCharge -= Time.deltaTime;
            if (currentCharge < 0f)
                currentCharge = 0f;
        }

        if (currentCharge == 0f)
            playerMaterial.color = playerBaseColor;

    }

    public void ChangeColor(Color _newColor, float _charge)
    {
        playerMaterial.color = _newColor;
        
        if (currentCharge < maxCharge)
        {
            currentCharge += _charge;
            if (currentCharge > maxCharge)
                currentCharge = maxCharge;
        }
        
    }

}
