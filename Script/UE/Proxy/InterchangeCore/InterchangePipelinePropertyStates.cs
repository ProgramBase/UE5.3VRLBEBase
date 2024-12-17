using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangePipelinePropertyStates")]
	public partial class FInterchangePipelinePropertyStates : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangeCore.InterchangePipelinePropertyStates");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangePipelinePropertyStates() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangePipelinePropertyStates() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangePipelinePropertyStates A, FInterchangePipelinePropertyStates B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangePipelinePropertyStates A, FInterchangePipelinePropertyStates B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangePipelinePropertyStates;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bLocked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bLocked, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bLocked, __InBuffer);
				}
			}
		}

		public FInterchangePipelinePropertyStatePerContext ImportStates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImportStates, __ReturnBuffer);

					return *(FInterchangePipelinePropertyStatePerContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImportStates, __InBuffer);
				}
			}
		}

		public FInterchangePipelinePropertyStatePerContext ReimportStates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReimportStates, __ReturnBuffer);

					return *(FInterchangePipelinePropertyStatePerContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReimportStates, __InBuffer);
				}
			}
		}

		private static uint __bLocked = 0;

		private static uint __ImportStates = 0;

		private static uint __ReimportStates = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}