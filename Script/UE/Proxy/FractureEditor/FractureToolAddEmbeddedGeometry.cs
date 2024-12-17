using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolAddEmbeddedGeometry")]
	public partial class UFractureToolAddEmbeddedGeometry : UFractureActionTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolAddEmbeddedGeometry");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}