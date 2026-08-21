using UnityEngine;

public class ButtonFnaf : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject buttonRight;
    [SerializeField] GameObject buttonLeft;

    public void Awake()
    {
    }
    public void LeftSide()
    {
        animator.SetTrigger("leftTurn");
    }

    public void RightSide()
    {
        animator.SetTrigger("rightTurn");
        //buttonLeftR.SetActive(true);
    }
}
