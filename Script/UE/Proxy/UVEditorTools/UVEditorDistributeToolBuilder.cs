using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorDistributeToolBuilder")]
	public partial class UUVEditorDistributeToolBuilder : UUVEditorBaseTransformToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorDistributeToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}