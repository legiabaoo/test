using UnityEngine;

public class dichuyen2 : MonoBehaviour
{
    public float dichuyen;
    public float tocdo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //dichuyen
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dichuyen = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            dichuyen = 1;
        }
        else dichuyen = 0;
        //
        transform.Translate(Vector3.right * tocdo * dichuyen * Time.deltaTime);
    }
}