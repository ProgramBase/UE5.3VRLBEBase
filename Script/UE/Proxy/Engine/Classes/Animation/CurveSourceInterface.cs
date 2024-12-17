using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CurveSourceInterface")]
	public partial class UCurveSourceInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CurveSourceInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.CurveSourceInterface")]
	public interface ICurveSourceInterface : IInterface
	{
		 float GetCurveValue(FName CurveName);

		 void GetCurves(ref TArray<FNamedCurveValue> OutValues);

		 FName GetBindingName();
	}
}