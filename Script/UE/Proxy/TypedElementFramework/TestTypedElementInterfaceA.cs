using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TestTypedElementInterfaceA")]
	public partial class UTestTypedElementInterfaceA : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementFramework.TestTypedElementInterfaceA");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/TypedElementFramework.TestTypedElementInterfaceA")]
	public interface ITestTypedElementInterfaceA : IInterface
	{
		 bool SetDisplayName(FScriptTypedElementHandle InElementHandle, FText InNewName, bool bNotify = true);

		 FText GetDisplayName(FScriptTypedElementHandle InElementHandle);
	}
}