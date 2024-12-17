using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset")]
	public partial class USubmixEffectDynamicsProcessorPreset : USoundEffectSubmixPreset, IStaticClass
	{
		public FSubmixEffectDynamicsProcessorSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FSubmixEffectDynamicsProcessorSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSettings(FSubmixEffectDynamicsProcessorSettings Settings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Settings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSettings, __InBuffer);
			}
		}

		public virtual void SetExternalSubmix(USoundSubmix Submix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Submix?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetExternalSubmix, __InBuffer);
			}
		}

		public virtual void SetAudioBus(UAudioBus AudioBus)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AudioBus?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAudioBus, __InBuffer);
			}
		}

		public virtual void ResetKey()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetKey);
			}
		}

		private static uint __Settings = 0;

		private static uint __SetSettings = 0;

		private static uint __SetExternalSubmix = 0;

		private static uint __SetAudioBus = 0;

		private static uint __ResetKey = 0;
	}
}