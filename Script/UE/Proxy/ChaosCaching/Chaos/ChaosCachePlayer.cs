using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.ChaosCachePlayer")]
	public partial class AChaosCachePlayer : AChaosCacheManager, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosCaching.ChaosCachePlayer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}