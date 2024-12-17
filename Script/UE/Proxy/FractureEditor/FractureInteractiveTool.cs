using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureInteractiveTool")]
	public partial class UFractureInteractiveTool : UFractureModalTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureInteractiveTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}