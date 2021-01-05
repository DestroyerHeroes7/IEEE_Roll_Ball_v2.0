using UnityEngine;
public class Player : MonoBehaviour
{
    public float x;
    public float z;
    public float speed;
    public Rigidbody rigidbody;
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(x * speed, 0, z * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
}
