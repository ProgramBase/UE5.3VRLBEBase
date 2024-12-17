using Script.CoreUObject;
using Script.UnrealEd;
using Script.Engine;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundCueFactoryNew")]
	public partial class USoundCueFactoryNew : UFactory, IStaticClass
	{
		public USoundWave InitialSoundWave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialSoundWave, __ReturnBuffer);

					return *(USoundWave*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialSoundWave, __InBuffer);
				}
			}
		}

		public TArray<TWeakObjectPtr<USoundWave>> InitialSoundWaves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialSoundWaves, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<USoundWave>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialSoundWaves, __InBuffer);
				}
			}
		}

		public UDialogueWave InitialDialogueWave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialDialogueWave, __ReturnBuffer);

					return *(UDialogueWave*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialDialogueWave, __InBuffer);
				}
			}
		}

		public TArray<TWeakObjectPtr<UDialogueWave>> InitialDialogueWaves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialDialogueWaves, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UDialogueWave>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialDialogueWaves, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundCueFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InitialSoundWave = 0;

		private static uint __InitialSoundWaves = 0;

		private static uint __InitialDialogueWave = 0;

		private static uint __InitialDialogueWaves = 0;
	}
}