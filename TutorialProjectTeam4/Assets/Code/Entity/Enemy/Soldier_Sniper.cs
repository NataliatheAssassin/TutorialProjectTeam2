using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier_Sniper : Enemy
{
    private Animator anim { get => GetComponent<Animator>(); }

    [SerializeField] protected GameObject attack;

    private void Awake()
    {
        maxHp = 1;
    }

    protected override void Start()
    {
        base.Start();
    }

    private void OnEnable() //������ ��쿡 ���.
    {
        StartCoroutine(Status_1());
    }

    protected override void Update()
    {
        base.Update();
        if (player != null) //���� ��Ÿ��̹Ƿ� Soldier_Gunner�� �ٸ���, ��Ÿ� ���� ������ ����
            transform.right = Vector2.Lerp(transform.right, (player.transform.position - transform.position).normalized, Time.deltaTime * 10);
    }

    IEnumerator Status_1()
    {
        while (true)
        {
            //player's not dead
            while (true)
            {
                if (player != null) { break; }
                yield return null;
            }
            yield return new WaitForSeconds(1f);

            //Attack
            anim.SetTrigger("Attack");
            GameObject temp = Instantiate(attack, transform.position, transform.rotation);
            temp.GetComponent<Attacks>().SetOwner("Enemy");
            yield return new WaitForSeconds(3f);
        }
    }

    public void InstaShootSignal()
    {
        anim.SetTrigger("Attack");
        GameObject temp = Instantiate(attack, transform.position, transform.rotation);
        temp.GetComponent<Attacks>().SetOwner("Enemy");
    }
}