using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementRuntime
{
	[PathName("/Script/TypedElementRuntime.TypedElementIsSelectedOptions")]
	public partial class FTypedElementIsSelectedOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementRuntime.TypedElementIsSelectedOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementIsSelectedOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTypedElementIsSelectedOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTypedElementIsSelectedOptions A, FTypedElementIsSelectedOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementIsSelectedOptions A, FTypedElementIsSelectedOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementIsSelectedOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bAllowIndirect
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowIndirect, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowIndirect, __InBuffer);
				}
			}
		}

		private static uint __bAllowIndirect = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}