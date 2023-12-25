//——————————————————————————————————————————————————————
//各种按键方法
if (Input.GetKeyDown(KeyCode.A))
{
    //按下A键触发事件
    Destroy(other.gameObject);
}
if (Input..GetKeyUp(KeyCode.A))
{
    //松开A键触发事件
    Destroy(other.gameObject);
}
if (Input.GetMouseButtonDown(0))
{
    //点击鼠标左键触发事件
    Debug.Log("Left mouse button is clicked!");
}
//——————————————————————————————————————————————————————
//
//
//
//
//
//
gameObject.SetActive(false);//禁用组件
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//Vector3的概念和使用方法，它是三维空间向量的变量类型
//常见初始化
Vector3 vectorA = new Vector3(1f, 2f, 3f);

Vector3 upVector = Vector3.up;                          //up 表示世界坐标系的 y 轴正方向（即向上）
Vector3 rightVector = Vector3.right;                    //right 表示 x 轴正方向（即向右）
Vector3 forwardVector = Vector3.forward;                //forward 表示 z 轴正方向（即往屏幕内）
//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//Transform的Translate(方向)、Rotate(旋转)和localScale(缩放)
Transform transform = this.gameObject.transform;                    // 获取当前游戏对象的 Transform 组件

//移动物体
transform.Translate(transform.forward * Time.deltaTime);            //将物体位置沿着其前方方向移动 1 个单位
transform.Translate(new Vector3(1, 0, 1) * Time.deltaTime);         //将物体位置沿着向量 (1, 0, 1) 的方向移动 1 个单位

//旋转物体
transform.Rotate(Vector3.up, 30f, Space.World);                     //将物体绕 y 轴逆时针旋转 30 度
transform.Rotate(Vector3.forward * -45f, Space.Self);               //将物体绕 z 轴顺时针旋转 45 度
transform.rotation = Quaternion.Euler(0, 30, 0);                    //将当前物体（即脚本所挂载的游戏对象）相对于世界坐标系沿着y轴旋转30度

//缩放物体
transform.localScale = new Vector3(2f, transform.localScale.y, transform.localScale.z);//将物体沿着本地坐标系的 x 轴方向放大到原来的 2 倍

//position 是 Transform 组件的一个属性，它用于获取或设置游戏对象在世界空间坐标系中的位置。
//移动物体到指定位置
Vector3 targetPosition = new Vector3(0f, 1f, 2f);                   // 目标位置
transform.position = targetPosition;                                // 将物体移动到目标位置

//沿着指定方向移动物体
Vector3 moveDirection = new Vector3(1f, 0f, 0f);                    // 移动方向
float moveSpeed = 5f;                                               // 移动速度
transform.position += moveDirection * moveSpeed * Time.deltaTime;   // 每帧按照指定方向移动一定距离，从而实现连续移动
//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//这是用来判断角色是否接触到地面的方法，原理是在脚底板的位置放一个碰撞器，通过输入的检测半径来检测是否碰到了图层是ground的物体(这个物体要有碰撞检测器)
public float radius = 1.0f;//检测半径
public LayerMask layerMask;//检测图层
private Vector3 pos;       //检测体

