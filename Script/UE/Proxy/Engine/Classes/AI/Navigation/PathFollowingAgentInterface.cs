using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PathFollowingAgentInterface")]
	public partial class UPathFollowingAgentInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PathFollowingAgentInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.PathFollowingAgentInterface")]
	public interface IPathFollowingAgentInterface : IInterface
	{
	}
}