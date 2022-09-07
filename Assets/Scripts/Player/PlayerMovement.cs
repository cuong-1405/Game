using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls controls;

    float direction = 0; //hướng
    public float speed = 400;//tốc độ
    public bool isFacingRight = true;

    public float jumpForce = 5;//lực nhảy
    bool isGrounded;
    int numberOfJumps = 3;// số lần nhảy
    public Transform groundCheck;//kiểm tra mặt đất
    public LayerMask groundLayer;//D ùng để gắn giá trị layer từ bên ngoài

    public Rigidbody2D playerRB;// di chuyển người chơi
    public Animator animator;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();
        //ctx chứa 1 số thông tin về hành động di chuyển
        //di chuyển
        controls.Land.Move.performed += ctx =>
        {
            // right return 1
            // left return -1
            // all return 0
            direction = ctx.ReadValue<float>();
        };
        // nhảy
        controls.Land.Jump.performed += ctx => Jump();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        animator.SetBool("isGrounded", isGrounded);

        playerRB.velocity = new Vector2(direction * speed * Time.fixedDeltaTime, playerRB.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(direction));
        //speed-tên tham số 
        //Mathf.Abs(direction) - giá trị tuyệt đối của hướng

        if (isFacingRight && direction < 0 || !isFacingRight && direction >0 )
            Flip();
        // kiểm tra player đang quay mặt bên nào
    }
    // hàm kiểm tra player xoay bên nào=)))
    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
    }

    void Jump()
    {
        if (isGrounded)//kiểm tra chạm đất
        {
            numberOfJumps = 3;
            playerRB.velocity = new Vector2(playerRB.velocity.x, 10);
            numberOfJumps++;
        }
        else
        {
            if(numberOfJumps == 1)
            {
                playerRB.velocity = new Vector2(playerRB.velocity.x, 5);
                numberOfJumps++;
            }
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
}
