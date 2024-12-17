using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryGenerator_CurrentLocation")]
	public partial class UEnvQueryGenerator_CurrentLocation : UEnvQueryGenerator, IStaticClass
	{
		public TSubclassOf<UEnvQueryContext> QueryContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __QueryContext, __ReturnBuffer);

					return *(TSubclassOf<UEnvQueryContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __QueryContext, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryGenerator_CurrentLocation");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __QueryContext = 0;
	}
}