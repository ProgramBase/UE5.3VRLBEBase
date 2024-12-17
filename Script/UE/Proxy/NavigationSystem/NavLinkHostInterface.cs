using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavLinkHostInterface")]
	public partial class UNavLinkHostInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavLinkHostInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/NavigationSystem.NavLinkHostInterface")]
	public interface INavLinkHostInterface : IInterface
	{
	}
}