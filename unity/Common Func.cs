if (Input.GetMouseButtonDown(0)) // 0��ʾ�����1��ʾ�Ҽ���2��ʾ�м�
{
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;

    if (Physics.Raycast(ray, out hit))
    {
        // ��⵽���屻���
        if (hit.collider != null)
        {
            // �������д����¼��Ĵ����߼�
            Debug.Log("���屻����ˣ�");
        }
    }
}//�����