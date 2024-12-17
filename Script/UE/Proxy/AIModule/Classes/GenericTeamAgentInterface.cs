using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.GenericTeamAgentInterface")]
	public partial class UGenericTeamAgentInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.GenericTeamAgentInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AIModule.GenericTeamAgentInterface")]
	public interface IGenericTeamAgentInterface : IInterface
	{
	}
}