using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnListViewScrolledDynamic : FMulticastDelegate<Action<float, float>>
	{
		public FOnListViewScrolledDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnListViewScrolledDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(float ItemOffset, float DistanceRemaining)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = ItemOffset;

				*(float*)(__InBuffer + 4) = DistanceRemaining;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
