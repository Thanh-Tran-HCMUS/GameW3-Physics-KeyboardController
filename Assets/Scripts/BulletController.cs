using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speedX = 5;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Gán tốc độ bay của viên đạn theo vận tóc đều = speedX
        rigid.velocity = new Vector2(speedX, rigid.velocity.y);

        //Viên đạn bay trong khoảng 2 giây sẽ tự động hủy, tránh tình trạng sinh ra đạn quá nhiều mà không hủy
        Destroy(gameObject, 2f);
    }

    
}
