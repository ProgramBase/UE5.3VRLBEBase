using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.Basic2DPointSetComponent")]
	public partial class UBasic2DPointSetComponent : UBasicPointSetComponentBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.Basic2DPointSetComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}