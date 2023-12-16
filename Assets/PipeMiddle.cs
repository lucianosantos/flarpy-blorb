using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public LogicManager logic;
    private bool isTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && !isTriggered)
        {
            logic.addScore(1);
            isTriggered = true;
        }
    }
}
