using Script.CoreUObject;
using Script.Library;

namespace Script.TakeRecorderSources
{
	[PathName("/Script/TakeRecorderSources.TakeRecorderLevelVisibilitySource")]
	public partial class UTakeRecorderLevelVisibilitySource : UTakeRecorderLevelVisibilitySourceSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorderSources.TakeRecorderLevelVisibilitySource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}