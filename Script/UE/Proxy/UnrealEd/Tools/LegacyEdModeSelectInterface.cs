using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LegacyEdModeSelectInterface")]
	public partial class ULegacyEdModeSelectInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LegacyEdModeSelectInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/UnrealEd.LegacyEdModeSelectInterface")]
	public interface ILegacyEdModeSelectInterface : IInterface
	{
	}
}