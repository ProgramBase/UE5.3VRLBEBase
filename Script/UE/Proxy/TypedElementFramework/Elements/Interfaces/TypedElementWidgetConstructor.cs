using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementWidgetConstructor")]
	public partial class FTypedElementWidgetConstructor : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementWidgetConstructor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementWidgetConstructor() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTypedElementWidgetConstructor() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTypedElementWidgetConstructor A, FTypedElementWidgetConstructor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementWidgetConstructor A, FTypedElementWidgetConstructor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementWidgetConstructor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}