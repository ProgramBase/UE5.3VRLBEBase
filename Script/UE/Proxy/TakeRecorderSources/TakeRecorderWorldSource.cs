using Script.CoreUObject;
using Script.Library;

namespace Script.TakeRecorderSources
{
	[PathName("/Script/TakeRecorderSources.TakeRecorderWorldSource")]
	public partial class UTakeRecorderWorldSource : UTakeRecorderWorldSourceSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorderSources.TakeRecorderWorldSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}