using Script.CoreUObject;
using Script.Library;

namespace Script.MaterialEditor
{
	[PathName("/Script/MaterialEditor.MaterialEditorMenuContext")]
	public partial class UMaterialEditorMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MaterialEditor.MaterialEditorMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}