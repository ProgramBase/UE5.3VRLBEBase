using Script.CoreUObject;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.VirtualKeyboardOptions")]
	public partial class FVirtualKeyboardOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Slate.VirtualKeyboardOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVirtualKeyboardOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVirtualKeyboardOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVirtualKeyboardOptions A, FVirtualKeyboardOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVirtualKeyboardOptions A, FVirtualKeyboardOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVirtualKeyboardOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bEnableAutocorrect
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnableAutocorrect, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnableAutocorrect, __InBuffer);
				}
			}
		}

		private static uint __bEnableAutocorrect = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}