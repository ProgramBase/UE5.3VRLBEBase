using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendNodeStyle")]
	public partial class FMetasoundFrontendNodeStyle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendNodeStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendNodeStyle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendNodeStyle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendNodeStyle A, FMetasoundFrontendNodeStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendNodeStyle A, FMetasoundFrontendNodeStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendNodeStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMetasoundFrontendNodeStyleDisplay Display
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Display, __ReturnBuffer);

					return *(FMetasoundFrontendNodeStyleDisplay*)__ReturnBuffer;
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

		public bool bMessageNodeUpdated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bMessageNodeUpdated, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bMessageNodeUpdated, __InBuffer);
				}
			}
		}

		public bool bIsPrivate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsPrivate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsPrivate, __InBuffer);
				}
			}
		}

		private static uint __Display = 0;

		private static uint __bMessageNodeUpdated = 0;

		private static uint __bIsPrivate = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}