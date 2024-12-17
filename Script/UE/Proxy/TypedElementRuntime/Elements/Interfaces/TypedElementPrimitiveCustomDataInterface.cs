using Script.CoreUObject;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.TypedElementRuntime
{
	[PathName("/Script/TypedElementRuntime.TypedElementPrimitiveCustomDataInterface")]
	public partial class UTypedElementPrimitiveCustomDataInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementRuntime.TypedElementPrimitiveCustomDataInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/TypedElementRuntime.TypedElementPrimitiveCustomDataInterface")]
	public interface ITypedElementPrimitiveCustomDataInterface : IInterface
	{
		 void SetCustomDataValue(FScriptTypedElementHandle InElementHandle, int CustomDataIndex, float CustomDataValue, bool bMarkRenderStateDirty = false);

		 void SetCustomData(FScriptTypedElementHandle InElementHandle, TArray<float> CustomDataFloats, bool bMarkRenderStateDirty = false);
	}
}