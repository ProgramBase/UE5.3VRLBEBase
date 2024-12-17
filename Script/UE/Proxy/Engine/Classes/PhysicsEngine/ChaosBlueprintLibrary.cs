using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ChaosBlueprintLibrary")]
	public partial class UChaosBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ChaosBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UChaosEventRelay GetEventRelayFromContext(UObject ContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEventRelayFromContext, __InBuffer, __ReturnBuffer);

				return *(UChaosEventRelay*)__ReturnBuffer;
			}
		}

		private static uint __GetEventRelayFromContext = 0;
	}
}