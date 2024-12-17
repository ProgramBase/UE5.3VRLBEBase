using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISightTargetInterface")]
	public partial class UAISightTargetInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISightTargetInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AIModule.AISightTargetInterface")]
	public interface IAISightTargetInterface : IInterface
	{
	}
}