using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	public class FOnSampleLoaded : FMulticastDelegate<Action>
	{
		public FOnSampleLoaded() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnSampleLoaded() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
