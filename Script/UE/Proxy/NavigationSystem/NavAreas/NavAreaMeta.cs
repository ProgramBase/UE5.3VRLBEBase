using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavAreaMeta")]
	public partial class UNavAreaMeta : UNavArea, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavAreaMeta");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}