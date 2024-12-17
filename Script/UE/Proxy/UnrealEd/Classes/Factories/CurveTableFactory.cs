using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CurveTableFactory")]
	public partial class UCurveTableFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CurveTableFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}