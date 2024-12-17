using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigValidationPass")]
	public partial class UControlRigValidationPass : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigValidationPass");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}