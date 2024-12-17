using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.PlacedEditorUtilityBase")]
	public partial class ADEPRECATED_PlacedEditorUtilityBase : AActor, IStaticClass
	{
		public FString HelpText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HelpText, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HelpText, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.PlacedEditorUtilityBase");
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

		public virtual void SetActorSelectionState(AActor Actor, bool bShouldBeSelected)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldBeSelected;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActorSelectionState, __InBuffer);
			}
		}

		public virtual void SelectNothing()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SelectNothing);
			}
		}

		public virtual TArray<AActor> GetSelectionSet()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelectionSet, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
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

		/// <param name="PathToActor">
		/// The path to the actor (e.g. PersistentLevel.PlayerStart)
		/// </param>
		/// <returns>
		/// A reference to the actor, or none if it wasn't found
		/// </returns>
		public virtual AActor GetActorReference(FString PathToActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PathToActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetActorReference, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual void ClearActorSelectionSet()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearActorSelectionSet);
			}
		}

		private static uint __HelpText = 0;

		private static uint __SetLevelViewportCameraInfo = 0;

		private static uint __SetActorSelectionState = 0;

		private static uint __SelectNothing = 0;

		private static uint __GetSelectionSet = 0;

		private static uint __GetLevelViewportCameraInfo = 0;

		private static uint __GetActorReference = 0;

		private static uint __ClearActorSelectionSet = 0;
	}
}