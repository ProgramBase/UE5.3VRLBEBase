using Script.CoreUObject;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.TypedElementRuntime
{
	[PathName("/Script/TypedElementRuntime.TypedElementAssetDataInterface")]
	public partial class UTypedElementAssetDataInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementRuntime.TypedElementAssetDataInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/TypedElementRuntime.TypedElementAssetDataInterface")]
	public interface ITypedElementAssetDataInterface : IInterface
	{
		 FAssetData GetAssetData(FScriptTypedElementHandle InElementHandle);

		 TArray<FAssetData> GetAllReferencedAssetDatas(FScriptTypedElementHandle InElementHandle);
	}
}