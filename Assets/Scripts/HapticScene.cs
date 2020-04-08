using BlackBears.GameCore.Features.Vibration;
using UnityEngine;

public class HapticScene : MonoBehaviour
{
	public void Heavy()
	{
		IOSNative.StartHapticFeedback(HapticFeedbackTypes.HEAVY);
	}

	public void Medium()
	{
		IOSNative.StartHapticFeedback(HapticFeedbackTypes.MEDIUM);

	}

	public void Soft()
	{
		IOSNative.StartHapticFeedback(HapticFeedbackTypes.SOFT);
	}
	
	public void Light()
	{
		IOSNative.StartHapticFeedback(HapticFeedbackTypes.LIGHT);
	}
	public void Rigid()
	{
		IOSNative.StartHapticFeedback(HapticFeedbackTypes.RIGID);
	}

	public void VibratePop()
	{
		Vibration.VibratePop();
	}
	public void VibratePeek()
	{
		Vibration.VibratePeek();
	}
	public void VibrateNope()
	{
		Vibration.VibrateNope();
	}
}
