using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendGraph")]
	public partial class FMetasoundFrontendGraph : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendGraph");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendGraph() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendGraph() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendGraph A, FMetasoundFrontendGraph B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendGraph A, FMetasoundFrontendGraph B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendGraph;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMetasoundFrontendNode> Nodes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Nodes, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Nodes, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendEdge> Edges
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Edges, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendEdge>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Edges, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendVariable> Variables
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Variables, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Variables, __InBuffer);
				}
			}
		}

		public FMetasoundFrontendGraphStyle Style
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Style, __ReturnBuffer);

					return *(FMetasoundFrontendGraphStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Style, __InBuffer);
				}
			}
		}

		private static uint __Nodes = 0;

		private static uint __Edges = 0;

		private static uint __Variables = 0;

		private static uint __Style = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}