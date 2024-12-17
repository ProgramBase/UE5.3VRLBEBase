using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.SequencerAnimationSupport")]
	public partial class USequencerAnimationSupport : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.SequencerAnimationSupport");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AnimGraphRuntime.SequencerAnimationSupport")]
	public interface ISequencerAnimationSupport : IInterface
	{
	}
}