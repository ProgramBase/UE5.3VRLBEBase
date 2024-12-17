using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavArea_Null")]
	public partial class UNavArea_Null : UNavArea, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavArea_Null");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}