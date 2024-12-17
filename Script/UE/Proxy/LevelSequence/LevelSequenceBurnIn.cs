using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceBurnIn")]
	public partial class ULevelSequenceBurnIn : UUserWidget, IStaticClass
	{
		public FLevelSequencePlayerSnapshot FrameInformation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FrameInformation, __ReturnBuffer);

					return *(FLevelSequencePlayerSnapshot*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FrameInformation, __InBuffer);
				}
			}
		}

		public ALevelSequenceActor LevelSequenceActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelSequenceActor, __ReturnBuffer);

					return *(ALevelSequenceActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelSequenceActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.LevelSequenceBurnIn");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSettings(UObject InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __SetSettings, __InBuffer);
			}
		}

		public virtual TSubclassOf<ULevelSequenceBurnInInitSettings> GetSettingsClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSettingsClass, __ReturnBuffer);

				return *(TSubclassOf<ULevelSequenceBurnInInitSettings>*)__ReturnBuffer;
			}
		}

		private static uint __FrameInformation = 0;

		private static uint __LevelSequenceActor = 0;

		private static uint __SetSettings = 0;

		private static uint __GetSettingsClass = 0;
	}
}