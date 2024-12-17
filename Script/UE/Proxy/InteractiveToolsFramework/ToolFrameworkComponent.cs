using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.ToolFrameworkComponent")]
	public partial class UToolFrameworkComponent : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.ToolFrameworkComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.ToolFrameworkComponent")]
	public interface IToolFrameworkComponent : IInterface
	{
	}
}