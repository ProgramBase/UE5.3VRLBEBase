using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.Basic3DLineSetComponent")]
	public partial class UBasic3DLineSetComponent : UBasicLineSetComponentBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.Basic3DLineSetComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}