using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendClassVertex")]
	public partial class FMetasoundFrontendClassVertex : FMetasoundFrontendVertex, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendClassVertex");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendClassVertex()
		{
		}

		public static bool operator ==(FMetasoundFrontendClassVertex A, FMetasoundFrontendClassVertex B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendClassVertex A, FMetasoundFrontendClassVertex B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendClassVertex;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid NodeID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodeID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodeID, __InBuffer);
				}
			}
		}

		public FMetasoundFrontendVertexMetadata Metadata
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Metadata, __ReturnBuffer);

					return *(FMetasoundFrontendVertexMetadata*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Metadata, __InBuffer);
				}
			}
		}

		public EMetasoundFrontendVertexAccessType AccessType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AccessType, __ReturnBuffer);

					return *(EMetasoundFrontendVertexAccessType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AccessType, __InBuffer);
				}
			}
		}

		private static uint __NodeID = 0;

		private static uint __Metadata = 0;

		private static uint __AccessType = 0;

	}
}