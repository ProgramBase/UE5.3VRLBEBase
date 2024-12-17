using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavArea_Obstacle")]
	public partial class UNavArea_Obstacle : UNavArea, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavArea_Obstacle");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}