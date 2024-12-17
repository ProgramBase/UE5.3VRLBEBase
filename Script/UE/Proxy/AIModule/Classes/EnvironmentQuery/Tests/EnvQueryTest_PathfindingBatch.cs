using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryTest_PathfindingBatch")]
	public partial class UEnvQueryTest_PathfindingBatch : UEnvQueryTest_Pathfinding, IStaticClass
	{
		public FAIDataProviderFloatValue ScanRangeMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScanRangeMultiplier, __ReturnBuffer);

					return *(FAIDataProviderFloatValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScanRangeMultiplier, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryTest_PathfindingBatch");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ScanRangeMultiplier = 0;
	}
}