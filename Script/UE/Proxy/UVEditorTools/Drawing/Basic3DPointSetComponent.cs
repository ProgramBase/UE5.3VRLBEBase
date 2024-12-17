using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.Basic3DPointSetComponent")]
	public partial class UBasic3DPointSetComponent : UBasicPointSetComponentBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.Basic3DPointSetComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}