using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.SlateWidgetStyleContainerInterface")]
	public partial class USlateWidgetStyleContainerInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SlateCore.SlateWidgetStyleContainerInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/SlateCore.SlateWidgetStyleContainerInterface")]
	public interface ISlateWidgetStyleContainerInterface : IInterface
	{
	}
}