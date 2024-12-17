using Script.CoreUObject;
using Script.NetCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NetFaultConfig")]
	public partial class UNetFaultConfig : UEscalationManagerConfig, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NetFaultConfig");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}