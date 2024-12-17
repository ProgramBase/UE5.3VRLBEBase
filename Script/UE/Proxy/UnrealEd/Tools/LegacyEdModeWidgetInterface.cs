using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LegacyEdModeWidgetInterface")]
	public partial class ULegacyEdModeWidgetInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LegacyEdModeWidgetInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/UnrealEd.LegacyEdModeWidgetInterface")]
	public interface ILegacyEdModeWidgetInterface : IInterface
	{
	}
}