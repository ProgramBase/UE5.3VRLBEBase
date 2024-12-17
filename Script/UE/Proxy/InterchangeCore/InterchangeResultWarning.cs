using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangeResultWarning")]
	public partial class UInterchangeResultWarning : UInterchangeResult, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeCore.InterchangeResultWarning");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}