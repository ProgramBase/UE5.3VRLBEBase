using Script.CoreUObject;
using Script.LevelSequence;
using Script.Library;

namespace Script.TakesCore
{
	[PathName("/Script/TakesCore.TakePreset")]
	public partial class UTakePreset : UObject, IStaticClass
	{
		public ULevelSequence LevelSequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelSequence, __ReturnBuffer);

					return *(ULevelSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelSequence, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakesCore.TakePreset");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LevelSequence = 0;
	}
}