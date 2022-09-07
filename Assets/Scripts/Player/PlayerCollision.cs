using UnityEngine;
using System.Collections;
public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")//nếu va chạm với kẻ thù
        {
            HealthManager.health--;//số mạng giảm 1
            if(HealthManager.health <=0){//nếu health <=0 .. kết thúc game
                PlayerManager.isGameOver = true;
                gameObject.SetActive(false);//game thua
            }else{
                StartCoroutine(GetHurt());
            }
        }
    }
    IEnumerator GetHurt(){ 
        Physics2D.IgnoreLayerCollision(6,8);
        GetComponent<Animator>().SetLayerWeight(1, 1);
        yield return new WaitForSeconds(3);//yeild return + WaitForSeconds dừng hàm 3s đến dòng 22
        GetComponent<Animator>().SetLayerWeight(1, 0);
        Physics2D.IgnoreLayerCollision(6,8, false);
    }
}
