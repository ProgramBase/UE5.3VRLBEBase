using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.SparseDelegateFunction")]
	public partial class USparseDelegateFunction : UDelegateFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.SparseDelegateFunction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}