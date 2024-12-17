using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.ToolActivityHost")]
	public partial class UToolActivityHost : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.ToolActivityHost");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/ModelingComponents.ToolActivityHost")]
	public interface IToolActivityHost : IInterface
	{
	}
}