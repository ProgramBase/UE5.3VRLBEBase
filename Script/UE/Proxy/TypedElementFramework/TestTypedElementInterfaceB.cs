using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TestTypedElementInterfaceB")]
	public partial class UTestTypedElementInterfaceB : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementFramework.TestTypedElementInterfaceB");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/TypedElementFramework.TestTypedElementInterfaceB")]
	public interface ITestTypedElementInterfaceB : IInterface
	{
		 bool MarkAsTested(FScriptTypedElementHandle InElementHandle);
	}
}