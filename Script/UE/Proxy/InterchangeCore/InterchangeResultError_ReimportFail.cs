using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangeResultError_ReimportFail")]
	public partial class UInterchangeResultError_ReimportFail : UInterchangeResultError, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeCore.InterchangeResultError_ReimportFail");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}