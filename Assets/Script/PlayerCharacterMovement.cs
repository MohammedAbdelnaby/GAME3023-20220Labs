using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEditor.PackageManager.UI;
using UnityEditor.UI;
using UnityEngine;

public class PlayerCharacterMovement : MonoBehaviour
{
    [SerializeField]
    [Range(0f, 1000f)]
    private float MoveSpeed = 10.0f;

    [SerializeField]
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxisRaw("Horizontal");
        float Y = Input.GetAxisRaw("Vertical");

        Vector3 oldPosition = transform.position;
        rb.MovePosition(oldPosition + new Vector3(X, Y, 0) * MoveSpeed * Time.deltaTime);
        //transform.position = oldPosition + new Vector3(X, Y, 0) * MoveSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
