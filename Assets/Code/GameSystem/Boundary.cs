using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : StageSystem
{
    //���� ���������� �Ѿ�ų�, ���� ���������� ���ư� �� �ֵ��� ���ִ� "���� �ݶ��̴�" ������ ��踦 ���� �ڵ�.

    Player player { get => FindObjectOfType<Player>(); }
    CameraController cameraController { get => FindObjectOfType<CameraController>(); }
    StageElementController stageElementController { get => FindObjectOfType<StageElementController>(); }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (player.X_VelocityOfPlayer() > 0) 
            { 
                player.transform.position = new Vector2(transform.position.x + 0.75f, player.transform.position.y); 
                cameraController.MoveToNextStage();
                stageElementController.ChangeStage(true);
            }
            else if (player.X_VelocityOfPlayer() < 0) 
            {
                player.transform.position = new Vector2(transform.position.x - 0.75f, player.transform.position.y);
                cameraController.MoveToPreviousStage(); 
                stageElementController.ChangeStage(false);
            }
            else return;
        }
    }
}
