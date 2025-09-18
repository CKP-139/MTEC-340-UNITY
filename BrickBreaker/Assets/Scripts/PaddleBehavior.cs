using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    public float Speed = 5.0f;

    public KeyCode LeftDirection;
    public KeyCode RightDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float movement = 0.0f;
        if (Input.GetKey(LeftDirection))
        {
            movement -= Speed;
        }
        if (Input.GetKey(RightDirection))
        {
            movement += Speed;
        }
        transform.position += new Vector3(movement * Time.deltaTime, 0.0f, 0.0f);
    }
    void OnCollisionEnter(Collision collision)
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
}
