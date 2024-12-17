using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendInterfaceBinding")]
	public partial class FMetasoundFrontendInterfaceBinding : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendInterfaceBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendInterfaceBinding() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendInterfaceBinding() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendInterfaceBinding A, FMetasoundFrontendInterfaceBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendInterfaceBinding A, FMetasoundFrontendInterfaceBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendInterfaceBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMetasoundFrontendVersion OutputInterfaceVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OutputInterfaceVersion, __ReturnBuffer);

					return *(FMetasoundFrontendVersion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OutputInterfaceVersion, __InBuffer);
				}
			}
		}

		public FMetasoundFrontendVersion InputInterfaceVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputInterfaceVersion, __ReturnBuffer);

					return *(FMetasoundFrontendVersion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputInterfaceVersion, __InBuffer);
				}
			}
		}

		public int BindingPriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BindingPriority, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BindingPriority, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendInterfaceVertexBinding> VertexBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VertexBindings, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendInterfaceVertexBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VertexBindings, __InBuffer);
				}
			}
		}

		private static uint __OutputInterfaceVersion = 0;

		private static uint __InputInterfaceVersion = 0;

		private static uint __BindingPriority = 0;

		private static uint __VertexBindings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}