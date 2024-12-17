using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput.EnhancedInputLocalPlayerSubsystem
{
	public class FOnControlMappingsRebuilt : FMulticastDelegate<Action>
	{
		public FOnControlMappingsRebuilt() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnControlMappingsRebuilt() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
