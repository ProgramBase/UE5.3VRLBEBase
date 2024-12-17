using Script.CoreUObject;
using Script.UnrealEd;
using Script.Engine;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.DialogueWaveFactory")]
	public partial class UDialogueWaveFactory : UFactory, IStaticClass
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

		public UDialogueVoice InitialSpeakerVoice
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialSpeakerVoice, __ReturnBuffer);

					return *(UDialogueVoice*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialSpeakerVoice, __InBuffer);
				}
			}
		}

		public bool HasSetInitialTargetVoice
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HasSetInitialTargetVoice, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HasSetInitialTargetVoice, __InBuffer);
				}
			}
		}

		public TArray<UDialogueVoice> InitialTargetVoices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialTargetVoices, __ReturnBuffer);

					return *(TArray<UDialogueVoice>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialTargetVoices, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.DialogueWaveFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InitialSoundWave = 0;

		private static uint __InitialSpeakerVoice = 0;

		private static uint __HasSetInitialTargetVoice = 0;

		private static uint __InitialTargetVoices = 0;
	}
}