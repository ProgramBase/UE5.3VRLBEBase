using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavArea_Default")]
	public partial class UNavArea_Default : UNavArea, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavArea_Default");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}