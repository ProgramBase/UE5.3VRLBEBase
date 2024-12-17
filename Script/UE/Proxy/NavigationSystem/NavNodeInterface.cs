using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavNodeInterface")]
	public partial class UNavNodeInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavNodeInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/NavigationSystem.NavNodeInterface")]
	public interface INavNodeInterface : IInterface
	{
	}
}