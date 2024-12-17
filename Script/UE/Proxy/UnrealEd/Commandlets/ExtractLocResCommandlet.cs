using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ExtractLocResCommandlet")]
	public partial class UExtractLocResCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ExtractLocResCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}