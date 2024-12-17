using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AnimationSharingEd
{
	[PathName("/Script/AnimationSharingEd.AnimationSharingSetupFactory")]
	public partial class UAnimationSharingSetupFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationSharingEd.AnimationSharingSetupFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}