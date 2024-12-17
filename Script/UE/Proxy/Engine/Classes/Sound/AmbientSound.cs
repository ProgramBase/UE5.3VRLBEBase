using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AmbientSound")]
	public partial class AAmbientSound : AActor, IStaticClass
	{
		public UAudioComponent AudioComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioComponent, __ReturnBuffer);

					return *(UAudioComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AmbientSound");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Stop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Stop);
			}
		}

		public virtual void Play(float StartTime = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = StartTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Play, __InBuffer);
			}
		}

		public virtual void FadeOut(float FadeOutDuration, float FadeVolumeLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = FadeOutDuration;

				*(float*)(__InBuffer + 4) = FadeVolumeLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FadeOut, __InBuffer);
			}
		}

		public virtual void FadeIn(float FadeInDuration, float FadeVolumeLevel = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = FadeInDuration;

				*(float*)(__InBuffer + 4) = FadeVolumeLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FadeIn, __InBuffer);
			}
		}

		public virtual void AdjustVolume(float AdjustVolumeDuration, float AdjustVolumeLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = AdjustVolumeDuration;

				*(float*)(__InBuffer + 4) = AdjustVolumeLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AdjustVolume, __InBuffer);
			}
		}

		private static uint __AudioComponent = 0;

		private static uint __Stop = 0;

		private static uint __Play = 0;

		private static uint __FadeOut = 0;

		private static uint __FadeIn = 0;

		private static uint __AdjustVolume = 0;
	}
}