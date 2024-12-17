using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ImportantToggleSettingInterface")]
	public partial class UImportantToggleSettingInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ImportantToggleSettingInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.ImportantToggleSettingInterface")]
	public interface IImportantToggleSettingInterface : IInterface
	{
	}
}