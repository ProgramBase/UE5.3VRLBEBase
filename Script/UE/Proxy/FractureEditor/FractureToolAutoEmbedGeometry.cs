using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolAutoEmbedGeometry")]
	public partial class UFractureToolAutoEmbedGeometry : UFractureActionTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolAutoEmbedGeometry");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}