using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Bien speed quy dinh toc do di chuyen
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // lay thong tin tu ban phim chieu ngang (A/D) hoac mui ten
        float horizontaInput = Input.GetAxis("Horizontal");
        // tinh vi tri moi
        float moveHorizontal = horizontaInput * speed * Time.deltaTime;

        //cap nhat vi tri moi cua doi tuong chuan bi duoc render o khung hinh tiep theo
        transform.position = new Vector2(transform.position.x + moveHorizontal, transform.position.y);
    }
}
