using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorTransformToolBuilder")]
	public partial class UUVEditorTransformToolBuilder : UUVEditorBaseTransformToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorTransformToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}