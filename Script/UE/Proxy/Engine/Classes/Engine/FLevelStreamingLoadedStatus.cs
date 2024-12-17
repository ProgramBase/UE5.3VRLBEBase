using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FLevelStreamingLoadedStatus : FMulticastDelegate<Action>
	{
		public FLevelStreamingLoadedStatus() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FLevelStreamingLoadedStatus() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
