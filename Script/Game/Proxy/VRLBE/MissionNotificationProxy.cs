using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherEditor
{
	[PathName("/Script/HotPatcherEditor.MissionNotificationProxy")]
	public partial class UMissionNotificationProxy : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherEditor.MissionNotificationProxy");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}