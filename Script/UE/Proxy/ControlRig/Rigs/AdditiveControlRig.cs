using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.AdditiveControlRig")]
	public partial class UAdditiveControlRig : UControlRig, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.AdditiveControlRig");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}