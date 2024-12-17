using Script.CoreUObject;
using Script.IrisCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlayerStateCountLimiterConfig")]
	public partial class UPlayerStateCountLimiterConfig : UNetObjectCountLimiterConfig, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PlayerStateCountLimiterConfig");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}