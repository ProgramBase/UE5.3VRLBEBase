using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementRuntime
{
	[PathName("/Script/TypedElementRuntime.TypedElementSelectionSetState")]
	public partial class FTypedElementSelectionSetState : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementRuntime.TypedElementSelectionSetState");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementSelectionSetState() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTypedElementSelectionSetState() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTypedElementSelectionSetState A, FTypedElementSelectionSetState B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementSelectionSetState A, FTypedElementSelectionSetState B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementSelectionSetState;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<UTypedElementSelectionSet> CreatedFromSelectionSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CreatedFromSelectionSet, __ReturnBuffer);

					return *(TWeakObjectPtr<UTypedElementSelectionSet>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CreatedFromSelectionSet, __InBuffer);
				}
			}
		}

		private static uint __CreatedFromSelectionSet = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}