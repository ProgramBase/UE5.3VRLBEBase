using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVToolViewportButtonsAPI")]
	public partial class UUVToolViewportButtonsAPI : UUVToolContextObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVToolViewportButtonsAPI");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}