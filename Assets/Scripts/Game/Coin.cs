using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)//collision là va chạm mà 2 đối tượng không đi qua nhau
    {
        if(collision.transform.tag == "Player")//tìm kiếm tối tượng có key là Player
        {
            PlayerManager.numberOfCoins++;//số coin tăng lên
            //PlayerPrefs.SetInt("NumberOfCoins", PlayerManager.numberOfCoins);
            Destroy(gameObject);// hàm hủy 1 obj sau mỗi lần cập nhận frame
            //Destroy(gameObject,0.5f)
            //nếu không set time thì coin sẽ cộng luôn, nếu set time thì phụ thuộc vào code
        }
    }
}
