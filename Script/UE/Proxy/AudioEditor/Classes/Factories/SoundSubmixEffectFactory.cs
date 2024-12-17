using Script.CoreUObject;
using Script.UnrealEd;
using Script.Engine;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundSubmixEffectFactory")]
	public partial class USoundSubmixEffectFactory : UFactory, IStaticClass
	{
		public TSubclassOf<USoundEffectSubmixPreset> SoundEffectSubmixPresetClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoundEffectSubmixPresetClass, __ReturnBuffer);

					return *(TSubclassOf<USoundEffectSubmixPreset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoundEffectSubmixPresetClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundSubmixEffectFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SoundEffectSubmixPresetClass = 0;
	}
}