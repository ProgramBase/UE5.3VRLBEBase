using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendNodeInterface")]
	public partial class FMetasoundFrontendNodeInterface : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendNodeInterface");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendNodeInterface() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendNodeInterface() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendNodeInterface A, FMetasoundFrontendNodeInterface B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendNodeInterface A, FMetasoundFrontendNodeInterface B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendNodeInterface;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMetasoundFrontendVertex> Inputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Inputs, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendVertex>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Inputs, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendVertex> Outputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Outputs, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendVertex>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Outputs, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendVertex> Environment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Environment, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendVertex>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Environment, __InBuffer);
				}
			}
		}

		private static uint __Inputs = 0;

		private static uint __Outputs = 0;

		private static uint __Environment = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}