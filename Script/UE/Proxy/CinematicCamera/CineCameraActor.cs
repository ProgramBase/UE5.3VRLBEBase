using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.CinematicCamera
{
	[PathName("/Script/CinematicCamera.CineCameraActor")]
	public partial class ACineCameraActor : ACameraActor, IStaticClass
	{
		public FCameraLookatTrackingSettings LookatTrackingSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LookatTrackingSettings, __ReturnBuffer);

					return *(FCameraLookatTrackingSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LookatTrackingSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CinematicCamera.CineCameraActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UCineCameraComponent GetCineCameraComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCineCameraComponent, __ReturnBuffer);

				return *(UCineCameraComponent*)__ReturnBuffer;
			}
		}

		private static uint __LookatTrackingSettings = 0;

		private static uint __GetCineCameraComponent = 0;
	}
}