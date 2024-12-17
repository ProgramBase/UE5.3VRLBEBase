using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangeResultError")]
	public partial class UInterchangeResultError : UInterchangeResult, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeCore.InterchangeResultError");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}