using Script.CoreUObject;
using Script.Library;

namespace Script.WebBrowser
{
	[PathName("/Script/WebBrowser.WebJSCallbackBase")]
	public partial class FWebJSCallbackBase : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/WebBrowser.WebJSCallbackBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWebJSCallbackBase() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWebJSCallbackBase() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWebJSCallbackBase A, FWebJSCallbackBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWebJSCallbackBase A, FWebJSCallbackBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWebJSCallbackBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}