void Update()
{
    // 每帧更新检测位置
    pos = transform.position;

    // 检测球形范围内是否存在碰撞体
    bool isColliding = Physics.CheckSphere(pos, radius, layerMask);//判断是否频道了图层为layerMask的物体

    // 打印结果
    if (isColliding)
    {
        Debug.Log("There is a collider in the sphere.");
    }
    else
    {
        Debug.Log("There is no collider in the sphere.");
    }
}
//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//DeltaTime，是一个只读的静态属性，用于获取上一帧和当前帧之间的时间差
float deltaTime = Time.deltaTime; //单位是秒，并且是浮点型数据
transform.position += movement * Movespeed * Time.deltaTime; // 每帧移动玩家飞机(方向乘速度乘时间)
//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//LookAt函数，用于使物体朝向特定方法
public Transform player;//玩家角色
void Update()
{
    // 获取玩家角色的坐标
    Vector3 playerPos = player.transform.position;

    // 将摄像头的朝向设置为玩家角色的位置
    transform.LookAt(playerPos);
}
//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//Lerp，线性插值函数，用来实现两个值的平滑过渡，需要指定三个值，分别是起始状态a，结束状态b，和比例程度t
float t = Mathf.PingPong(Time.time / duration, 1);//这个t需要每时每刻变化
Vector3.Lerp(a, b, t)
//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//GetAxis()，获取轴的输入
float hAxis = Input.GetAxis("Horizontal");//获取键盘水平方向输入
float vAxis = Input.GetAxis("Vertical");  //获取键盘垂直方向输入
//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//GetComponent<>()获取组件方法
Transform ts = GetComponent<Transform>();//获取自身的位置组件

GameObject gb = GameObject.Find("cube");//找到名称为cube的物体
Animator tf = gb.GetComponent<Animator>();//获取cube身上的动画控制器组件
GameObject player = GameObject.FindWithTag("Player");//找到指定标签的物体
GameObject player = GameObject.Find("Player");//找到指定名字的物体

//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//Instantiate，用于生成物体，一般输入以下参数：要生成的对象(必选)，生成的位置(可选)，生成的旋转方向(可选)
public GameObject enemyObject;  // 用于实例化的敌人预制体
GameObject enemy = Instantiate(enemyObject, enemyPoint.position, enemyPoint.rotation);//实例化enemy，位置信息和旋转信息都是生成点的
//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//数组，可以存储多个游戏对象进行操作
public GameObject[] enemies;//敌人数组
private int numEnemies = 3; //生成的敌人为3个
for (int i = 0; i < numEnemies; i++)
{
    enemies[i] = Instantiate(enemyObject, enemyPoint.position, enemyPoint.rotation);//实例化生成3个敌人
}
//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//三元运算，一种简化的条件语句；有三个操作数，第一个用来判断对错，第二个是对的返回结果，第三个是错的返回结果
int score = 80;
string result = (score >= 60) ? "及格" : "不及格";//判断有没有及格
Debug.Log(result);
//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//Invoke、InvokeRepeating 和 CancelInvoke 函数，Invoke()允许在指定延迟后或在固定时间间隔执行某个特定方法。
//Invoke
void Start()
{
    Invoke("MyMethod", 2.0f);//两秒后执行MyMethod()
}
void MyMethod()
{
    Debug.Log("Invoked method");
}
//InvokeRepeating
void Start()
{
    InvokeRepeating("MyMethod", 2f, 3f);//两秒延迟后开始执行MyMethod()，每隔三秒再执行一次，如果不关闭就会一直每三秒执行一次
}

void MyMethod()
{
    Debug.Log("Invoked method");
}
//CancelInvoke，可以关掉Invoke() 或 InvokeRepeating()
if (Input.GetKeyDown(KeyCode.C))
{
    //取消对MyMethod 的延迟调用
    CancelInvoke("MyMethod");
}
//——————————————————————————————————————————————————————
//
//
//
//
//
//
//——————————————————————————————————————————————————————
//协程StartCoroutine()
StartCoroutine(PoisonCoroutine(PoisoningTime))//执行StartCoroutine里面的PoisonCoroutine方法
private IEnumerator PoisonCoroutine(float posiontime)//这个形参是可选项，表示的是时间
{

    // 5秒内每秒扣除10滴血
    for (int i = 0; i < posiontime; i++)
    {
        TakeDamage(2.0f);
        yield return new WaitForSeconds(1);//每秒执行一次扣血，如果有多条该语句将依次执行并单独计时
    }
    //5秒后结束中毒
    Debug.Log("中毒结束");
}
//——————————————————————————————————————————————————————