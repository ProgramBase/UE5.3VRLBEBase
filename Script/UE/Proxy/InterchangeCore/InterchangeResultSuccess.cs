using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangeResultSuccess")]
	public partial class UInterchangeResultSuccess : UInterchangeResult, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeCore.InterchangeResultSuccess");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}