using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectFoldbackDistortionPreset")]
	public partial class USourceEffectFoldbackDistortionPreset : USoundEffectSourcePreset, IStaticClass
	{
		public FSourceEffectFoldbackDistortionSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FSourceEffectFoldbackDistortionSettings*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.SourceEffectFoldbackDistortionPreset");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSettings(FSourceEffectFoldbackDistortionSettings InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSettings, __InBuffer);
			}
		}

		private static uint __Settings = 0;

		private static uint __SetSettings = 0;
	}
}