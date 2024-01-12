if (Input.GetMouseButtonDown(0)) // 0表示左键，1表示右键，2表示中键
{
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;

    if (Physics.Raycast(ray, out hit))
    {
        // 检测到物体被点击
        if (hit.collider != null)
        {
            // 在这里编写点击事件的处理逻辑
            Debug.Log("物体被点击了！");
        }
    }
}//鼠标点击

摄像机跟随玩家
public Transform playerTransform;
    public float distanceZ = 5f;
    public float distanceY = 5f;
    public float rotationSpeed = 5f;

    void Update()
    {
        if (playerTransform != null)
        {
            // 计算相对于玩家的位置
            Vector3 relativePosition = new Vector3(0, distanceY, -distanceZ);

            // 获取玩家正后方的方向
            Vector3 playerBackwardDirection = -playerTransform.forward;

            // 计算相机的最终位置
            Vector3 targetPosition = playerTransform.position + playerBackwardDirection * distanceZ + Vector3.up * distanceY;

            // 平滑移动相机
            transform.position = Vector3.Lerp(transform.position, targetPosition, rotationSpeed * Time.deltaTime);

            // 始终朝向玩家
            transform.LookAt(playerTransform);
        }
    }
玩家移动
public float speed = 5f; // 控制移动速度
public float rotationSpeed; // 控制旋转速度

void Update()
{
        // 获取玩家输入
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");
    transform.Rotate(Vector3.up * horizontal, rotationSpeed, Space.World);
    transform.Translate(transform.forward * vertical * speed * Time.deltaTime, Space.World);

}
