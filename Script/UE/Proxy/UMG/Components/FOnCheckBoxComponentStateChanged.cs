using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnCheckBoxComponentStateChanged : FMulticastDelegate<Action<bool>>
	{
		public FOnCheckBoxComponentStateChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnCheckBoxComponentStateChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(bool bIsChecked)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsChecked;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
