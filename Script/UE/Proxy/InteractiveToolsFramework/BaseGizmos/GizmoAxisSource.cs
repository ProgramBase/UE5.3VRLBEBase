using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoAxisSource")]
	public partial class UGizmoAxisSource : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoAxisSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.GizmoAxisSource")]
	public interface IGizmoAxisSource : IInterface
	{
		 bool HasTangentVectors();

		 void GetTangentVectors(ref FVector TangentXOut, ref FVector TangentYOut);

		 FVector GetOrigin();

		 FVector GetDirection();
	}
}