using Script.CoreUObject;
using Script.Library;

namespace Script.EditorFramework
{
	[PathName("/Script/EditorFramework.AssetEditorContextInterface")]
	public partial class UAssetEditorContextInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorFramework.AssetEditorContextInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/EditorFramework.AssetEditorContextInterface")]
	public interface IAssetEditorContextInterface : IInterface
	{
	}
}