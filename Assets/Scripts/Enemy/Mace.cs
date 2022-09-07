using UnityEngine;

public class Mace : MonoBehaviour
{
    public float speed = 0.8f;
    public float range = 10;

    float startingY; // bắt đầu từ y
    int dir = 1;//hướng mặc định
    // Start is called before the first frame update
    void Start()
    {
        startingY = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime * dir);
        //vị trí y của kẻ thù nhỏ hơn vị trí y bắt đầu và vt y kẻ thù lớn hơn vị trí y bắt đầu + phạm vi

        if (transform.position.y < startingY || transform.position.y > startingY + range)
            dir *= -1;//đảo ngược hướng
    }
}
