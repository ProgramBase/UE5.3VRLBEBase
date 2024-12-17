using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryTest_Overlap")]
	public partial class UEnvQueryTest_Overlap : UEnvQueryTest, IStaticClass
	{
		public FEnvOverlapData OverlapData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverlapData, __ReturnBuffer);

					return *(FEnvOverlapData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverlapData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryTest_Overlap");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OverlapData = 0;
	}
}