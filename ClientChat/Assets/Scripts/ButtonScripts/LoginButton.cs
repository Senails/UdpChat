using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoginButton : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData eventData)
	{
		LoginWindow.Self.login();
	}
}
