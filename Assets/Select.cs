using UnityEngine;
using UnityEngine.UI;
public class Select : MonoBehaviour
{
    public Button Next;
    private bool isSelect;

    public void Selected()
    {
        isSelect = true;
        Next.interactable = true;
    }
}
