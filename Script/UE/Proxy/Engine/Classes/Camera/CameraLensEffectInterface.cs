using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraLensEffectInterface")]
	public partial class UCameraLensEffectInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CameraLensEffectInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.CameraLensEffectInterface")]
	public interface ICameraLensEffectInterface : IInterface
	{
		 UFXSystemComponent GetPrimaryParticleComponent();

		 TArray<UFXSystemComponent> GetParticleComponents();
	}
}