using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	public class FForEachAssetIteratorSignature : FMulticastDelegate<Action<UObject, int>>
	{
		public FForEachAssetIteratorSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FForEachAssetIteratorSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UObject Asset, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
