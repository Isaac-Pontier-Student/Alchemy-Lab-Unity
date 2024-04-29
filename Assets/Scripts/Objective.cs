using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    [SerializeField] private string objectiveText = "I am an objective!";
    //[SerializeField] private string completedText = "Objective completed.";
     
    public UnityEvent onCompleteObjective = new UnityEvent();

    [SerializeField] private Text objectiveDisplay; //the text display gameobject is set in editor

    private void OnEnable() //called as soon as the object is enabled/active
    {
        objectiveDisplay.text = objectiveText;
    }

    public void CompleteObjective()
    {
        if (gameObject.activeSelf)
        {
            objectiveDisplay.text = "";
            onCompleteObjective.Invoke();
            gameObject.SetActive(false);
        }
    }
}
