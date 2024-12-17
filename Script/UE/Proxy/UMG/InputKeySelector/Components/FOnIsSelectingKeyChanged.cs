using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG.InputKeySelector
{
	public class FOnIsSelectingKeyChanged : FMulticastDelegate<Action>
	{
		public FOnIsSelectingKeyChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnIsSelectingKeyChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
