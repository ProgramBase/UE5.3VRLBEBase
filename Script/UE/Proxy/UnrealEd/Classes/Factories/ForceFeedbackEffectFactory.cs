using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ForceFeedbackEffectFactory")]
	public partial class UForceFeedbackEffectFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ForceFeedbackEffectFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}