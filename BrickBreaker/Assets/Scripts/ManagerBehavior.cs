using UnityEditor;
using UnityEngine;
using TMPro;

public class ManagerBehavior : MonoBehaviour
{
    static public ManagerBehavior Instance;
    
    //scoring variables
    private int _score = 0;
    [SerializeField] private TMP_Text _scoreUI;
    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            _scoreUI.text = Score.ToString();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            Debug.Log("New instance initialized.");
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
            Debug.Log("duplicate instance found, deleting.");
        }
    }

    public void ScorePoint()
    {
        Score += 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Start()
    {
        
    }
}
