using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FWidgetAnimationResult : FMulticastDelegate<Action>
	{
		public FWidgetAnimationResult() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FWidgetAnimationResult() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
