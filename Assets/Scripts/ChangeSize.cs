using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    [SerializeField] private float modifiedScale = 2.0f;
    private Vector3 initialScale;
    private bool isScaled = false;
    [SerializeField] private float changeRate = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        //when the game first starts, this IS running, but it's constantly "moving" towards the initalScale because isScaled is by default false. Once we interact, we change that
        transform.localScale = Vector3.MoveTowards(transform.localScale, GetTargetScale(), changeRate * Time.deltaTime); //1st is the start, 2nd is the target, 3rd is the max changing speed
        //need to use new function GetTargetScale to get the target scale, since target will be modified if at initial, but initial if already modified
    }

    private Vector3 GetTargetScale()
    {
        return isScaled ? initialScale * modifiedScale : initialScale; //inline if statement. Says if isScaled is true, return  Vector3.one * modifiedScale, else return initialScale
    }

    public void ToggleScale()
    {
        isScaled = !isScaled;
    }
}
