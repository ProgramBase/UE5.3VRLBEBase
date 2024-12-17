using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.TemplateSequence;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.GameplayCamerasSubsystem")]
	public partial class UGameplayCamerasSubsystem : UWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayCameras.GameplayCamerasSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="PlayerController">
		/// The player controller on which to play the animation.
		/// </param>
		/// <param name="Hanlde">
		/// A handle to a previously started camera animation.
		/// </param>
		/// <param name="bImmediate">
		/// True to stop it right now and ignore blend out, false to let it blend out as indicated.
		/// </param>
		public virtual void StopCameraAnimation(APlayerController PlayerController, FCameraAnimationHandle Handle, bool bImmediate = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bImmediate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopCameraAnimation, __InBuffer);
			}
		}

		/// <param name="PlayerController">
		/// The player controller on which to play the animation.
		/// </param>
		/// <param name="Sequence">
		/// The sequence of which to stop all instances.
		/// </param>
		/// <param name="bImmediate">
		/// True to stop it right now and ignore blend out, false to let it blend out as indicated.
		/// </param>
		public virtual void StopAllCameraAnimationsOf(APlayerController PlayerController, UCameraAnimationSequence Sequence, bool bImmediate = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bImmediate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAllCameraAnimationsOf, __InBuffer);
			}
		}

		/// <param name="PlayerController">
		/// The player controller on which to play the animation.
		/// </param>
		/// <param name="bImmediate">
		/// True to stop it right now and ignore blend out, false to let it blend out as indicated.
		/// </param>
		public virtual void StopAllCameraAnimations(APlayerController PlayerController, bool bImmediate = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bImmediate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAllCameraAnimations, __InBuffer);
			}
		}

		/// <param name="PlayerController">
		/// The player controller on which to play the animation.
		/// </param>
		/// <param name="Sequence">
		/// The sequence to use for the new camera animation.
		/// </param>
		/// <param name="Params">
		/// The parameters for the new camera animation instance.
		/// </param>
		public virtual FCameraAnimationHandle PlayCameraAnimation(APlayerController PlayerController, UCameraAnimationSequence Sequence, FCameraAnimationParams Params)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Params?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PlayCameraAnimation, __InBuffer, __ReturnBuffer);

				return *(FCameraAnimationHandle*)__ReturnBuffer;
			}
		}

		/// <param name="PlayerController">
		/// The player controller on which to play the animation.
		/// </param>
		/// <param name="Handle">
		/// A handle to a previously started camera animation.
		/// </param>
		/// <returns>
		/// Whether the corresponding camera animation is playing or not.
		/// </returns>
		public virtual bool IsCameraAnimationActive(APlayerController PlayerController, FCameraAnimationHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsCameraAnimationActive, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __StopCameraAnimation = 0;

		private static uint __StopAllCameraAnimationsOf = 0;

		private static uint __StopAllCameraAnimations = 0;

		private static uint __PlayCameraAnimation = 0;

		private static uint __IsCameraAnimationActive = 0;
	}
}