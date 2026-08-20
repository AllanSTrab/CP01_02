using UnityEngine;

public class ButtonFnaf : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject buttonRight;
    [SerializeField] GameObject buttonLeft;
    [SerializeField] GameObject buttonRightL;
    [SerializeField] GameObject buttonLeftR;

    public void Awake()
    {
        if(buttonRightL != null) buttonRightL.SetActive(false);
        if (buttonLeftR != null) buttonLeftR.SetActive(false);
    }
    public void LeftSide()
    {
        animator.SetTrigger("LeftTurn");
        buttonRightL.SetActive(true);
    }

    public void RightSide()
    {
        animator.SetTrigger("RightTurn");
        buttonLeftR.SetActive(true);
    }
    public void LtoRTurn()
    {
        animator.SetTrigger("LtoRTurn");
        buttonLeft.SetActive(true);
        buttonRight.SetActive(true);
        buttonRightL.SetActive(false);
    }

    public void RtoLTurn()
    {
        animator.SetTrigger("RtoLTurn");
        buttonLeft.SetActive(true);
        buttonRight.SetActive(true);
        buttonLeftR.SetActive(false);
    }
}
