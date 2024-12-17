using Script.CoreUObject;
using Script.Library;

namespace Script.CurveEditor
{
	[PathName("/Script/CurveEditor.CurveEditorKeyProxy")]
	public partial class UCurveEditorKeyProxy : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CurveEditor.CurveEditorKeyProxy");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/CurveEditor.CurveEditorKeyProxy")]
	public interface ICurveEditorKeyProxy : IInterface
	{
	}
}