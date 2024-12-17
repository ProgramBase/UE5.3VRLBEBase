using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendClassInput")]
	public partial class FMetasoundFrontendClassInput : FMetasoundFrontendClassVertex, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendClassInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendClassInput()
		{
		}

		public static bool operator ==(FMetasoundFrontendClassInput A, FMetasoundFrontendClassInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendClassInput A, FMetasoundFrontendClassInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendClassInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMetasoundFrontendLiteral DefaultLiteral
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultLiteral, __ReturnBuffer);

					return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultLiteral, __InBuffer);
				}
			}
		}

		private static uint __DefaultLiteral = 0;

	}
}