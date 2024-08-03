using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : StageSystem
{
    //���������� �Ѿ�� ���� �ٲ�� ī�޶��� �������� �����ϱ� ���� �ڵ�.

    public void MoveToNextStage()
    {
        transform.position = new Vector3(transform.position.x + 36, transform.position.y, transform.position.z);
    }

    public void MoveToPreviousStage()
    {
        transform.position = new Vector3(transform.position.x - 36, transform.position.y, transform.position.z);
    }
}
