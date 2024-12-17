using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AimOffsetBlendSpaceFactory1D")]
	public partial class UAimOffsetBlendSpaceFactory1D : UBlendSpaceFactory1D, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AimOffsetBlendSpaceFactory1D");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}