using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd.ImportSubsystem
{
	public class FOnAssetPostLODImport_Dyn : FMulticastDelegate<Action<UObject, int>>
	{
		public FOnAssetPostLODImport_Dyn() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAssetPostLODImport_Dyn() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UObject InObject, int InLODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InLODIndex;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
