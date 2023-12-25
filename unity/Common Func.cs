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