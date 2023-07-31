using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player; // nhan vat
    public float start, end; // diem bat dau va diem ket thuc cua man choi
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // lay vi tri cua nguoi choi(nhan vat)
        var playerX = player.transform.position.x;
        // lay vi tri cua cam
        var camX = transform.position.x;
        var camY = transform.position.y;
        var camZ = transform.position.z;

        if(playerX > start && playerX < end)
        {
            camX = playerX;
        }else
        {
            if (playerX < start) camX = start;
            if(playerX > end ) camX = end;
        }
        //set lai chho  camera
        transform.position = new Vector3 ( camX, camY, camZ );
    }
}
