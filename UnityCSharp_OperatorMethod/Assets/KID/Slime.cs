using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    [Header("血量")]
    public float hp;
    [Header("攻擊力")]
    public float atk;
    [Header("治癒量")]
    public float cure;
    [Header("蝙蝠")]
    public Bat bat;
    [Header("顯示訊息")]
    public Text message;

    public void Attack()
    {
        bat.Damage(atk);
    }

    public void Damage(float damage)
    {
        hp -= damage;
        message.text = "<color=#94a013>" + gameObject.name + "</color> - 受到傷害：" + damage;
        message.text += "\n" + "<color=#94a013>" + gameObject.name + "</color> - 血量剩下：" + hp;
    }

    public void Cure()
    {
        hp += cure;
        message.text = "<color=#94a013>" + gameObject.name + "</color> - 收到治癒：" + cure;
        message.text += "\n" + "<color=#94a013>" + gameObject.name + "</color> - 血量剩下：" + hp;
    }
}
