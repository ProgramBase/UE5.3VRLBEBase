using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendDocument")]
	public partial class FMetasoundFrontendDocument : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendDocument");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendDocument() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendDocument() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendDocument A, FMetasoundFrontendDocument B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendDocument A, FMetasoundFrontendDocument B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendDocument;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMetasoundFrontendDocumentMetadata Metadata
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Metadata, __ReturnBuffer);

					return *(FMetasoundFrontendDocumentMetadata*)__ReturnBuffer;
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

		public TSet<FMetasoundFrontendVersion> Interfaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Interfaces, __ReturnBuffer);

					return *(TSet<FMetasoundFrontendVersion>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Interfaces, __InBuffer);
				}
			}
		}

		public FMetasoundFrontendGraphClass RootGraph
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootGraph, __ReturnBuffer);

					return *(FMetasoundFrontendGraphClass*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootGraph, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendGraphClass> Subgraphs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Subgraphs, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendGraphClass>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Subgraphs, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendClass> Dependencies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Dependencies, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendClass>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Dependencies, __InBuffer);
				}
			}
		}

		public FMetasoundFrontendVersion ArchetypeVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ArchetypeVersion, __ReturnBuffer);

					return *(FMetasoundFrontendVersion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ArchetypeVersion, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendVersion> InterfaceVersions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterfaceVersions, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendVersion>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterfaceVersions, __InBuffer);
				}
			}
		}

		private static uint __Metadata = 0;

		private static uint __Interfaces = 0;

		private static uint __RootGraph = 0;

		private static uint __Subgraphs = 0;

		private static uint __Dependencies = 0;

		private static uint __ArchetypeVersion = 0;

		private static uint __InterfaceVersions = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}