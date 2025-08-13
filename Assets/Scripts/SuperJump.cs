using UnityEngine;

public class SuperJump : MonoBehaviour
{
    public float power = 500f;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ãæµ¹ °¨ÁöµÊ!");
            Rigidbody playerRb = other.gameObject.GetComponent<Rigidbody>();
            if (playerRb != null)
            {
                playerRb.AddForce(Vector3.up * power, ForceMode.Impulse);
            }
        }
    }
}
