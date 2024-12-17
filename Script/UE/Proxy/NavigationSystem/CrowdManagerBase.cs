using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.CrowdManagerBase")]
	public partial class UCrowdManagerBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.CrowdManagerBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}