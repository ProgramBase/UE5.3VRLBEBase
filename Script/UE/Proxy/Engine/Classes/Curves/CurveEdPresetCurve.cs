using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CurveEdPresetCurve")]
	public partial class UDEPRECATED_CurveEdPresetCurve : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CurveEdPresetCurve");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}