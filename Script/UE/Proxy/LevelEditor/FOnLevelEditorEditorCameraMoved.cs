using System;
using Script.CoreUObject;
using Script.Library;
using Script.UnrealEd;

namespace Script.LevelEditor
{
	public class FOnLevelEditorEditorCameraMoved : FMulticastDelegate<Action<FVector, FRotator, ELevelViewportType, int>>
	{
		public FOnLevelEditorEditorCameraMoved() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnLevelEditorEditorCameraMoved() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FVector Location, FRotator Rotation, ELevelViewportType ViewportType, int ViewIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)ViewportType;

				*(int*)(__InBuffer + 17) = ViewIndex;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
