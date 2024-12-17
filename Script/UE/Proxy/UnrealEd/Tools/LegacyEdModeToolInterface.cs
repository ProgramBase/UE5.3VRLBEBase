using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LegacyEdModeToolInterface")]
	public partial class ULegacyEdModeToolInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LegacyEdModeToolInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/UnrealEd.LegacyEdModeToolInterface")]
	public interface ILegacyEdModeToolInterface : IInterface
	{
	}
}