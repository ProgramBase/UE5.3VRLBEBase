using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnClusterUnionAddedComponent : FMulticastDelegate<Action<UPrimitiveComponent, TSet<int>, bool>>
	{
		public FOnClusterUnionAddedComponent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnClusterUnionAddedComponent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UPrimitiveComponent Component, TSet<int> BoneIds, bool bIsNew)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneIds?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bIsNew;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
