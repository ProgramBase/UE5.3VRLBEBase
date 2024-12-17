using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavLinkCustomInterface")]
	public partial class UNavLinkCustomInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavLinkCustomInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/NavigationSystem.NavLinkCustomInterface")]
	public interface INavLinkCustomInterface : IInterface
	{
	}
}