using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationEditMode
{
	[PathName("/Script/AnimationEditMode.AnimationEditContext")]
	public partial class UAnimationEditContext : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationEditMode.AnimationEditContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AnimationEditMode.AnimationEditContext")]
	public interface IAnimationEditContext : IInterface
	{
	}
}