using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middlePipeScript : MonoBehaviour
{
    public LogicManagerScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        logic.addScore();
    }
}
