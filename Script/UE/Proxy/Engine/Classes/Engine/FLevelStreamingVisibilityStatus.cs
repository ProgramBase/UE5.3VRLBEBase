using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FLevelStreamingVisibilityStatus : FMulticastDelegate<Action>
	{
		public FLevelStreamingVisibilityStatus() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FLevelStreamingVisibilityStatus() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
