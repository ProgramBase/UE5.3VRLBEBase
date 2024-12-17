using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.Basic3DTriangleSetComponent")]
	public partial class UBasic3DTriangleSetComponent : UBasicTriangleSetComponentBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.Basic3DTriangleSetComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}