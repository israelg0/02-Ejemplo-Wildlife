using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float linealSpeed = 10f;
    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        this.transform.Translate(translation:linealSpeed * Time.deltaTime * Vector3.right * horizontalInput);
        this.transform.Translate(translation:linealSpeed * Time.deltaTime * Vector3.forward * verticalInput);

        if (transform.position.x < -15)
        {
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 15)
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        
        
        //Acciones de Jugador
        if (Input.GetKey(KeyCode.Space))
        {
            //Lanzamos un proyectil
            //Instanciamos uno de los prefabs que como tiene el script de movimiento se lanzará.
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }

    }
}
