using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd.ImportSubsystem
{
	public class FOnAssetReimport_Dyn : FMulticastDelegate<Action<UObject>>
	{
		public FOnAssetReimport_Dyn() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAssetReimport_Dyn() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UObject InCreatedObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InCreatedObject?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
