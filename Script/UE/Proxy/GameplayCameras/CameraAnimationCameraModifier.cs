using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.TemplateSequence;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.CameraAnimationCameraModifier")]
	public partial class UCameraAnimationCameraModifier : UCameraModifier, IStaticClass
	{
		public TArray<FActiveCameraAnimationInfo> ActiveAnimations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveAnimations, __ReturnBuffer);

					return *(TArray<FActiveCameraAnimationInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveAnimations, __InBuffer);
				}
			}
		}

		public ushort NextInstanceSerialNumber
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NextInstanceSerialNumber, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NextInstanceSerialNumber, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayCameras.CameraAnimationCameraModifier");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Hanlde">
		/// A handle to a previously started camera animation.
		/// </param>
		/// <param name="bImmediate">
		/// True to stop it right now and ignore blend out, false to let it blend out as indicated.
		/// </param>
		public virtual void StopCameraAnimation(FCameraAnimationHandle Handle, bool bImmediate = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bImmediate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopCameraAnimation, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence of which to stop all instances.
		/// </param>
		/// <param name="bImmediate">
		/// True to stop it right now and ignore blend out, false to let it blend out as indicated.
		/// </param>
		public virtual void StopAllCameraAnimationsOf(UCameraAnimationSequence Sequence, bool bImmediate = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bImmediate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAllCameraAnimationsOf, __InBuffer);
			}
		}

		/// <param name="bImmediate">
		/// True to stop it right now and ignore blend out, false to let it blend out as indicated.
		/// </param>
		public virtual void StopAllCameraAnimations(bool bImmediate = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bImmediate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAllCameraAnimations, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence to use for the new camera animation.
		/// </param>
		/// <param name="Params">
		/// The parameters for the new camera animation instance.
		/// </param>
		public virtual FCameraAnimationHandle PlayCameraAnimation(UCameraAnimationSequence Sequence, FCameraAnimationParams Params)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Params?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PlayCameraAnimation, __InBuffer, __ReturnBuffer);

				return *(FCameraAnimationHandle*)__ReturnBuffer;
			}
		}

		/// <param name="Handle">
		/// A handle to a previously started camera animation.
		/// </param>
		/// <returns>
		/// Whether the corresponding camera animation is playing or not.
		/// </returns>
		public virtual bool IsCameraAnimationActive(FCameraAnimationHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsCameraAnimationActive, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UCameraAnimationCameraModifier GetCameraAnimationCameraModifierFromPlayerController(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCameraAnimationCameraModifierFromPlayerController, __InBuffer, __ReturnBuffer);

				return *(UCameraAnimationCameraModifier*)__ReturnBuffer;
			}
		}

		public static UCameraAnimationCameraModifier GetCameraAnimationCameraModifierFromID(UObject WorldContextObject, int ControllerID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ControllerID;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCameraAnimationCameraModifierFromID, __InBuffer, __ReturnBuffer);

				return *(UCameraAnimationCameraModifier*)__ReturnBuffer;
			}
		}

		public static UCameraAnimationCameraModifier GetCameraAnimationCameraModifier(UObject WorldContextObject, int PlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = PlayerIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCameraAnimationCameraModifier, __InBuffer, __ReturnBuffer);

				return *(UCameraAnimationCameraModifier*)__ReturnBuffer;
			}
		}

		private static uint __ActiveAnimations = 0;

		private static uint __NextInstanceSerialNumber = 0;

		private static uint __StopCameraAnimation = 0;

		private static uint __StopAllCameraAnimationsOf = 0;

		private static uint __StopAllCameraAnimations = 0;

		private static uint __PlayCameraAnimation = 0;

		private static uint __IsCameraAnimationActive = 0;

		private static uint __GetCameraAnimationCameraModifierFromPlayerController = 0;

		private static uint __GetCameraAnimationCameraModifierFromID = 0;

		private static uint __GetCameraAnimationCameraModifier = 0;
	}
}