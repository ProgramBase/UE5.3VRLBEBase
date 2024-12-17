using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendInterfaceVertexBinding")]
	public partial class FMetasoundFrontendInterfaceVertexBinding : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendInterfaceVertexBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendInterfaceVertexBinding() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendInterfaceVertexBinding() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendInterfaceVertexBinding A, FMetasoundFrontendInterfaceVertexBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendInterfaceVertexBinding A, FMetasoundFrontendInterfaceVertexBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendInterfaceVertexBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName OutputName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OutputName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OutputName, __InBuffer);
				}
			}
		}

		public FName InputName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputName, __InBuffer);
				}
			}
		}

		private static uint __OutputName = 0;

		private static uint __InputName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}