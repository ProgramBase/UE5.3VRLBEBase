using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DPICustomScalingRule")]
	public partial class UDPICustomScalingRule : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DPICustomScalingRule");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}