using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVToolAssetAndChannelAPI")]
	public partial class UUVToolAssetAndChannelAPI : UUVToolContextObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVToolAssetAndChannelAPI");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}