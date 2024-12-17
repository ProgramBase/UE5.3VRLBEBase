using Script.CoreUObject;
using Script.Library;

namespace Script.CurveEditor
{
	[PathName("/Script/CurveEditor.CurveEditorFilterBase")]
	public partial class UCurveEditorFilterBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CurveEditor.CurveEditorFilterBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}