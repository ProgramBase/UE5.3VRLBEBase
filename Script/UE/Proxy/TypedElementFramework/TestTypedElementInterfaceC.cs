using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TestTypedElementInterfaceC")]
	public partial class UTestTypedElementInterfaceC : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementFramework.TestTypedElementInterfaceC");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/TypedElementFramework.TestTypedElementInterfaceC")]
	public interface ITestTypedElementInterfaceC : IInterface
	{
		 bool GetIsTested(FScriptTypedElementHandle InElementHandle);
	}
}