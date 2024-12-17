using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendClassStyle")]
	public partial class FMetasoundFrontendClassStyle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendClassStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendClassStyle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendClassStyle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendClassStyle A, FMetasoundFrontendClassStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendClassStyle A, FMetasoundFrontendClassStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendClassStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMetasoundFrontendClassStyleDisplay Display
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Display, __ReturnBuffer);

					return *(FMetasoundFrontendClassStyleDisplay*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Display, __InBuffer);
				}
			}
		}

		public FGuid ChangeID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChangeID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChangeID, __InBuffer);
				}
			}
		}

		private static uint __Display = 0;

		private static uint __ChangeID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}