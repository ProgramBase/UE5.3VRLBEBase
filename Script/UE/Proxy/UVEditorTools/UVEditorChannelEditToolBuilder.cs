using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorChannelEditToolBuilder")]
	public partial class UUVEditorChannelEditToolBuilder : UInteractiveToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorChannelEditToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}