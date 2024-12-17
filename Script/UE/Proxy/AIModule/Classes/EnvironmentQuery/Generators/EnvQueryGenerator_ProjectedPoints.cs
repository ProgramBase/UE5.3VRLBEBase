using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryGenerator_ProjectedPoints")]
	public partial class UEnvQueryGenerator_ProjectedPoints : UEnvQueryGenerator, IStaticClass
	{
		public FEnvTraceData ProjectionData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProjectionData, __ReturnBuffer);

					return *(FEnvTraceData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProjectionData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryGenerator_ProjectedPoints");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ProjectionData = 0;
	}
}