using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigSkeletalMeshComponent")]
	public partial class UControlRigSkeletalMeshComponent : UDebugSkelMeshComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigSkeletalMeshComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}