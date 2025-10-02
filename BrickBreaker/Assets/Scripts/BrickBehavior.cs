using UnityEngine;

public class BrickBehavior : MonoBehaviour
{
    //ManagerBehavior manager = GetComponent<ManagerBehavior>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ball")) Destroy(gameObject);
        ManagerBehavior.Instance.ScorePoint();
    }
}
