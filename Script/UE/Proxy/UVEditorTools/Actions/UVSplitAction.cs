using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVSplitAction")]
	public partial class UUVSplitAction : UUVToolAction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVSplitAction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}