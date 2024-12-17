using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.SubmixEffectReverbPreset")]
	public partial class USubmixEffectReverbPreset : USoundEffectSubmixPreset, IStaticClass
	{
		public FSubmixEffectReverbSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FSubmixEffectReverbSettings*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioMixer.SubmixEffectReverbPreset");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSettingsWithReverbEffect(UReverbEffect InReverbEffect, float WetLevel, float DryLevel = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InReverbEffect?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = WetLevel;

				*(float*)(__InBuffer + 12) = DryLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSettingsWithReverbEffect, __InBuffer);
			}
		}

		public virtual void SetSettings(FSubmixEffectReverbSettings InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSettings, __InBuffer);
			}
		}

		private static uint __Settings = 0;

		private static uint __SetSettingsWithReverbEffect = 0;

		private static uint __SetSettings = 0;
	}
}