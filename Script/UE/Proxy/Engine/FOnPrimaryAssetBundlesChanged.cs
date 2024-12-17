using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnPrimaryAssetBundlesChanged : FMulticastDelegate<Action>
	{
		public FOnPrimaryAssetBundlesChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnPrimaryAssetBundlesChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
