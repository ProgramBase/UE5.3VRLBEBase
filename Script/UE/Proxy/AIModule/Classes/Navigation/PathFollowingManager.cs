using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.PathFollowingManager")]
	public partial class UPathFollowingManager : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.PathFollowingManager");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}