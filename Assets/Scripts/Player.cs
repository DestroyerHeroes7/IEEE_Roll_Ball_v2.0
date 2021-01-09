using UnityEngine;
public class Player : MonoBehaviour
{
    public UIManager uiManager;

    public float timer;

    public float x;
    public float z;
    public float speed;
    public float jumpPower;

    public bool isGround;
    public bool isGameEnd;

    public Rigidbody rigidbody;

    public int collectedCoinCount;
    void Update()
    {
        if(!isGameEnd)
            timer += Time.deltaTime;
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
            Jump();
    }
    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(x * speed, rigidbody.velocity.y, z * speed);
    }
    private void Jump()
    {
        rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Platform"))
            isGround = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Platform"))
            isGround = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            collectedCoinCount++;
            uiManager.OnScore(collectedCoinCount);
            if (collectedCoinCount >= Global.coinCountForWin)
                GameEnd();
        }
    }
    public void GameEnd()
    {
        speed = 0;
        isGameEnd = true;
        uiManager.OnGameEnd();
    }
}
