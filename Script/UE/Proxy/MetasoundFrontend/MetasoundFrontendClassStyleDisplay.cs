using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendClassStyleDisplay")]
	public partial class FMetasoundFrontendClassStyleDisplay : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendClassStyleDisplay");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendClassStyleDisplay() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendClassStyleDisplay() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendClassStyleDisplay A, FMetasoundFrontendClassStyleDisplay B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendClassStyleDisplay A, FMetasoundFrontendClassStyleDisplay B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendClassStyleDisplay;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ImageName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImageName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImageName, __InBuffer);
				}
			}
		}

		public bool bShowName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowName, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowName, __InBuffer);
				}
			}
		}

		public bool bShowInputNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowInputNames, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowInputNames, __InBuffer);
				}
			}
		}

		public bool bShowOutputNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowOutputNames, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowOutputNames, __InBuffer);
				}
			}
		}

		public bool bShowLiterals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowLiterals, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowLiterals, __InBuffer);
				}
			}
		}

		private static uint __ImageName = 0;

		private static uint __bShowName = 0;

		private static uint __bShowInputNames = 0;

		private static uint __bShowOutputNames = 0;

		private static uint __bShowLiterals = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}