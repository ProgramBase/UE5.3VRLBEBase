using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CurveLinearColorFactory")]
	public partial class UCurveLinearColorFactory : UCurveFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CurveLinearColorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}