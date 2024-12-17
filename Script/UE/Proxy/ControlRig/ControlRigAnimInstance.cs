using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigAnimInstance")]
	public partial class UControlRigAnimInstance : UAnimInstance, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigAnimInstance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}