using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.AnimSequenceLevelSequenceLink")]
	public partial class UAnimSequenceLevelSequenceLink : UAssetUserData, IStaticClass
	{
		public FGuid SkelTrackGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkelTrackGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkelTrackGuid, __InBuffer);
				}
			}
		}

		public FSoftObjectPath PathToLevelSequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PathToLevelSequence, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PathToLevelSequence, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.AnimSequenceLevelSequenceLink");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SkelTrackGuid = 0;

		private static uint __PathToLevelSequence = 0;
	}
}