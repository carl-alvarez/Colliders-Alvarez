using UnityEngine;

public class Test : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 10f;      

    public bool entroAlPortal = false;
    



    void OnTriggerEnter(Collider collision)
    {
        entroAlPortal = !entroAlPortal;

        if (collision.transform.gameObject.name == "Portal")
        {

            if (transform.localScale.x == 1 && transform.localScale.y == 3 && transform.localScale.z == 1)
            {
                Achicar();

            }

        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (entroAlPortal)
        {
            return;
        }

        if (other.gameObject.name == "Portal")
        {
            if (transform.localScale.x == 0.5 && transform.localScale.y == 1.5 && transform.localScale.z == 0.5)
            {
                Descalar();
                
            }
        }
    }

    void Start()
    {
        
        
    }

    void Update()
    {
        CheckMovement();
        CheckRotation();
    }

    void CheckMovement()
    {
        var xMove = transform.right * (Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime);
        var zMove = transform.forward * (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime);
        var move = xMove + zMove;

        transform.position += move;
    }

    void CheckRotation()
    {
        var rotation = Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime * 500;

        transform.Rotate(0f, rotation, 0f);
    }

    void Achicar()
    {
        transform.localScale = transform.localScale * 0.5f;
    }
    void Descalar()
    {
        transform.localScale = new Vector3(1, 3, 1);
        
    }

}  
    




