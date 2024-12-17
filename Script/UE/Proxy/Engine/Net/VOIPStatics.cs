using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VOIPStatics")]
	public partial class UVOIPStatics : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VOIPStatics");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetMicThreshold(float InThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InThreshold;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetMicThreshold, __InBuffer);
			}
		}

		private static uint __SetMicThreshold = 0;
	}
}