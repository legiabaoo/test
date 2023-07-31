using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float start, end;
    private bool isRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var namX = transform.position.x;
        if(namX < start)
        {
            isRight = true;
        }
        if(namX > end)
        {
            isRight = false;
        }
        if(isRight)
        {
            transform.Translate(new Vector3(Time.deltaTime * 1, 0, 0));
        }
        else
        {
            transform.Translate(new Vector3(-Time.deltaTime * 1, 0, 0));
        }
    }
}
