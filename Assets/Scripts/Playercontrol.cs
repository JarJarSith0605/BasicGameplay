using UnityEngine;

public class Playercontrol : MonoBehaviour





{
public GameObject projectilePrefab;


    public float horizontalInput;
    public float speed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
    if (transform.position.x < -10) {
        transform.position = new Vector3(-10, transform.position.y, transform.position.z);
    
    }
    {
     if (transform.position.x > 10) {
        transform.position = new Vector3(10, transform.position.y, transform.position.z);
     }
    {
    
    horizontalInput = Input.GetAxis ("Horizontal");
    transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    if (Input.GetKeyDown(KeyCode.Space))
    {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
    }
    }
}
}