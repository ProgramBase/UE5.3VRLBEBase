using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorAlignToolBuilder")]
	public partial class UUVEditorAlignToolBuilder : UUVEditorBaseTransformToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorAlignToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}