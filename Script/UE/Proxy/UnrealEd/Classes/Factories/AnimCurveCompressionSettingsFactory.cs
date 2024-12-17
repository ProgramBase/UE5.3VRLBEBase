using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AnimCurveCompressionSettingsFactory")]
	public partial class UAnimCurveCompressionSettingsFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AnimCurveCompressionSettingsFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}