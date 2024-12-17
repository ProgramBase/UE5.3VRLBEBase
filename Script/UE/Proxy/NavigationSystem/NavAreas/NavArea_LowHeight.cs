using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavArea_LowHeight")]
	public partial class UNavArea_LowHeight : UNavArea, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavArea_LowHeight");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}