using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceAnimSequenceLink")]
	public partial class ULevelSequenceAnimSequenceLink : UAssetUserData, IStaticClass
	{
		public TArray<FLevelSequenceAnimSequenceLinkItem> AnimSequenceLinks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimSequenceLinks, __ReturnBuffer);

					return *(TArray<FLevelSequenceAnimSequenceLinkItem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimSequenceLinks, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.LevelSequenceAnimSequenceLink");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AnimSequenceLinks = 0;
	}
}