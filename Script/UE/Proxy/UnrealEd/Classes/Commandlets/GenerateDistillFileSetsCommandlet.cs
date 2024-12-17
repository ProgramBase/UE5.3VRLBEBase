using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.GenerateDistillFileSetsCommandlet")]
	public partial class UGenerateDistillFileSetsCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.GenerateDistillFileSetsCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}