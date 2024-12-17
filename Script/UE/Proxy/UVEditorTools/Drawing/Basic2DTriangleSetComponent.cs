using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.Basic2DTriangleSetComponent")]
	public partial class UBasic2DTriangleSetComponent : UBasicTriangleSetComponentBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.Basic2DTriangleSetComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}