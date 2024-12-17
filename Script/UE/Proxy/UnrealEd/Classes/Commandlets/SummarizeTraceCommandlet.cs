using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SummarizeTraceCommandlet")]
	public partial class USummarizeTraceCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SummarizeTraceCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}