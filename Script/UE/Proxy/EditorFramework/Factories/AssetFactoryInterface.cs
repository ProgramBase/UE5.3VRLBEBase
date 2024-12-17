using Script.CoreUObject;
using Script.Library;

namespace Script.EditorFramework
{
	[PathName("/Script/EditorFramework.AssetFactoryInterface")]
	public partial class UAssetFactoryInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorFramework.AssetFactoryInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/EditorFramework.AssetFactoryInterface")]
	public interface IAssetFactoryInterface : IInterface
	{
	}
}