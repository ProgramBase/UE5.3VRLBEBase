using System;
using Script.CoreUObject;
using Script.Library;
using Script.UnrealEd;

namespace Script.UnrealEd.ImportSubsystem
{
	public class FOnAssetPreImport_Dyn : FMulticastDelegate<Action<UFactory, UClass, UObject, FName, FString>>
	{
		public FOnAssetPreImport_Dyn() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAssetPreImport_Dyn() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UFactory InFactory, UClass InClass, UObject InParent, FName Name, FString Type)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = InFactory?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Type?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
