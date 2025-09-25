using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private Rigidbody2D _rb;
    [Range(0.0f, 1.0f)]
    [SerializeField] private float _paddleinfluence = 0.6f;
    [SerializeField] private float _launchForce = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(
            Random.Range(-1.0f, 1.0f),
            Random.Range(-1.0f, 1.0f)
        //add code to make it reroll if the direction is too horizontal
        ).normalized;
        _rb.AddForce(direction * _launchForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("paddle"))
        {
            if (!Mathf.Approximately(other.rigidbody.velocity.y, 0.0f))
            {
                Vector2 direction = _rb.velocity * (1 - _paddleinfluence) + other.rigidbody.velocity * _paddleinfluence;

                _rb.velocity = _rb.velocity.magnitude * direction.normalized;  
            }
        }
    }

}
