using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CompositeCurveTableFactory")]
	public partial class UCompositeCurveTableFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CompositeCurveTableFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}