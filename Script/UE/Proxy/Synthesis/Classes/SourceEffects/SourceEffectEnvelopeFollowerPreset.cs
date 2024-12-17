using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset")]
	public partial class USourceEffectEnvelopeFollowerPreset : USoundEffectSourcePreset, IStaticClass
	{
		public FSourceEffectEnvelopeFollowerSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FSourceEffectEnvelopeFollowerSettings*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UnregisterEnvelopeFollowerListener(UEnvelopeFollowerListener EnvelopeFollowerListener)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EnvelopeFollowerListener?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnregisterEnvelopeFollowerListener, __InBuffer);
			}
		}

		public virtual void SetSettings(FSourceEffectEnvelopeFollowerSettings InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSettings, __InBuffer);
			}
		}

		public virtual void RegisterEnvelopeFollowerListener(UEnvelopeFollowerListener EnvelopeFollowerListener)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EnvelopeFollowerListener?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RegisterEnvelopeFollowerListener, __InBuffer);
			}
		}

		private static uint __Settings = 0;

		private static uint __UnregisterEnvelopeFollowerListener = 0;

		private static uint __SetSettings = 0;

		private static uint __RegisterEnvelopeFollowerListener = 0;
	}
}