using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.CrowdAgentInterface")]
	public partial class UCrowdAgentInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.CrowdAgentInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AIModule.CrowdAgentInterface")]
	public interface ICrowdAgentInterface : IInterface
	{
	}
}