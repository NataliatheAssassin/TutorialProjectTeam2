using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attacks : MonoBehaviour
{
    protected Rigidbody2D rb { get => GetComponent<Rigidbody2D>(); }

    protected string owner; public void SetOwner(string value) { owner = value; }
    protected float damage; //set with awake(inherit)
    protected float speed; //set with awake(inherit)

    [SerializeField] protected GameObject deathEffect;

    public virtual void Start()
    {
        rb.velocity = transform.right * speed;
    }

    public void Die()
    {
        GameObject temp = Instantiate(deathEffect);
        temp.transform.position = transform.position;
        Destroy(gameObject);
    }

    public virtual void OnTriggerEnter2D(Collider2D other) // <- �����ϴ� �Ѿ˵� ����� ���� �� �����Ƿ� ������ ���� virtual�� ����.
    {
        if (((other.tag == "Player" || other.tag == "Enemy") && other.tag != owner) || (other.tag == "Box"))
        {
            other.GetComponent<Entity>().TakeDamage(damage);
            Die();
        }
        else if (other.tag == "Ground")
        {
            Die();
        }
    }
}
