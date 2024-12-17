using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.UnrealEditorSubsystem")]
	public partial class UUnrealEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.UnrealEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="CameraLocation">
		/// Location the camera will be moved to.
		/// </param>
		/// <param name="CameraRotation">
		/// Rotation the camera will be set to.
		/// </param>
		public virtual void SetLevelViewportCameraInfo(FVector CameraLocation, FRotator CameraRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = CameraLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CameraRotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLevelViewportCameraInfo, __InBuffer);
			}
		}

		/// <param name="CameraLocation">
		/// (out) Current location of the level editing viewport camera, or zero if none found
		/// </param>
		/// <param name="CameraRotation">
		/// (out) Current rotation of the level editing viewport camera, or zero if none found
		/// </param>
		/// <returns>
		/// Whether or not we were able to get a camera for a level editing viewport
		/// </returns>
		public virtual bool GetLevelViewportCameraInfo(ref FVector CameraLocation, ref FRotator CameraRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = CameraLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CameraRotation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetLevelViewportCameraInfo, __InBuffer, __OutBuffer, __ReturnBuffer);

				CameraLocation = *(FVector*)(__OutBuffer);

				CameraRotation = *(FRotator*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UWorld GetGameWorld()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGameWorld, __ReturnBuffer);

				return *(UWorld*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The World used by the world editor.
		/// </returns>
		public virtual UWorld GetEditorWorld()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEditorWorld, __ReturnBuffer);

				return *(UWorld*)__ReturnBuffer;
			}
		}

		private static uint __SetLevelViewportCameraInfo = 0;

		private static uint __GetLevelViewportCameraInfo = 0;

		private static uint __GetGameWorld = 0;

		private static uint __GetEditorWorld = 0;
	}
}