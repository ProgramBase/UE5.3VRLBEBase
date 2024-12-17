using Script.CoreUObject;
using Script.TakesCore;
using Script.LevelSequence;
using Script.Library;

namespace Script.TakeRecorderSources
{
	[PathName("/Script/TakeRecorderSources.TakeRecorderLevelSequenceSource")]
	public partial class UTakeRecorderLevelSequenceSource : UTakeRecorderSource, IStaticClass
	{
		public TArray<ULevelSequence> LevelSequencesToTrigger
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelSequencesToTrigger, __ReturnBuffer);

					return *(TArray<ULevelSequence>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelSequencesToTrigger, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorderSources.TakeRecorderLevelSequenceSource");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LevelSequencesToTrigger = 0;
	}
}