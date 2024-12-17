using Script.CoreUObject;
using Script.UnrealEd;
using Script.Engine;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundSourceEffectFactory")]
	public partial class USoundSourceEffectFactory : UFactory, IStaticClass
	{
		public TSubclassOf<USoundEffectSourcePreset> SoundEffectSourcepresetClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoundEffectSourcepresetClass, __ReturnBuffer);

					return *(TSubclassOf<USoundEffectSourcePreset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoundEffectSourcepresetClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundSourceEffectFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SoundEffectSourcepresetClass = 0;
	}
}