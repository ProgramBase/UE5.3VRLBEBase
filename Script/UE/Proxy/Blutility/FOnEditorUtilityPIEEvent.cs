using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	public class FOnEditorUtilityPIEEvent : FMulticastDelegate<Action<bool>>
	{
		public FOnEditorUtilityPIEEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnEditorUtilityPIEEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(bool bIsSimulating)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsSimulating;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
