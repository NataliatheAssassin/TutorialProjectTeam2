using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSystem : MonoBehaviour
{
    public static int stageNumber = 1;

    [SerializeField] GameObject[] enemy, box, item;

    private void OnEnable()
    {
        SetStage();
    }

    public void SetStage()
    {
        //���� �ؿ� �ִ� �͵��� �ϴ� �׽�Ʈ��... ����
        if (stageNumber == 1)
        {
            for (int i=1; i<6; i++)
            {
                Instantiate(enemy[0], new Vector2(-i * 2, i), transform.rotation);
                Instantiate(enemy[0], new Vector2(i * 2, i), transform.rotation);
                Instantiate(enemy[0], new Vector2(-i * 2, -i), transform.rotation);
                Instantiate(enemy[0], new Vector2(i * 2, -i), transform.rotation);
            }
            Instantiate(box[0], new Vector2(0f, 5f), transform.rotation);
            Instantiate(box[1], new Vector2(0f, -5f), transform.rotation);
            Instantiate(item[0], new Vector2(0f, 7f), transform.rotation);
        }
        else if (stageNumber == 2)
        {

        }
        else if (stageNumber == 3)
        {

        }
        else if (stageNumber == 4)
        {

        }
        else if (stageNumber == 5)
        {

        }
    }
}
