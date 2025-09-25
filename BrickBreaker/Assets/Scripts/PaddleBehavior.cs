using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    [Range(1.0f,10.0f)]
    public float Speed = 5.0f;

    [SerializeField] private KeyCode _LeftDirection;
    [SerializeField] private KeyCode _RightDirection;

    private float _direction;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        _rb.velocity = _direction * new Vector2(Speed, 0.0f);
    }
    // Update is called once per frame
   void Update()
    {
        _direction = 0.0f;
        if (Input.GetKey(_LeftDirection))
            _direction -= 1.0f;
            
        if (Input.GetKey(_RightDirection))
            _direction += 1.0f;
    }
    /*void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        float movement = 0.0f;
        if (collision.gameObject.name == "WallL")
        {
            movement += Speed;
        }
        if (collision.gameObject.name == "WallR")
        {
            movement -= Speed;
        }
        transform.position += new Vector3(movement * Time.deltaTime, 0.0f, 0.0f);
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name); 
        float movement = 0.0f;
        if (collision.gameObject.name == "WallL")
        {
            movement += Speed;
        }
        if (collision.gameObject.name == "WallR")
        {
            movement -= Speed;
        }
        transform.position += new Vector3(movement * Time.deltaTime, 0.0f, 0.0f);
    }*/
}
