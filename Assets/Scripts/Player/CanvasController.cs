using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public static CanvasController Instance;
    public GameObject RestartPanel;
    public int enemyCount = 36;
    public Text textRight;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reduceEnemyCount()
    {
        enemyCount--;
        textRight.text = enemyCount.ToString() + " enemy left.";
    }
}
