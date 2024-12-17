using Script.CoreUObject;
using Script.Library;

namespace Script.MaterialBaking
{
	[PathName("/Script/MaterialBaking.AssetBakeOptions")]
	public partial class UAssetBakeOptions : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MaterialBaking.AssetBakeOptions");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}