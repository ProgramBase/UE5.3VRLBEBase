using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIHotSpotManager")]
	public partial class UAIHotSpotManager : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AIHotSpotManager");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}