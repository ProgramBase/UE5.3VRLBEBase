using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoVec2ParameterSource")]
	public partial class UGizmoVec2ParameterSource : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoVec2ParameterSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.GizmoVec2ParameterSource")]
	public interface IGizmoVec2ParameterSource : IInterface
	{
		 void SetParameter(FVector2D NewValue);

		 FVector2D GetParameter();

		 void EndModify();

		 void BeginModify();
	}
}