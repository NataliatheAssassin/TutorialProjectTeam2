using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    protected Player player { get => FindObjectOfType<Player>(); }

    [SerializeField] protected GameObject obtainEffect;
}
