using Script.CoreUObject;
using Script.Library;

namespace Script.CurveEditor
{
	[PathName("/Script/CurveEditor.CurveEditorEulerFilter")]
	public partial class UCurveEditorEulerFilter : UCurveEditorFilterBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CurveEditor.CurveEditorEulerFilter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}