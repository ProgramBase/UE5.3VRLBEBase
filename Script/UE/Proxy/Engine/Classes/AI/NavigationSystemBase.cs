using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NavigationSystemBase")]
	public partial class UNavigationSystemBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NavigationSystemBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}