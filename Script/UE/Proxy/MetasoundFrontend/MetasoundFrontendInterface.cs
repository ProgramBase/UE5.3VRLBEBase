using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendInterface")]
	public partial class FMetasoundFrontendInterface : FMetasoundFrontendClassInterface, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendInterface");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendInterface()
		{
		}

		public static bool operator ==(FMetasoundFrontendInterface A, FMetasoundFrontendInterface B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendInterface A, FMetasoundFrontendInterface B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendInterface;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMetasoundFrontendVersion Version
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Version, __ReturnBuffer);

					return *(FMetasoundFrontendVersion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Version, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendInterfaceUClassOptions> UClassOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UClassOptions, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendInterfaceUClassOptions>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UClassOptions, __InBuffer);
				}
			}
		}

		private static uint __Version = 0;

		private static uint __UClassOptions = 0;

	}
}