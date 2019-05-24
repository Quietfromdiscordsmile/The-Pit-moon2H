using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyCharacter : MonoBehaviour
{
    public string playerName;
    public int maxHealth;
    public int health;
    public bool isTurn = false; //current turn

    //public Skill skill1;
    //public Skill skill2;

    public Animator anim;

    void Update() {

    }

    void BasicAttack(EnemyCharacter target, int damage) {

    }
}
