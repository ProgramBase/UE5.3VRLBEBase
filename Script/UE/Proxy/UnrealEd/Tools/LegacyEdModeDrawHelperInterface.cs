using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LegacyEdModeDrawHelperInterface")]
	public partial class ULegacyEdModeDrawHelperInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LegacyEdModeDrawHelperInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/UnrealEd.LegacyEdModeDrawHelperInterface")]
	public interface ILegacyEdModeDrawHelperInterface : IInterface
	{
	}
}