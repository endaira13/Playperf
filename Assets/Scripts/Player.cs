using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private SaveManager saveManager;

    public float speed = 5f;
    private CharacterController controller;
    private Transform cam;
    private Vector3 playerVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        cam = Camera.main.transform;
        saveManager = GameObject.Find("Player").GetComponent<SaveManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

        if(move != Vector3.zero)
        {
            float targetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Azul"))
        {
            saveManager.Cubo();
            saveManager.Azul();
        }

        if(other.gameObject.CompareTag("Amarillo"))
        {
            saveManager.Cubo();
            saveManager.Amarillo();
        }

        if(other.gameObject.CompareTag("Verde"))
        {
            saveManager.Cubo();
            saveManager.Verde();
        }
    }
    




  

}

