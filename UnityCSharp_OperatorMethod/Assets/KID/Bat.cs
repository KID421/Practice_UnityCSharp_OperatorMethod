using UnityEngine;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{
    [Header("血量")]
    public float hp;
    [Header("攻擊力")]
    public float atk;
    [Header("治癒量")]
    public float cure;
    [Header("史萊姆")]
    public Slime slime;
    [Header("顯示訊息")]
    public Text message;

    public void Attack()
    {
        slime.Damage(atk);
    }

    public void Damage(float damage)
    {
        hp -= damage;
        message.text =  gameObject.name + " - 受到傷害：" + damage;
        message.text += "\n" + gameObject.name + " - 血量剩下：" + hp;
    }

    public void Cure()
    {
        hp += cure;
        message.text =  gameObject.name + " - 收到治癒：" + cure;
        message.text += "\n" + gameObject.name + " - 血量剩下：" + hp;
    }
}
