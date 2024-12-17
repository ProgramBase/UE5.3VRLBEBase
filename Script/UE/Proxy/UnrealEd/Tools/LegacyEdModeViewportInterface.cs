using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LegacyEdModeViewportInterface")]
	public partial class ULegacyEdModeViewportInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LegacyEdModeViewportInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/UnrealEd.LegacyEdModeViewportInterface")]
	public interface ILegacyEdModeViewportInterface : IInterface
	{
	}
}