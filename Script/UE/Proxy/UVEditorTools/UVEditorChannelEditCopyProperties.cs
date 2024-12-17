using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorChannelEditCopyProperties")]
	public partial class UUVEditorChannelEditCopyProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorChannelEditCopyProperties");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}