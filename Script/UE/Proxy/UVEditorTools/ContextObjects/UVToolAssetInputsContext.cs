using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVToolAssetInputsContext")]
	public partial class UUVToolAssetInputsContext : UUVToolContextObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVToolAssetInputsContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}