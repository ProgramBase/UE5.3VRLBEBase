using Script.CoreUObject;
using Script.TakesCore;
using Script.Library;

namespace Script.TakeRecorderSources
{
	[PathName("/Script/TakeRecorderSources.TakeRecorderPlayerSource")]
	public partial class UTakeRecorderPlayerSource : UTakeRecorderSource, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorderSources.TakeRecorderPlayerSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}