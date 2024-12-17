using Script.CoreUObject;
using Script.UVEditorTools;
using Script.Library;

namespace Script.UVEditor
{
	[PathName("/Script/UVEditor.UVEditorInitializationContext")]
	public partial class UUVEditorInitializationContext : UUVToolContextObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditor.UVEditorInitializationContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}