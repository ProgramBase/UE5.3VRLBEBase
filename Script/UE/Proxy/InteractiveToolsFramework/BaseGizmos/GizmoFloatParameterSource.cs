using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoFloatParameterSource")]
	public partial class UGizmoFloatParameterSource : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoFloatParameterSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.GizmoFloatParameterSource")]
	public interface IGizmoFloatParameterSource : IInterface
	{
		 void SetParameter(float NewValue);

		 float GetParameter();

		 void EndModify();

		 void BeginModify();
	}
}