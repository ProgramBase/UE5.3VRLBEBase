using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealCSharp
{
	[PathName("/Script/UnrealCSharp.DelegateHandler")]
	public partial class UDelegateHandler : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealCSharp.DelegateHandler");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void CSharpCallBack()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __CSharpCallBack);
			}
		}

		private static uint __CSharpCallBack = 0;
	}
}