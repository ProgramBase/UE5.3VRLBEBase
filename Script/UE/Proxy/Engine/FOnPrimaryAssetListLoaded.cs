using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnPrimaryAssetListLoaded : FMulticastDelegate<Action<TArray<UObject>>>
	{
		public FOnPrimaryAssetListLoaded() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnPrimaryAssetListLoaded() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<UObject> Loaded)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Loaded?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
