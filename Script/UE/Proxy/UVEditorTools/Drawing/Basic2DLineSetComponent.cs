using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.Basic2DLineSetComponent")]
	public partial class UBasic2DLineSetComponent : UBasicLineSetComponentBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.Basic2DLineSetComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}