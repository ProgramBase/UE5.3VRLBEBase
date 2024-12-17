using System;
using Script.CoreUObject;
using Script.Library;
using Script.UnrealEd;

namespace Script.UnrealEd.ImportSubsystem
{
	public class FOnAssetPostImport_Dyn : FMulticastDelegate<Action<UFactory, UObject>>
	{
		public FOnAssetPostImport_Dyn() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAssetPostImport_Dyn() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UFactory InFactory, UObject InCreatedObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InFactory?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCreatedObject?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
