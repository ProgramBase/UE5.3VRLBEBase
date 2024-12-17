using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorUVQuickTransformProperties")]
	public partial class UUVEditorUVQuickTransformProperties : UUVEditorUVTransformProperties, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorUVQuickTransformProperties");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}