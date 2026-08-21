using UnityEngine;

public class ButtonFnaf : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject buttonRight;
    [SerializeField] GameObject buttonLeft;
    [SerializeField] GameObject buttonBackLeft;
    [SerializeField] GameObject buttonBackRight;

    public void Awake()
    {
        if(buttonBackLeft != null) buttonBackLeft.SetActive(false);
        if (buttonBackRight != null) buttonBackRight.SetActive(false);
    }
    public void LeftSide()
    {
        animator.SetTrigger("leftTurn");
        buttonBackLeft.SetActive(true);
        buttonLeft.SetActive(false);
        buttonRight.SetActive(false);
    }

    public void RightSide()
    {
        animator.SetTrigger("rightTurn");
        buttonBackRight.SetActive(true);
        buttonLeft.SetActive(false);
        buttonRight.SetActive(false);
    }

    public void BackLeft()
    {
        animator.SetTrigger("backLeft");
        buttonBackLeft.SetActive(false);
        buttonLeft.SetActive(true);
        buttonRight.SetActive(true);
    }

    public void BackRight()
    {
        animator.SetTrigger("backRight");
        buttonBackRight.SetActive(false);
        buttonLeft.SetActive(true);
        buttonRight.SetActive(true);
    }
}
