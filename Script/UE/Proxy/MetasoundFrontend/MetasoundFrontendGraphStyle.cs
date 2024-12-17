using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendGraphStyle")]
	public partial class FMetasoundFrontendGraphStyle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendGraphStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendGraphStyle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendGraphStyle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendGraphStyle A, FMetasoundFrontendGraphStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendGraphStyle A, FMetasoundFrontendGraphStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendGraphStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bIsGraphEditable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsGraphEditable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsGraphEditable, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendEdgeStyle> EdgeStyles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EdgeStyles, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendEdgeStyle>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EdgeStyles, __InBuffer);
				}
			}
		}

		private static uint __bIsGraphEditable = 0;

		private static uint __EdgeStyles = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}