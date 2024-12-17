using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.MediaAssets
{
	public class FOnMediaPlayerMediaEvent : FMulticastDelegate<Action>
	{
		public FOnMediaPlayerMediaEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMediaPlayerMediaEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
