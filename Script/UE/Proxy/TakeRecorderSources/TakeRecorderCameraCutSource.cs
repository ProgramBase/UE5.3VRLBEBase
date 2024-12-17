using Script.CoreUObject;
using Script.TakesCore;
using Script.Engine;
using Script.LevelSequence;
using Script.Library;

namespace Script.TakeRecorderSources
{
	[PathName("/Script/TakeRecorderSources.TakeRecorderCameraCutSource")]
	public partial class UTakeRecorderCameraCutSource : UTakeRecorderSource, IStaticClass
	{
		public UWorld World
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __World, __ReturnBuffer);

					return *(UWorld*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __World, __InBuffer);
				}
			}
		}

		public ULevelSequence RootLevelSequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootLevelSequence, __ReturnBuffer);

					return *(ULevelSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootLevelSequence, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorderSources.TakeRecorderCameraCutSource");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __World = 0;

		private static uint __RootLevelSequence = 0;
	}
}