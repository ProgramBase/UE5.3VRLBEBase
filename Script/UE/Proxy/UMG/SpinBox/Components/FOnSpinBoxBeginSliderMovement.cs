using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG.SpinBox
{
	public class FOnSpinBoxBeginSliderMovement : FMulticastDelegate<Action>
	{
		public FOnSpinBoxBeginSliderMovement() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnSpinBoxBeginSliderMovement() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
