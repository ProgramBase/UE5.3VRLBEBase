using Script.CoreUObject;
using Script.Library;
using Script.AudioExtensions;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorSoundParameterInterface")]
	public partial class UActorSoundParameterInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ActorSoundParameterInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.ActorSoundParameterInterface")]
	public interface IActorSoundParameterInterface : IInterface
	{
		 void GetActorSoundParams(ref TArray<FAudioParameter> Params);
	}
}