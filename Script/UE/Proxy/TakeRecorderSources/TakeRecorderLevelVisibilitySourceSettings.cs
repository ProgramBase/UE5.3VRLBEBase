using Script.CoreUObject;
using Script.TakesCore;
using Script.Library;

namespace Script.TakeRecorderSources
{
	[PathName("/Script/TakeRecorderSources.TakeRecorderLevelVisibilitySourceSettings")]
	public partial class UTakeRecorderLevelVisibilitySourceSettings : UTakeRecorderSource, IStaticClass
	{
		public FText LevelVisibilityTrackName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelVisibilityTrackName, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelVisibilityTrackName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorderSources.TakeRecorderLevelVisibilitySourceSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LevelVisibilityTrackName = 0;
	}
}